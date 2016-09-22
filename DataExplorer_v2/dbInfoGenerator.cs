using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using Microsoft.CSharp;

namespace DataExplorer
{
    class dbInfoGenerator
    {
        public static string
            _outputName = "dbinfo.dll";

        public static object GetDbInfo(System.Data.DataSet ds)
        {
            // Get a code provider object.
            System.CodeDom.Compiler.CodeDomProvider cdp = new Microsoft.CSharp.CSharpCodeProvider();

            // Create the namespace and import the default "System" namespace.
            System.CodeDom.CodeNamespace nmspc = new System.CodeDom.CodeNamespace("DataExplorer");
            nmspc.Imports.Add(new System.CodeDom.CodeNamespaceImport("System"));
            nmspc.Imports.Add(new System.CodeDom.CodeNamespaceImport("System.ComponentModel"));

            // Create a class object.
            System.CodeDom.CodeTypeDeclaration clsDbInfo = new System.CodeDom.CodeTypeDeclaration("DbInfo");
            clsDbInfo.IsClass = true;
            nmspc.Types.Add(clsDbInfo);

            // Add fields to the class for each value returned.
            List<string> fldNms = new List<string>();
            for (int i = 0; i < ds.Tables.Count; i++)
                for (int j = 0; j < ds.Tables[i].Columns.Count; j++)
                {
                    string fldNm = "_" + ds.Tables[i].Columns[j].ColumnName.ToLower();
                    if (!fldNms.Contains(fldNm))
                    {
                        System.CodeDom.CodeMemberField fld = new System.CodeDom.CodeMemberField(typeof(System.String), fldNm);
                        fld.Attributes = System.CodeDom.MemberAttributes.Public;
                        clsDbInfo.Members.Add(fld);
                        fldNms.Add(fldNm);
                    }
                }

            // Add properties for the class to access each field.
            List<string> propNms = new List<string>();
            for (int i = 0; i < ds.Tables.Count; i++)
                for (int j = 0; j < ds.Tables[i].Columns.Count; j++)
                {
                    string
                        fldNm = "_" + ds.Tables[i].Columns[j].ColumnName.ToLower(),
                        propNm = ds.Tables[i].Columns[j].ColumnName;

                    if (!propNms.Contains(propNm))
                    {
                        System.CodeDom.CodeMemberProperty prop = new System.CodeDom.CodeMemberProperty();
                        prop.Attributes = System.CodeDom.MemberAttributes.Public;
                        prop.Name = propNm;
                        prop.Type = new System.CodeDom.CodeTypeReference(typeof(System.String));
                        System.CodeDom.CodeVariableReferenceExpression retExp = new System.CodeDom.CodeVariableReferenceExpression(fldNm);
                        System.CodeDom.CodeMethodReturnStatement getReturn = new System.CodeDom.CodeMethodReturnStatement(retExp);
                        prop.GetStatements.Add(getReturn);
                        prop.HasGet = true;
                        prop.HasSet = false;
                        string catName = (ds.Tables[i].TableName.EndsWith("1")) ? "File Group" : "Database";
                        System.CodeDom.CodeAttributeDeclaration attrCat = new System.CodeDom.CodeAttributeDeclaration("Category", new System.CodeDom.CodeAttributeArgument(new System.CodeDom.CodePrimitiveExpression(catName)));
                        prop.CustomAttributes.Add(attrCat);
                        // Add the property to our class.
                        clsDbInfo.Members.Add(prop);
                        propNms.Add(propNm);
                    }
                }

            // Add a constructor to the class
            System.CodeDom.CodeConstructor clsDbInfoConstr = new System.CodeDom.CodeConstructor();
            clsDbInfoConstr.Attributes = System.CodeDom.MemberAttributes.Public;
            clsDbInfo.Members.Add(clsDbInfoConstr);

            // Create a CompileUnit for this new type.
            System.CodeDom.CodeCompileUnit cu = new System.CodeDom.CodeCompileUnit();
            cu.ReferencedAssemblies.Add("system.dll");
            cu.Namespaces.Add(nmspc);

            // Now, we're ready to generate some code!
#if DEBUG
            // If we're running in DEBUG mode, I want to see the generated code.
            using (System.IO.FileStream fs = new System.IO.FileStream("dbinfo.cs", System.IO.FileMode.Create, System.IO.FileAccess.Write))
            using (System.IO.StreamWriter sr = new System.IO.StreamWriter(fs))
                cdp.GenerateCodeFromCompileUnit(cu, sr, null);
#endif
            System.CodeDom.Compiler.CompilerParameters cp = new System.CodeDom.Compiler.CompilerParameters();
            cp.ReferencedAssemblies.Add("system.dll");
            cp.GenerateExecutable = false;
            cp.IncludeDebugInformation = false;
            cp.GenerateInMemory = false;
            //cp.OutputAssembly = _outputName;
            System.CodeDom.Compiler.CompilerResults cr = cdp.CompileAssemblyFromDom(cp, cu);

            if (!cr.Errors.HasErrors)
            {
                System.Reflection.Assembly asm = cr.CompiledAssembly;
                object dbInfo = asm.CreateInstance("DataExplorer.DbInfo");
                return dbInfo;
            }
            else
            {
                return null;
            }
        }
    }
}
