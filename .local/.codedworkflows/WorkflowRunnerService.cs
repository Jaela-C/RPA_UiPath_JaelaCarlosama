using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using UiPath_RPA_JaelaCarlosama;

[assembly: WorkflowRunnerServiceAttribute(typeof(UiPath_RPA_JaelaCarlosama.WorkflowRunnerService))]
namespace UiPath_RPA_JaelaCarlosama
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the ME_ExtractionDataCNT.xaml
        /// </summary>
        public (bool vBoolResultSearch, System.Data.DataTable vTblExtractData) ME_ExtractionDataCNT()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ME_ExtractionDataCNT.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return ((bool)result["vBoolResultSearch"], (System.Data.DataTable)result["vTblExtractData"]);
        }

        /// <summary>
        /// Invokes the ME_ExtractionDataCNT.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (bool vBoolResultSearch, System.Data.DataTable vTblExtractData) ME_ExtractionDataCNT(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ME_ExtractionDataCNT.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
            return ((bool)result["vBoolResultSearch"], (System.Data.DataTable)result["vTblExtractData"]);
        }

        /// <summary>
        /// Invokes the ME_SetDataCNT.xaml
        /// </summary>
        public (bool vBoolSetDataCNT, bool vBoolSetC) ME_SetDataCNT()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ME_SetDataCNT.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return ((bool)result["vBoolSetDataCNT"], (bool)result["vBoolSetC"]);
        }

        /// <summary>
        /// Invokes the ME_SetDataCNT.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (bool vBoolSetDataCNT, bool vBoolSetC) ME_SetDataCNT(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ME_SetDataCNT.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
            return ((bool)result["vBoolSetDataCNT"], (bool)result["vBoolSetC"]);
        }

        /// <summary>
        /// Invokes the ME_SolveCaptcha.xaml
        /// </summary>
        public bool ME_SolveCaptcha()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ME_SolveCaptcha.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (bool)result["vBoolSolveCaptcha"];
        }

        /// <summary>
        /// Invokes the ME_SolveCaptcha.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public bool ME_SolveCaptcha(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ME_SolveCaptcha.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
            return (bool)result["vBoolSolveCaptcha"];
        }

        /// <summary>
        /// Invokes the ME_SaveDataExcel.xaml
        /// </summary>
        public (bool vBoolGenerateExcel, int vIntGetTotalRows) ME_SaveDataExcel(System.Data.DataTable vTblExtractDataIn)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ME_SaveDataExcel.xaml", new Dictionary<string, object>{{"vTblExtractDataIn", vTblExtractDataIn}}, default, default, default, GetAssemblyName());
            return ((bool)result["vBoolGenerateExcel"], (int)result["vIntGetTotalRows"]);
        }

        /// <summary>
        /// Invokes the ME_SaveDataExcel.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (bool vBoolGenerateExcel, int vIntGetTotalRows) ME_SaveDataExcel(System.Data.DataTable vTblExtractDataIn, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ME_SaveDataExcel.xaml", new Dictionary<string, object>{{"vTblExtractDataIn", vTblExtractDataIn}}, default, isolated, default, GetAssemblyName());
            return ((bool)result["vBoolGenerateExcel"], (int)result["vIntGetTotalRows"]);
        }

        /// <summary>
        /// Invokes the ME_SendEmail.xaml
        /// </summary>
        public void ME_SendEmail(int vIntGetTotalRows, bool vBoolResultSearch, string vStrEmail)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ME_SendEmail.xaml", new Dictionary<string, object>{{"vIntGetTotalRows", vIntGetTotalRows}, {"vBoolResultSearch", vBoolResultSearch}, {"vStrEmail", vStrEmail}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ME_SendEmail.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ME_SendEmail(int vIntGetTotalRows, bool vBoolResultSearch, string vStrEmail, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ME_SendEmail.xaml", new Dictionary<string, object>{{"vIntGetTotalRows", vIntGetTotalRows}, {"vBoolResultSearch", vBoolResultSearch}, {"vStrEmail", vStrEmail}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ME_RequestVariables.xaml
        /// </summary>
        public bool ME_RequestVariables()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ME_RequestVariables.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (bool)result["vValidateInValues"];
        }

        /// <summary>
        /// Invokes the ME_RequestVariables.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public bool ME_RequestVariables(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ME_RequestVariables.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
            return (bool)result["vValidateInValues"];
        }

        /// <summary>
        /// Invokes the ME_MainDirectoryCNT.xaml
        /// </summary>
        public void ME_MainDirectoryCNT()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ME_MainDirectoryCNT.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ME_MainDirectoryCNT.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ME_MainDirectoryCNT(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ME_MainDirectoryCNT.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}