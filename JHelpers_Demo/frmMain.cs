using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;
using Jeff.Jones.JHelpers;
using System.Collections;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading;

namespace JHelpers_Demo
{
	public partial class frmMain : Form
	{

		public static class JHelpersItems
		{
			public const String AddCheck = "AddCheck";
			public const String AmIRunningInTheIDE = "AmIRunningInTheIDE";
			public const String Asc = "Asc";
			public const String AssemblyCompany = "AssemblyCompany";
			public const String AssemblyCopyright = "AssemblyCopyright";
			public const String AssemblyDescription = "AssemblyDescription";
			public const String AssemblyProduct = "AssemblyProduct";
			public const String AssemblyTitle = "AssemblyTitle";
			public const String AssemblyVersion = "AssemblyVersion";
			public const String AvailableRAMinMB = "AvailableRAMinMB";
			public const String Base64ToString = "Base64ToString";
			public const String CelsiusToFahrenheit = "CelsiusToFahrenheit";
			public const String ColumnDelimiter = "ColumnDelimiter";
			public const String Contains = "Contains";
			public const String ContainsHowMany = "ContainsHowMany";
			public const String ConvertFeetToMeters = "ConvertFeetToMeters";
			public const String ConvertMetersToFeet = "ConvertMetersToFeet";
			public const String ConvertMilesToKilometers = "ConvertMilesToKilometers";
			public const String ConvertKilometersToMiles = "ConvertKilometersToMiles";
			public const String ConvertGallonsToLiters = "ConvertGallonsToLiters";
			public const String ConvertLitersToGallons = "ConvertLitersToGallons";
			public const String ConvertToBoolean = "ConvertToBoolean";
			public const String CurDir = "CurDir";
			public const String CurrentTimeZoneDaylightName = "CurrentTimeZoneDaylightName";
			public const String CurrentTimeZoneName = "CurrentTimeZoneName";
			public const String DegreesToRadians = "DegreesToRadians";
			public const String FahrenheitToCelsius = "FahrenheitToCelsius";
			public const String FullComputerName = "FullComputerName";
			public const String GetComputerDomainName = "GetComputerDomainName";
			public const String GetCurrentCPUUsage = "GetCurrentCPUUsage";
			public const String GetDateTime = "GetDateTime";
			public const String GetDecimal = "GetDecimal";
			public const String GetDefaultValue = "GetDefaultValue";
			public const String GetDNSName = "GetDNSName";
			public const String GetDrives = "GetDrives";
			public const String GetExceptionInfo = "GetExceptionInfo";
			public const String GetFullComputerDomainName = "GetFullComputerDomainName";
			public const String GetFullDateTimeStampForFileName = "GetFullDateTimeStampForFileName";
			public const String GetFullExceptionMessage = "GetFullExceptionMessage";
			public const String GetInt32 = "GetInt32";
			public const String GetInt64 = "GetInt64";
			public const String GetIntBitValue = "GetIntBitValue";
			public const String GetLinearDistance = "GetLinearDistance";
			public const String GetLinearDistances = "GetLinearDistances";
			public const String GetMinPasswordLength = "GetMinPasswordLength";
			public const String GetLocalPrinters = "GetLocalPrinters";
			public const String GetNetworkPrinters = "GetNetworkPrinters";
			public const String GetOnlyDigits = "GetOnlyDigits";
			public const String GetOnlyLetters = "GetOnlyLetters";
			public const String GetOnlyLettersAndDigits = "GetOnlyLettersAndDigits";
			public const String GetStackInfo = "GetStackInfo";
			public const String GetTotalHDDFreeSpace = "GetTotalHDDFreeSpace";
			public const String GetTotalHDDSize = "GetTotalHDDSize";
			public const String Hex = "Hex";
			public const String IsBoolean = "IsBoolean";
			public const String IsDaylightSavingsTime = "IsDaylightSavingsTime";
			public const String IsEmailFormat = "IsEmailFormat";
			public const String IsFileText = "IsFileText";
			public const String IsInDomain = "IsInDomain";
			public const String IsIPAddress = "IsIPAddress";
			public const String IsOnlyDigits = "IsOnlyDigits";
			public const String IsOnlyLetters = "IsOnlyLetters";
			public const String IsOnlyLettersAndOrDigits = "IsOnlyLettersAndOrDigits";
			public const String Ping = "Ping";
			public const String RadianToDegree = "RadianToDegree";
			public const String RowDelimiter = "RowDelimiter";
			public const String SetIntBitValue = "SetIntBitValue";
			public const String StringToBase64 = "StringToBase64";
			public const String TableDelimiter = "TableDelimiter";
			public const String TryGetValue = "TryGetValue";
			public const String WriteToLog = "WriteToLog";
		}

		private String m_TEST_STRING = "\t   Attributes" + Environment.NewLine +
									"\t   Availability" + Environment.NewLine +
									"\t   AvailableJobSheets" + Environment.NewLine +
									"\t   AveragePagesPerMinute" + Environment.NewLine +
									"\t   Capabilities" + Environment.NewLine +
									"\t   CapabilityDescriptions" + Environment.NewLine +
									"\t   Caption" + Environment.NewLine +
									"\t   CharSetsSupported" + Environment.NewLine +
									"\t   Comment" + Environment.NewLine +
									"\t   ConfigManagerErrorCode" + Environment.NewLine +
									"\t   ConfigManagerUserConfig" + Environment.NewLine +
									"\t   CreationClassName" + Environment.NewLine +
									"\t   CurrentCapabilities" + Environment.NewLine +
									"\t   CurrentCharSet" + Environment.NewLine +
									"\t   CurrentLanguage" + Environment.NewLine +
									"\t   CurrentMimeType" + Environment.NewLine +
									"\t   CurrentNaturalLanguage" + Environment.NewLine +
									"\t   CurrentPaperType" + Environment.NewLine +
									"\t   Default" + Environment.NewLine +
									"\t   DefaultCapabilities" + Environment.NewLine +
									"\t   DefaultCopies" + Environment.NewLine +
									"\t   DefaultLanguage" + Environment.NewLine +
									"\t   DefaultMimeType" + Environment.NewLine +
									"\t   DefaultNumberUp" + Environment.NewLine +
									"\t   DefaultPaperType" + Environment.NewLine +
									"\t   DefaultPriority" + Environment.NewLine +
									"\t   Description" + Environment.NewLine +
									"\t   DetectedErrorState" + Environment.NewLine +
									"\t   DeviceID" + Environment.NewLine +
									"\t   Direct" + Environment.NewLine +
									"\t   DoCompleteFirst" + Environment.NewLine +
									"\t   DriverName" + Environment.NewLine +
									"\t   EnableBIDI" + Environment.NewLine +
									"\t   EnableDevQueryPrint" + Environment.NewLine +
									"\t   ErrorCleared" + Environment.NewLine +
									"\t   ErrorDescription" + Environment.NewLine +
									"\t   ErrorInformation" + Environment.NewLine +
									"\t   ExtendedDetectedErrorState" + Environment.NewLine +
									"\t   ExtendedPrinterStatus" + Environment.NewLine +
									"\t   Hidden" + Environment.NewLine +
									"\t   HorizontalResolution" + Environment.NewLine +
									"\t   InstallDate" + Environment.NewLine +
									"\t   JobCountSinceLastReset" + Environment.NewLine +
									"\t   KeepPrintedJobs" + Environment.NewLine +
									"\t   LanguagesSupported" + Environment.NewLine +
									"\t   LastErrorCode" + Environment.NewLine +
									"\t   Local" + Environment.NewLine +
									"\t   Location" + Environment.NewLine +
									"\t   MarkingTechnology" + Environment.NewLine +
									"\t   MaxCopies" + Environment.NewLine +
									"\t   MaxNumberUp" + Environment.NewLine +
									"\t   MaxSizeSupported" + Environment.NewLine +
									"\t   MimeTypesSupported" + Environment.NewLine +
									"\t   Name" + Environment.NewLine +
									"\t   NaturalLanguagesSupported" + Environment.NewLine +
									"\t   Network" + Environment.NewLine +
									"\t   PaperSizesSupported" + Environment.NewLine +
									"\t   PaperTypesAvailable" + Environment.NewLine +
									"\t   Parameters" + Environment.NewLine +
									"\t   PNPDeviceID" + Environment.NewLine +
									"\t   PortName" + Environment.NewLine +
									"\t   PowerManagementCapabilities" + Environment.NewLine +
									"\t   PowerManagementSupported" + Environment.NewLine +
									"\t   PrinterPaperNames" + Environment.NewLine +
									"\t   PrinterState" + Environment.NewLine +
									"\t   PrinterStatus" + Environment.NewLine +
									"\t   PrintJobDataType" + Environment.NewLine +
									"\t   PrintProcessor" + Environment.NewLine +
									"\t   Priority" + Environment.NewLine +
									"\t   Published" + Environment.NewLine +
									"\t   Queued" + Environment.NewLine +
									"\t   RawOnly" + Environment.NewLine +
									"\t   SeparatorFile" + Environment.NewLine +
									"\t   ServerName" + Environment.NewLine +
									"\t   Shared" + Environment.NewLine +
									"\t   ShareName" + Environment.NewLine +
									"\t   SpoolEnabled" + Environment.NewLine +
									"\t   StartTime" + Environment.NewLine +
									"\t   Status" + Environment.NewLine +
									"\t   StatusInfo" + Environment.NewLine +
									"\t   SystemCreationClassName" + Environment.NewLine +
									"\t   SystemName" + Environment.NewLine +
									"\t   TimeOfLastReset" + Environment.NewLine +
									"\t   UntilTime" + Environment.NewLine +
									"\t   VerticalResolution" + Environment.NewLine +
									"\t   WorkOffline";

		/// <summary>
		/// Constructor.
		/// </summary>
		public frmMain()
		{
			InitializeComponent();

			Boolean retVal = false;
			ContextMgr.Instance.ContextValues.AddCheck("Computer Name", Environment.MachineName);
			ContextMgr.Instance.ContextValues.AddCheck("Startup Time", DateTime.Now);

			lstOperations.Items.Add(JHelpersItems.AddCheck);
			lstOperations.Items.Add(JHelpersItems.AmIRunningInTheIDE);
			lstOperations.Items.Add(JHelpersItems.Asc);
			lstOperations.Items.Add(JHelpersItems.AssemblyCompany);
			lstOperations.Items.Add(JHelpersItems.AssemblyCopyright);
			lstOperations.Items.Add(JHelpersItems.AssemblyDescription);
			lstOperations.Items.Add(JHelpersItems.AssemblyProduct);
			lstOperations.Items.Add(JHelpersItems.AssemblyTitle);
			lstOperations.Items.Add(JHelpersItems.AssemblyVersion);
			lstOperations.Items.Add(JHelpersItems.AvailableRAMinMB);
			lstOperations.Items.Add(JHelpersItems.Base64ToString);
			lstOperations.Items.Add(JHelpersItems.CelsiusToFahrenheit);
			lstOperations.Items.Add(JHelpersItems.ColumnDelimiter);
			lstOperations.Items.Add(JHelpersItems.Contains);
			lstOperations.Items.Add(JHelpersItems.ContainsHowMany);
			lstOperations.Items.Add(JHelpersItems.ConvertToBoolean);
			lstOperations.Items.Add(JHelpersItems.ConvertFeetToMeters);
			lstOperations.Items.Add(JHelpersItems.ConvertGallonsToLiters);
			lstOperations.Items.Add(JHelpersItems.ConvertKilometersToMiles);
			lstOperations.Items.Add(JHelpersItems.ConvertLitersToGallons);
			lstOperations.Items.Add(JHelpersItems.ConvertMetersToFeet);
			lstOperations.Items.Add(JHelpersItems.ConvertMilesToKilometers);
			lstOperations.Items.Add(JHelpersItems.CurDir);
			lstOperations.Items.Add(JHelpersItems.CurrentTimeZoneDaylightName);
			lstOperations.Items.Add(JHelpersItems.CurrentTimeZoneName);
			lstOperations.Items.Add(JHelpersItems.DegreesToRadians);
			lstOperations.Items.Add(JHelpersItems.FahrenheitToCelsius);
			lstOperations.Items.Add(JHelpersItems.FullComputerName);
			lstOperations.Items.Add(JHelpersItems.GetComputerDomainName);
			lstOperations.Items.Add(JHelpersItems.GetCurrentCPUUsage);
			lstOperations.Items.Add(JHelpersItems.GetDateTime);
			lstOperations.Items.Add(JHelpersItems.GetDecimal);
			lstOperations.Items.Add(JHelpersItems.GetDefaultValue);
			lstOperations.Items.Add(JHelpersItems.GetDNSName);
			lstOperations.Items.Add(JHelpersItems.GetDrives);
			lstOperations.Items.Add(JHelpersItems.GetExceptionInfo);
			lstOperations.Items.Add(JHelpersItems.GetFullComputerDomainName);
			lstOperations.Items.Add(JHelpersItems.GetFullDateTimeStampForFileName);
			lstOperations.Items.Add(JHelpersItems.GetFullExceptionMessage);
			lstOperations.Items.Add(JHelpersItems.GetInt32);
			lstOperations.Items.Add(JHelpersItems.GetInt64);
			lstOperations.Items.Add(JHelpersItems.GetIntBitValue);
			lstOperations.Items.Add(JHelpersItems.GetLinearDistance);
			lstOperations.Items.Add(JHelpersItems.GetLinearDistances);
			lstOperations.Items.Add(JHelpersItems.GetMinPasswordLength);
			lstOperations.Items.Add(JHelpersItems.GetLocalPrinters);
			lstOperations.Items.Add(JHelpersItems.GetNetworkPrinters);
			lstOperations.Items.Add(JHelpersItems.GetOnlyDigits);
			lstOperations.Items.Add(JHelpersItems.GetOnlyLetters);
			lstOperations.Items.Add(JHelpersItems.GetOnlyLettersAndDigits);
			lstOperations.Items.Add(JHelpersItems.GetStackInfo);
			lstOperations.Items.Add(JHelpersItems.GetTotalHDDFreeSpace);
			lstOperations.Items.Add(JHelpersItems.GetTotalHDDSize);
			lstOperations.Items.Add(JHelpersItems.Hex);
			lstOperations.Items.Add(JHelpersItems.IsBoolean);
			lstOperations.Items.Add(JHelpersItems.IsDaylightSavingsTime);
			lstOperations.Items.Add(JHelpersItems.IsEmailFormat);
			lstOperations.Items.Add(JHelpersItems.IsFileText);
			lstOperations.Items.Add(JHelpersItems.IsInDomain);
			lstOperations.Items.Add(JHelpersItems.IsIPAddress);
			lstOperations.Items.Add(JHelpersItems.IsOnlyDigits);
			lstOperations.Items.Add(JHelpersItems.IsOnlyLetters);
			lstOperations.Items.Add(JHelpersItems.IsOnlyLettersAndOrDigits);
			lstOperations.Items.Add(JHelpersItems.Ping);
			lstOperations.Items.Add(JHelpersItems.RadianToDegree);
			lstOperations.Items.Add(JHelpersItems.RowDelimiter);
			lstOperations.Items.Add(JHelpersItems.SetIntBitValue);
			lstOperations.Items.Add(JHelpersItems.StringToBase64);
			lstOperations.Items.Add(JHelpersItems.TableDelimiter);
			lstOperations.Items.Add(JHelpersItems.TryGetValue);
			lstOperations.Items.Add(JHelpersItems.WriteToLog);


			dynamic machineName = "";
			retVal = ContextMgr.Instance.ContextValues.TryGetValue("Computer Name", out machineName);
			dynamic startupTime = "";
			retVal = ContextMgr.Instance.ContextValues.TryGetValue("Startup Time", out startupTime);
			this.Text = $"JHelpers Demo on {machineName} started at {((DateTime)startupTime).ToShortDateString()}";

		}

		/// <summary>
		/// Method executes when an item is clicked on, causing the index to change.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lstOperations_SelectedIndexChanged(object sender, EventArgs e)
		{

			String selectedItem = lstOperations.SelectedItem.ToString();

			txtDescription.Text = "Description:" + Environment.NewLine + Environment.NewLine;
			txtResults.Text = "Results:" + Environment.NewLine + Environment.NewLine;

			switch (selectedItem)
			{
				case JHelpersItems.AddCheck:
					AddCheck();
					break;
				case JHelpersItems.AmIRunningInTheIDE:
					AmIRunningInTheIDE();
					break;
				case JHelpersItems.Asc:
					Asc();
					break;
				case JHelpersItems.AssemblyCompany:
					AssemblyCompany();
					break;
				case JHelpersItems.AssemblyCopyright:
					AssemblyCopyright();
					break;
				case JHelpersItems.AssemblyDescription:
					AssemblyDescription();
					break;
				case JHelpersItems.AssemblyProduct:
					AssemblyProduct();
					break;
				case JHelpersItems.AssemblyTitle:
					AssemblyTitle();
					break;
				case JHelpersItems.AssemblyVersion:
					AssemblyVersion();
					break;
				case JHelpersItems.AvailableRAMinMB:
					AvailableRAMinMB();
					break;
				case JHelpersItems.Base64ToString:
					Base64ToString();
					break;
				case JHelpersItems.CelsiusToFahrenheit:
					CelsiusToFahrenheit();
					break;
				case JHelpersItems.ColumnDelimiter:
					ColumnDelimiter();
					break;
				case JHelpersItems.Contains:
					Contains();
					break;
				case JHelpersItems.ContainsHowMany:
					ContainsHowMany();
					break;
				case JHelpersItems.ConvertToBoolean:
					ConvertToBoolean();
					break;
				case JHelpersItems.ConvertFeetToMeters:
					ConvertFeetToMeters();
					break;
				case JHelpersItems.ConvertGallonsToLiters:
					ConvertGallonsToLiters();
					break;
				case JHelpersItems.ConvertKilometersToMiles:
					ConvertKilometersToMiles();
					break;
				case JHelpersItems.ConvertLitersToGallons:
					ConvertLitersToGallons();
					break;
				case JHelpersItems.ConvertMetersToFeet:
					ConvertMetersToFeet();
					break;
				case JHelpersItems.ConvertMilesToKilometers:
					ConvertMilesToKilometers();
					break;
				case JHelpersItems.CurDir:
					CurDir();
					break;
				case JHelpersItems.CurrentTimeZoneDaylightName:
					CurrentTimeZoneDaylightName();
					break;
				case JHelpersItems.CurrentTimeZoneName:
					CurrentTimeZoneName();
					break;
				case JHelpersItems.DegreesToRadians:
					DegreesToRadians();
					break;
				case JHelpersItems.FahrenheitToCelsius:
					FahrenheitToCelsius();
					break;
				case JHelpersItems.FullComputerName:
					FullComputerName();
					break;
				case JHelpersItems.GetComputerDomainName:
					GetComputerDomainName();
					break;
				case JHelpersItems.GetCurrentCPUUsage:
					GetCurrentCPUUsage();
					break;
				case JHelpersItems.GetDateTime:
					GetDateTime();
					break;
				case JHelpersItems.GetDecimal:
					GetDecimal();
					break;
				case JHelpersItems.GetDefaultValue:
					GetDefaultValue();
					break;
				case JHelpersItems.GetDNSName:
					GetDNSName();
					break;
				case JHelpersItems.GetDrives:
					GetDrives();
					break;
				case JHelpersItems.GetExceptionInfo:
					GetExceptionInfo();
					break;
				case JHelpersItems.GetFullComputerDomainName:
					GetFullComputerDomainName();
					break;
				case JHelpersItems.GetFullDateTimeStampForFileName:
					GetFullDateTimeStampForFileName();
					break;
				case JHelpersItems.GetFullExceptionMessage:
					GetFullExceptionMessage();
					break;
				case JHelpersItems.GetInt32:
					GetInt32();
					break;
				case JHelpersItems.GetInt64:
					GetInt64();
					break;
				case JHelpersItems.GetIntBitValue:
					GetIntBitValue();
					break;
				case JHelpersItems.GetLinearDistance:
					GetLinearDistance();
					break;
				case JHelpersItems.GetLinearDistances:
					GetLinearDistances();
					break;
				case JHelpersItems.GetMinPasswordLength:
					GetMinPasswordLength();
					break;
				case JHelpersItems.GetLocalPrinters:
					GetLocalPrinters();
					break;
				case JHelpersItems.GetNetworkPrinters:
					GetNetworkPrinters();
					break;
				case JHelpersItems.GetOnlyDigits:
					GetOnlyDigits();
					break;
				case JHelpersItems.GetOnlyLetters:
					GetOnlyLetters();
					break;
				case JHelpersItems.GetOnlyLettersAndDigits:
					GetOnlyLettersAndDigits();
					break;
				case JHelpersItems.GetStackInfo:
					GetStackInfo();
					break;
				case JHelpersItems.GetTotalHDDFreeSpace:
					GetTotalHDDFreeSpace();
					break;
				case JHelpersItems.GetTotalHDDSize:
					GetTotalHDDSize();
					break;
				case JHelpersItems.Hex:
					Hex();
					break;
				case JHelpersItems.IsBoolean:
					IsBoolean();
					break;
				case JHelpersItems.IsDaylightSavingsTime:
					IsDaylightSavingsTime();
					break;
				case JHelpersItems.IsEmailFormat:
					IsEmailFormat();
					break;
				case JHelpersItems.IsFileText:
					IsFileText();
					break;
				case JHelpersItems.IsInDomain:
					IsInDomain();
					break;
				case JHelpersItems.IsIPAddress:
					IsIPAddress();
					break;
				case JHelpersItems.IsOnlyDigits:
					IsOnlyDigits();
					break;
				case JHelpersItems.IsOnlyLetters:
					IsOnlyLetters();
					break;
				case JHelpersItems.IsOnlyLettersAndOrDigits:
					IsOnlyLettersAndOrDigits();
					break;
				case JHelpersItems.Ping:
					Ping();
					break;
				case JHelpersItems.RadianToDegree:
					RadianToDegree();
					break;
				case JHelpersItems.RowDelimiter:
					RowDelimiter();
					break;
				case JHelpersItems.SetIntBitValue:
					SetIntBitValue();
					break;
				case JHelpersItems.StringToBase64:
					StringToBase64();
					break;
				case JHelpersItems.TableDelimiter:
					TableDelimiter();
					break;
				case JHelpersItems.TryGetValue:
					TryGetValue();
					break;
				case JHelpersItems.WriteToLog:
					WriteToLog();
					break;
				default:

					break;
			}

		}


		private void AddCheck()
		{

			txtDescription.Text += "This extension method applies to IDictionary, such as the Exception.Data collection.  It checks to see if a key is already in use, and appends the key name with an increasing number until the new key is unique.  " +
								  "If a key is named \"Param1\", and already exists, then a new key is created of \"Param1-1\"." + Environment.NewLine + Environment.NewLine +
								  "\texInner.Data.AddCheck(\"Param1\", DateTime.Now);" + Environment.NewLine +
								  "\texInner.Data.AddCheck(\"Param1\", \"Duplicate key name\");" + Environment.NewLine +
								  "\texInner.Data.AddCheck(\"Param1\", null);";

			ArgumentException exInner = new ArgumentException("Argument was invalid.");

			exInner.Data.AddCheck("Param1", DateTime.Now);
			exInner.Data.AddCheck("Param1", "Duplicate key name");
			exInner.Data.AddCheck("Param1", null);

			foreach (DictionaryEntry item in exInner.Data)
			{
				txtResults.Text += $"Key = [{item.Key}]  Value = [{item.Value}]  Data Type = [{item.Value.GetType().Name}]{Environment.NewLine}";
			}


		}

		private void AmIRunningInTheIDE()
		{
			txtDescription.Text += "The property checks to see if the process is running in the IDE, or running compiled.  " +
								  "True if running in the IDE, false if running compiled." + Environment.NewLine + Environment.NewLine +
								  "\tBoolean result = CommonHelpers.AmIRunningInTheIDE;";

			Boolean result = CommonHelpers.AmIRunningInTheIDE;

			if (result)
			{
				txtResults.Text += "Running in the IDE";
			}
			else
			{
				txtResults.Text += "Running compiled";
			}
		}

		private void Asc()
		{
			txtDescription.Text += "The function provides the ASCII value for a given character." + Environment.NewLine + Environment.NewLine +
						  "\tInt32 result = CommonHelpers.Asc(\"T\");";

			Int32 result = CommonHelpers.Asc("T");

			txtResults.Text += $"T is ASCII value {result}.";
		}

		private void AssemblyCompany()
		{
			txtDescription.Text += "The property gets the assembly's Company name." + Environment.NewLine + Environment.NewLine +
						  "\tString result = CommonHelpers.AssemblyCompany;";

			String result = CommonHelpers.AssemblyCompany;

			txtResults.Text += $"Company: {result}.";
		}

		private void AssemblyCopyright()
		{
			txtDescription.Text += "The property gets the assembly's copyright." + Environment.NewLine + Environment.NewLine +
									"\tString result = CommonHelpers.AssemblyCopyright;";

			String result = CommonHelpers.AssemblyCopyright;

			txtResults.Text += $"Copyright: {result}.";
		}

		private void AssemblyDescription()
		{
			txtDescription.Text += "The property gets the assembly's description." + Environment.NewLine + Environment.NewLine +
									"\tString result = CommonHelpers.AssemblyDescription;";

			String result = CommonHelpers.AssemblyDescription;

			txtResults.Text += $"Description: {result}.";

		}

		private void AssemblyProduct()
		{
			txtDescription.Text += "The property gets the assembly's product name." + Environment.NewLine + Environment.NewLine +
									"\tString result = CommonHelpers.AssemblyProduct;";

			String result = CommonHelpers.AssemblyProduct;

			txtResults.Text += $"Product: {result}.";

		}

		private void AssemblyTitle()
		{
			txtDescription.Text += "The property gets the assembly's title." + Environment.NewLine + Environment.NewLine +
									"\tString result = CommonHelpers.AssemblyTitle;";

			String result = CommonHelpers.AssemblyTitle;

			txtResults.Text += $"Title: {result}.";
		}

		private void AssemblyVersion()
		{
			txtDescription.Text += "The property gets the assembly's version." + Environment.NewLine + Environment.NewLine +
				  "\tString result = CommonHelpers.AssemblyVersion;";

			String result = CommonHelpers.AssemblyVersion;

			txtResults.Text += $"Version: {result}.";

		}

		private void AvailableRAMinMB()
		{
			txtDescription.Text += "The method gets the amount of available RAM in megabytes" + Environment.NewLine + Environment.NewLine +
									"\tInt32 result = CommonHelpers.AvailableRAMinMB();";

			Int32 result = CommonHelpers.AvailableRAMinMB();

			txtResults.Text += $"Available RAM (MB): {result}.";
		}

		private void Base64ToString()
		{
			txtDescription.Text += "Converts a base 64 string to its original value." + Environment.NewLine + Environment.NewLine +
									"\tString result = CommonHelpers.Base64ToString(base64);";

			String orig = "I am a string";
			String base64 = CommonHelpers.StringToBase64(orig);
			String result = CommonHelpers.Base64ToString(base64);

			txtResults.Text += $"The base 64 value [{base64}] converted to string: [{result}].";

		}

		private void CelsiusToFahrenheit()
		{
			txtDescription.Text += "Converts degrees Celsius to Fahrenheit" + Environment.NewLine + Environment.NewLine +
									"\tDouble result = CommonHelpers.CelsiusToFahrenheit(25);";

			Double result = CommonHelpers.CelsiusToFahrenheit(25);

			txtResults.Text += $"25°C = {result}°F.";

		}

		private void ColumnDelimiter()
		{
			txtDescription.Text += "Returns a common, nonprintable ASCII colummn delimiter." + Environment.NewLine + Environment.NewLine +
									"\tString result = CommonHelpers.ColumnDelimiter;";

			String result = CommonHelpers.ColumnDelimiter;
			Int32 delimValue = CommonHelpers.Asc(result);

			txtResults.Text += $"Column delimiter ASCII value = {delimValue}";

		}

		private void Contains()
		{
			txtDescription.Text += "String extension method that give Contains the choice of case sensitivity." + Environment.NewLine + Environment.NewLine +
									"\tBoolean result1 = origString.Contains(\"Original\", StringComparison.CurrentCulture);" + Environment.NewLine +
									"\tBoolean result2 = origString.Contains(\"Original\", StringComparison.CurrentCultureIgnoreCase);";

			String origString = "This is the original string.";

			Boolean result1 = origString.Contains("Original", StringComparison.CurrentCulture);
			Boolean result2 = origString.Contains("Original", StringComparison.CurrentCultureIgnoreCase);

			txtResults.Text += $"Is the word [Original] found, case sensitive, in the sentence [This is the original string.]? {result1}{Environment.NewLine}";
			txtResults.Text += $"Is the word [Original] found, NOT case sensitive, in the sentence [This is the original string.]? {result2}";

		}

		private void ContainsHowMany()
		{
			txtDescription.Text += "String extension method that counts how many times a given string occurs within the main string, with out without case sensitivity?" + Environment.NewLine + Environment.NewLine +
									"\tInt32 result1 = origString.ContainsHowMany(\"tea\", true);" + Environment.NewLine +
									"\tInt32 result2 = origString.ContainsHowMany(\"tea\");";

			String origString = "Having tea with the Team.";

			Int32 result1 = origString.ContainsHowMany("tea", true);
			Int32 result2 = origString.ContainsHowMany("tea");

			txtResults.Text += $"How many times do the letters [tea], NOT case sensitive, occur in the sentence [Having tea with the Team.]? {result1}{Environment.NewLine}";
			txtResults.Text += $"How many times do the letters [tea], case sensitive, occur in the sentence [Having tea with the Team.]? {result2}";

		}

		private void ConvertToBoolean()
		{
			txtDescription.Text += "String extension method that converts a string to a boolean value." + Environment.NewLine +
									"Recognizes as true (case insensitive) true, on, yes, up, ok, good, 1, -1" + Environment.NewLine +
									"Recognizes as false (case insensitive): false, off, no, down, not ok, bad, 0" + Environment.NewLine + Environment.NewLine +
									"\tBoolean result1 = origString.ConvertToBoolean(out isBoolean);";


			String origString = "trUe";
			Boolean isBoolean = false;
			Boolean result1 = origString.ConvertToBoolean(out isBoolean);
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}. Converts to [{result1}].{Environment.NewLine}";

			origString = "oN";
			isBoolean = false;
			result1 = origString.ConvertToBoolean(out isBoolean);
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}. Converts to [{result1}].{Environment.NewLine}";

			origString = "yEs";
			isBoolean = false;
			result1 = origString.ConvertToBoolean(out isBoolean);
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}. Converts to [{result1}].{Environment.NewLine}";

			origString = "uP";
			isBoolean = false;
			result1 = origString.ConvertToBoolean(out isBoolean);
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}. Converts to [{result1}].{Environment.NewLine}";

			origString = "oK";
			isBoolean = false;
			result1 = origString.ConvertToBoolean(out isBoolean);
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}. Converts to [{result1}].{Environment.NewLine}";

			origString = "gOOd";
			isBoolean = false;
			result1 = origString.ConvertToBoolean(out isBoolean);
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}. Converts to [{result1}].{Environment.NewLine}";

			origString = "1";
			isBoolean = false;
			result1 = origString.ConvertToBoolean(out isBoolean);
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}. Converts to [{result1}].{Environment.NewLine}";

			origString = "-1";
			isBoolean = false;
			result1 = origString.ConvertToBoolean(out isBoolean);
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}. Converts to [{result1}].{Environment.NewLine}";

			origString = "Booger";
			isBoolean = false;
			result1 = origString.ConvertToBoolean(out isBoolean);
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}.{Environment.NewLine}";

			// Recognizes as false (case insensitive): false, off, no, down, not ok, bad, 0
			origString = "fAlSe";
			isBoolean = false;
			result1 = origString.ConvertToBoolean(out isBoolean);
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}. Converts to [{result1}].{Environment.NewLine}";

			origString = "oFF";
			isBoolean = false;
			result1 = origString.ConvertToBoolean(out isBoolean);
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}. Converts to [{result1}].{Environment.NewLine}";

			origString = "nO";
			isBoolean = false;
			result1 = origString.ConvertToBoolean(out isBoolean);
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}. Converts to [{result1}].{Environment.NewLine}";

			origString = "dOWn";
			isBoolean = false;
			result1 = origString.ConvertToBoolean(out isBoolean);
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}. Converts to [{result1}].{Environment.NewLine}";

			origString = "nOt Ok";
			isBoolean = false;
			result1 = origString.ConvertToBoolean(out isBoolean);
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}. Converts to [{result1}].{Environment.NewLine}";

			origString = "BaD";
			isBoolean = false;
			result1 = origString.ConvertToBoolean(out isBoolean);
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}. Converts to [{result1}].{Environment.NewLine}";

			origString = "0";
			isBoolean = false;
			result1 = origString.ConvertToBoolean(out isBoolean);
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}. Converts to [{result1}].{Environment.NewLine}";


		}

		private void ConvertFeetToMeters()
		{
			txtDescription.Text += "Converts feet to meters." + Environment.NewLine + Environment.NewLine +
										"\tDecimal result = CommonHelpers.ConvertFeetToMeters(10);";

			Decimal result = CommonHelpers.ConvertFeetToMeters(10);

			txtResults.Text += $"10 feet = {result} meters.";
		}

		private void ConvertGallonsToLiters()
		{
			txtDescription.Text += "Converts gallons to liters." + Environment.NewLine + Environment.NewLine +
										"\tDecimal result = CommonHelpers.ConvertGallonsToLiters(10);";

			Decimal result = CommonHelpers.ConvertGallonsToLiters(10);

			txtResults.Text += $"10 gallons = {result} liters.";
		}

		private void ConvertKilometersToMiles()
		{
			txtDescription.Text += "Converts kilometers to miles." + Environment.NewLine + Environment.NewLine +
										"\tDecimal result = CommonHelpers.ConvertKilometersToMiles(10);";

			Decimal result = CommonHelpers.ConvertKilometersToMiles(10);

			txtResults.Text += $"10 kilometers = {result} miles.";
		}

		private void ConvertLitersToGallons()
		{
			txtDescription.Text += "Converts liters to gallons." + Environment.NewLine + Environment.NewLine +
										"\tDecimal result = CommonHelpers.ConvertLitersToGallons(10);";

			Decimal result = CommonHelpers.ConvertLitersToGallons(10);

			txtResults.Text += $"10 liters = {result} gallons.";
		}

		private void ConvertMetersToFeet()
		{
			txtDescription.Text += "Converts meters to feet." + Environment.NewLine + Environment.NewLine +
										"\tDecimal result = CommonHelpers.ConvertMetersToFeet(10);";

			Decimal result = CommonHelpers.ConvertMetersToFeet(10);

			txtResults.Text += $"10 meters = {result} feet.";
		}

		private void ConvertMilesToKilometers()
		{
			txtDescription.Text += "Converts miles to kilometers." + Environment.NewLine + Environment.NewLine +
										"\tDecimal result = CommonHelpers.ConvertMilesToKilometers(10);";

			Decimal result = CommonHelpers.ConvertMilesToKilometers(10);

			txtResults.Text += $"10 miles = {result} kilometers.";
		}

		private void CurDir()
		{
			txtDescription.Text += "Property that gets or sets the current directory." + Environment.NewLine + Environment.NewLine +
								"\tString result = CommonHelpers.CurDir;" + Environment.NewLine +
								"\tCommonHelpers.CurDir = @\"C:\\;\";";

			String result1 = CommonHelpers.CurDir;
			CommonHelpers.CurDir = @"C:\";
			String result2 = CommonHelpers.CurDir;
			CommonHelpers.CurDir = result1;
			txtResults.Text += $"Current folder = {result1}." + Environment.NewLine;
			txtResults.Text += $"Changed current folder to {result2}.";

		}

		private void CurrentTimeZoneDaylightName()
		{
			txtDescription.Text += "Property that gets the current time zone name for daylight savings." + Environment.NewLine + Environment.NewLine +
								"\tString result1 = CommonHelpers.CurrentTimeZoneDaylightName;";

			String result = CommonHelpers.CurrentTimeZoneDaylightName;
			txtResults.Text += $"Current time zone daylight savings time name {result}.";
		}

		private void CurrentTimeZoneName()
		{
			txtDescription.Text += "Property that gets the current time zone name." + Environment.NewLine + Environment.NewLine +
								"\tString result = CommonHelpers.CurrentTimeZoneDaylightName;";

			String result = CommonHelpers.CurrentTimeZoneDaylightName;
			txtResults.Text += $"Current time zone name {result}.";
		}

		private void DegreesToRadians()
		{
			txtDescription.Text += "Converts degrees to radians," + Environment.NewLine + Environment.NewLine +
								   "\tDouble result = CommonHelpers.DegreesToRadians(90d);";

			Double result = CommonHelpers.DegreesToRadians(90d);

			txtResults.Text += $"90 degrees = {result} radians." + Environment.NewLine;
		}



		private void FahrenheitToCelsius()
		{
			txtDescription.Text += "Method converts degrees Farenheit to Celsius" + Environment.NewLine + Environment.NewLine +
									"\tDouble result = CommonHelpers.FahrenheitToCelsius(77);";

			Double result = CommonHelpers.FahrenheitToCelsius(77);

			txtResults.Text += $"77°F = {result}°C.";

		}

		private void FullComputerName()
		{
			txtDescription.Text += "Property to get the full computer name." + Environment.NewLine + Environment.NewLine +
									"\tString result = CommonHelpers.FullComputerName;";

			String result = CommonHelpers.FullComputerName;

			txtResults.Text += $"This computer's full name is {result}.";

		}

		private void GetComputerDomainName()
		{
			txtDescription.Text += "Function to get the computer's domain name." + Environment.NewLine + Environment.NewLine +
									"\tString result = CommonHelpers.GetComputerDomainName();";

			String result = CommonHelpers.GetComputerDomainName();

			txtResults.Text += $"This computer's domain name is {result}.";

		}

		private void GetCurrentCPUUsage()
		{
			txtDescription.Text += "Function to get the computer's current percent CPU usage." + Environment.NewLine + Environment.NewLine +
									"\tInt32 result = CommonHelpers.GetCurrentCPUUsage();";

			Int32 result = CommonHelpers.GetCurrentCPUUsage();

			txtResults.Text += $"CPU Usage = {result}%.";
		}

		private void GetDateTime()
		{
			txtDescription.Text += "Extension function to convert a string to a DateTime value, or return a user-specified default value." + Environment.NewLine + Environment.NewLine +
									"\tresult = time2Check.GetDateTime(DateTime.MinValue);" + Environment.NewLine +
									"\tif (result == DateTime.MinValue)" + Environment.NewLine +
									"\t{" + Environment.NewLine +
									"\t    txtResults.Text += $\"The string[{time2Check}] is a not valid datetime.\";" + Environment.NewLine +
									"\t}" + Environment.NewLine +
									"\telse" + Environment.NewLine +
									"\t{" + Environment.NewLine +
									"\t    txtResults.Text += $\"The string[{time2Check}] is a valid datetime that converts to {result}.\";" + Environment.NewLine +
									"\t}";

			String time2Check = "02/29/2004 13:03:14.234";
			DateTime result = time2Check.GetDateTime(DateTime.MinValue);

			txtResults.Text += $"The string [{time2Check}] is a valid datetime that converts to {result}." + Environment.NewLine;

			time2Check = "02/29/2005 13:03:14.234";
			result = time2Check.GetDateTime(DateTime.MinValue);

			if (result == DateTime.MinValue)
			{
				txtResults.Text += $"The string [{time2Check}] is a not valid datetime.";
			}
			else
			{
				txtResults.Text += $"The string [{time2Check}] is a valid datetime that converts to {result}.";
			}

		}

		private void GetDecimal()
		{
			txtDescription.Text += "String extension function to convert a string to a Decimal value, or return a user-specified default value." + Environment.NewLine + Environment.NewLine +
									"\tDecimal result = number.GetDecimal(0.0m);";

			String number = "3.14159";

			Decimal result = number.GetDecimal(0.0m);

			txtResults.Text += $"The string [3.14159] is a valid decimal that converts to {result}." + Environment.NewLine;

			number = "1x";

			result = number.GetDecimal(0.0m);

			if (result == 0.0m)
			{
				txtResults.Text += "The string [1x] is a not valid decimal.";
			}
			else
			{
				txtResults.Text += $"The string [1x] is a valid decimal that converts to {result}.";
			}
		}

		private void GetDefaultValue()
		{
			txtDescription.Text += "Extension function to get the default value of a type." + Environment.NewLine + Environment.NewLine +
									"\tObject result = dec.GetDefaultValue();" + Environment.NewLine +
									"\tObject result = dtm.GetDefaultValue();" + Environment.NewLine +
									"\tObject result = bmp.GetDefaultValue();";

			Type dec = typeof(Decimal);
			dec.GetDefaultValue();
			Object result = dec.GetDefaultValue();
			txtResults.Text += $"The default value for a decimal is {result ?? "NULL"}." + Environment.NewLine;

			Type dtm = typeof(DateTime);
			result = dtm.GetDefaultValue();
			txtResults.Text += $"The default value for a DateTime is {result ?? "NULL"}." + Environment.NewLine;

			Type bmp = typeof(System.Drawing.Bitmap);
			result = bmp.GetDefaultValue();
			txtResults.Text += $"The default value for System.Drawing.Bitmap is {result ?? "NULL"}.";

		}

		private void GetDNSName()
		{
			txtDescription.Text += "Function to get the DNS name of a machine." + Environment.NewLine + Environment.NewLine +
							"\tString result = CommonHelpers.GetDNSName(Environment.MachineName);" + Environment.NewLine +
							"\tString result = CommonHelpers.GetDNSName(\"www.microsoft.com\");" + Environment.NewLine +
							"\tString result = CommonHelpers.GetDNSName(\"255.255.255.100\");" + Environment.NewLine +
							"\tString result = CommonHelpers.GetDNSName(\"13.249.120.102\");";

			String result = CommonHelpers.GetDNSName(Environment.MachineName);
			txtResults.Text += $"The DNS name for {Environment.MachineName} is {result}." + Environment.NewLine;
			result = CommonHelpers.GetDNSName("www.microsoft.com");
			txtResults.Text += $"The DNS name for www.microsoft.com is {result}." + Environment.NewLine;
			result = CommonHelpers.GetDNSName("255.255.255.100");
			txtResults.Text += $"The DNS name for 255.255.255.100 is {result}." + Environment.NewLine;
			result = CommonHelpers.GetDNSName("13.249.120.102");
			txtResults.Text += $"The DNS name for 13.249.120.102 is {result}.";
		}

		private void GetDrives()
		{
			txtDescription.Text += "Function to get the drive info of a machine." + Environment.NewLine + Environment.NewLine +
								   "\tList<System.IO.DriveInfo> result = CommonHelpers.GetDrives();";

			List<System.IO.DriveInfo> result = CommonHelpers.GetDrives();

			if (result.Count == 0)
			{
				txtResults.Text += "No drives were found.";
			}
			else
			{
				foreach (DriveInfo drive in result)
				{
					if (drive.IsReady)
					{
						txtResults.Text += $"Drive [{drive.Name}], root directory [{drive.RootDirectory.Name}], Volume Label [{drive.VolumeLabel}], Total size: [{drive.TotalSize / 1073741824} GB]." + Environment.NewLine;
					}
					else
					{
						txtResults.Text += $"Drive {drive.Name} (drive not ready)" + Environment.NewLine;
					}
				}
			}

		}

		private void GetExceptionInfo()
		{
			txtDescription.Text += "Function to get information from an Exception instance." + Environment.NewLine + Environment.NewLine +
									"\tBoolean result = CommonHelpers.GetExceptionInfo(exUnhandled, out logMessage, out exceptionData, out stackTraceDescrs, out previousModule, out previousMethod, out previousLineNumber, out threadID);";

			try
			{
				MakeException();
			}
			catch (Exception exUnhandled)
			{
				String logMessage = "";
				String exceptionData = "";
				String stackTraceDescrs = "";
				String previousModule = "";
				String previousMethod = "";
				Int32 previousLineNumber = 0;
				Int32 threadID = 0;

				Boolean result = CommonHelpers.GetExceptionInfo(exUnhandled, out logMessage, out exceptionData, out stackTraceDescrs, out previousModule, out previousMethod, out previousLineNumber, out threadID);
				txtResults.Text += $"  Log Message = {logMessage}" + Environment.NewLine;
				txtResults.Text += $"  Data Collection = {exceptionData}" + Environment.NewLine;
				txtResults.Text += $"  Stack Trace = {stackTraceDescrs}" + Environment.NewLine;
				txtResults.Text += $"  Module = {previousModule}" + Environment.NewLine;
				txtResults.Text += $"  Method = {previousMethod}" + Environment.NewLine;
				txtResults.Text += $"  Line number = {previousLineNumber}" + Environment.NewLine;
				txtResults.Text += $"  Thread ID = {threadID}" + Environment.NewLine;

			}

		}

		private void MakeException()
		{
			MultiObject obj = new MultiObject();

			obj.Clear();

			ArgumentException exInner = new ArgumentException("Argument was invalid.");
			exInner.Data.Add("Param1", DateTime.Now);
			exInner.Data.Add("Param2", Environment.UserName);
			exInner.Data.AddCheck("Param1", obj?.NamedList?.Keys);
			InvalidCastException exMiddle = new InvalidCastException("[X2] cannot be cast as Int32.", exInner);
			exMiddle.Data.Add("X2", "abc01");
			NotImplementedException exOuter = new NotImplementedException("MethodA is not implemented.", exMiddle);
			exOuter.Data.Add("MethodName", "MethodA");

			throw exOuter;

		}

		private void GetFullComputerDomainName()
		{
			txtDescription.Text += "Function to get the computer's full domain name." + Environment.NewLine + Environment.NewLine +
							"\tString result = CommonHelpers.GetFullComputerDomainName();";

			String result = CommonHelpers.GetFullComputerDomainName();

			txtResults.Text += $"Full computer domain name = {result}.";

		}

		private void GetFullDateTimeStampForFileName()
		{
			txtDescription.Text += "Function to get a date-time stamp suitable for use in a file name." + Environment.NewLine + Environment.NewLine +
							"\tString result = CommonHelpers.GetFullDateTimeStampForFileName(DateTime.Now)";

			String result = CommonHelpers.GetFullDateTimeStampForFileName(DateTime.Now);

			txtResults.Text += $"Date-time stamp = {result}.";
		}

		private void GetFullExceptionMessage()
		{
			txtDescription.Text += "Function to get exception message(s) from an Exception instance, with options for the data collection and stack trace." + Environment.NewLine + Environment.NewLine +
							"\tString result = exUnhandled.GetFullExceptionMessage(true, true);" + Environment.NewLine +
							"\tString result = exUnhandled.GetFullExceptionMessage(true, false);" + Environment.NewLine +
							"\tString result = exUnhandled.GetFullExceptionMessage(false, true);" + Environment.NewLine +
							"\tString result = exUnhandled.GetFullExceptionMessage(false, false);";

			try
			{
				MakeException();
			}
			catch (Exception exUnhandled)
			{

				String result = exUnhandled.GetFullExceptionMessage(true, true);
				txtResults.Text += $"Exception Message with data collection and stack trace:{Environment.NewLine}{result}{Environment.NewLine}" + Environment.NewLine;

				result = exUnhandled.GetFullExceptionMessage(true, false);
				txtResults.Text += $"Exception Message with data collection and no stack trace:{Environment.NewLine}{result}{Environment.NewLine}" + Environment.NewLine;

				result = exUnhandled.GetFullExceptionMessage(false, true);
				txtResults.Text += $"Exception Message with no data collection and with stack trace:{Environment.NewLine}{result}{Environment.NewLine}" + Environment.NewLine;

				result = exUnhandled.GetFullExceptionMessage(false, false);
				txtResults.Text += $"Exception Message with no data collection and no stack trace:{Environment.NewLine}{result}{Environment.NewLine}" + Environment.NewLine;

			}
		}

		private void GetInt32()
		{
			txtDescription.Text += "String extension to convert a string to a Int32 value, or return a user-specified default value." + Environment.NewLine + Environment.NewLine +
									"\tInt32 result = num.GetInt32(Int32.MinValue);";

			String num = "23";

			Int32 result = num.GetInt32(Int32.MinValue);

			txtResults.Text += $"The string [23] is a valid 32 bit integer that converts to {result}." + Environment.NewLine;

			num = "1x";
			result = num.GetInt32(Int32.MinValue);

			if (result == Int32.MinValue)
			{
				txtResults.Text += $"The string [{num}] is a not valid 32 bit integer.";
			}
			else
			{
				txtResults.Text += $"The string [{num}] is a valid 32 bit integer that converts to {result}.";
			}
		}

		private void GetInt64()
		{
			txtDescription.Text += "String extension to convert a string to a Int64 value, or return a user-specified default value." + Environment.NewLine + Environment.NewLine +
									"\tInt64 result = num.GetInt64(Int64.MinValue);";

			String num = "23456";

			Int64 result = num.GetInt64(Int64.MinValue);

			txtResults.Text += $"The string [23456] is a valid 64 bit integer that converts to {result}." + Environment.NewLine;

			num = "1x";
			result = num.GetInt64(Int64.MinValue);

			if (result == Int64.MinValue)
			{
				txtResults.Text += $"The string [{num}] is a not valid 64 bit integer.";
			}
			else
			{
				txtResults.Text += $"The string [{num}] is a valid 64 bit integer that converts to {result}.";
			}
		}

		private void GetIntBitValue()
		{
			txtDescription.Text += "Function to get the bit value of an Int32 used as a bitmask." + Environment.NewLine + Environment.NewLine +
									"\tBoolean result = CommonHelpers.GetIntBitValue(bitmask, 1);";

			Int32 bitmask = 3;

			Boolean result = CommonHelpers.GetIntBitValue(bitmask, 1);
			txtResults.Text += $"The number [{bitmask}] bit 1 is {result}." + Environment.NewLine;
			result = CommonHelpers.GetIntBitValue(bitmask, 2);
			txtResults.Text += $"The number [{bitmask}] bit 2 is {result}." + Environment.NewLine;
			result = CommonHelpers.GetIntBitValue(bitmask, 3);
			txtResults.Text += $"The number [{bitmask}] bit 3 is {result}." + Environment.NewLine;
			result = CommonHelpers.GetIntBitValue(bitmask, 4);
			txtResults.Text += $"The number [{bitmask}] bit 4 is {result}.";

		}

		private void GetLinearDistance()
		{

			txtDescription.Text += "Function to get the distance between two geospatial coordinates (latitude, longitude, and altitude)." + Environment.NewLine + Environment.NewLine +
									"\tDouble result = CommonHelpers.GetLinearDistance(lat1, long1, lat2, long2, DistanceUnitsOfMeasureEnum.Miles);" + Environment.NewLine +
									"\tDouble result = CommonHelpers.GetLinearDistance(lat1, long1, lat2, long2, DistanceUnitsOfMeasureEnum.Kilometers);";

			Double lat1 = 34.078717;
			Double long1 = -84.2796787;
			Double alt1 = (Double)CommonHelpers.ConvertMetersToFeet(1314);
			Double lat2 = 30.8705832;
			Double long2 = -84.2130001;
			Double alt2 = (Double)CommonHelpers.ConvertMetersToFeet(350);

			Double result = CommonHelpers.GetLinearDistance(lat1, long1, alt1, lat2, long2, alt2, DistanceUnitsOfMeasureEnum.Miles);

			txtResults.Text += $"The distance between {lat1}, {long1}, {alt1} ft and {lat2}, {long2}, {alt2} ft is [{result}] miles." + Environment.NewLine;

			alt1 = 1314;
			alt2 = 350;
			result = CommonHelpers.GetLinearDistance(lat1, long1, alt1, lat2, long2, alt2, DistanceUnitsOfMeasureEnum.Kilometers);

			txtResults.Text += $"The distance between {lat1}, {long1}, {alt1} m and {lat2}, {long2}, {alt2} m is [{result}] kilometers.";

		}

		private void GetLinearDistances()
		{
			txtDescription.Text += "Function to get the distances between two geospatial coordinates (latitude, longitude, and altitude) each in a collection of geospatial coordinates." + Environment.NewLine + Environment.NewLine +
									"\tList<AddressGeoData> geoData = new List<AddressGeoData>()" + Environment.NewLine +
									"\t{" + Environment.NewLine +
									"\t	  new AddressGeoData(lat1, long1, alt1, lat2, long2, alt2, DistanceUnitsOfMeasureEnum.Miles)," + Environment.NewLine +
									"\t	  new AddressGeoData(lat3, long3, alt3, lat2, long2, alt2, DistanceUnitsOfMeasureEnum.Miles)" + Environment.NewLine +
									"\t}" + Environment.NewLine +
									"\tCommonHelpers.GetLinearDistances(ref geoData);" + Environment.NewLine +
									"\t" + Environment.NewLine +
									"\tList<AddressGeoData> geoData = new List<AddressGeoData>()" + Environment.NewLine +
									"\t{" + Environment.NewLine +
									"\t	  new AddressGeoData(lat1, long1, alt1, lat2, long2, alt2, DistanceUnitsOfMeasureEnum.Kilometers)," + Environment.NewLine +
									"\t	  new AddressGeoData(lat3, long3, alt3, lat2, long2, alt2, DistanceUnitsOfMeasureEnum.Kilometers)" + Environment.NewLine +
									"\t}" + Environment.NewLine +
									"\tCommonHelpers.GetLinearDistances(ref geoData);";

			Double lat1 = 34.078717;
			Double long1 = -84.2796787;
			Double alt1 = (Double)CommonHelpers.ConvertMetersToFeet(1314);
			Double lat2 = 30.8705832;
			Double long2 = -84.2130001;
			Double alt2 = (Double)CommonHelpers.ConvertMetersToFeet(350);
			Double lat3 = 33.5867639;
			Double long3 = -86.2874068;
			Double alt3 = (Double)CommonHelpers.ConvertMetersToFeet(1322);

			List<AddressGeoData> geoData = new List<AddressGeoData>()
			{
				new AddressGeoData(lat1, long1, alt1, lat2, long2, alt2, DistanceUnitsOfMeasureEnum.Miles),
				new AddressGeoData(lat3, long3, alt3, lat2, long2, alt2, DistanceUnitsOfMeasureEnum.Miles)
			};


			CommonHelpers.GetLinearDistances(ref geoData);

			foreach (AddressGeoData geo in geoData)
			{
				txtResults.Text += $"The distance between {geo.Latitude1}, {geo.Longitude1}, {geo.Altitude1} ft and {geo.Latitude2}, {geo.Longitude2}, {geo.Altitude2} ft is [{geo.LinearDistance}] miles." + Environment.NewLine;
			}

			geoData.Clear();
			geoData = null;

			alt1 = 1314;
			alt2 = 350;
			alt3 = 1322;

			geoData = new List<AddressGeoData>()
			{
				new AddressGeoData(lat1, long1, alt1, lat2, long2, alt2, DistanceUnitsOfMeasureEnum.Kilometers),
				new AddressGeoData(lat3, long3, alt3, lat2, long2, alt2, DistanceUnitsOfMeasureEnum.Kilometers)
			};

			CommonHelpers.GetLinearDistances(ref geoData);

			txtResults.Text += Environment.NewLine;

			foreach (AddressGeoData geo in geoData)
			{
				txtResults.Text += $"The distance between {geo.Latitude1}, {geo.Longitude1}, {geo.Altitude1} m and {geo.Latitude2}, {geo.Longitude2}, {geo.Altitude2} m is [{geo.LinearDistance}] kilometers." + Environment.NewLine;
			}


		}

		private void GetMinPasswordLength()
		{
			txtDescription.Text += "Function to get the minimum password length for the domain.  It returns -1 if not in a domain." + Environment.NewLine + Environment.NewLine +
									"\tInt32 result = CommonHelpers.GetMinPasswordLength();";

			Int32 result = CommonHelpers.GetMinPasswordLength();

			if (result == -1)
			{
				txtResults.Text += "This computer is not in a domain, so there is no minimum password length defined by a domain.";
			}
			else
			{
				txtResults.Text += $"The minimum domain password length is {result} characters.";
			}


		}

		private void GetNetworkPrinters()
		{
			txtDescription.Text += "Function to get a list of network printers." + Environment.NewLine + Environment.NewLine +
									"\tList<System.Management.ManagementObject> result = CommonHelpers.GetNetworkPrinters();" + Environment.NewLine +
									m_TEST_STRING;

			List<System.Management.ManagementObject> result = CommonHelpers.GetNetworkPrinters();

			if (result == null)
			{
				txtResults.Text += "No network printers were found.";
			}
			else
			{
				if (result.Count == 0)
				{
					txtResults.Text += "No network printers were found.";
				}
				else
				{
					foreach (System.Management.ManagementObject printer in result)
					{
						String printerName = printer.Properties["Name"].Value.ToString();
						String printerStatus = printer.Properties["Status"].Value.ToString();
						String printerDefault = printer.Properties["Default"].Value.ToString();

						txtResults.Text += $"{printerName} status: [{printerStatus}]  Default? [{printerDefault}]" + Environment.NewLine;
					}
				}
			}

		}

		private void GetLocalPrinters()
		{
			txtDescription.Text += "Function to get a list of network printers." + Environment.NewLine + Environment.NewLine +
									"\tList<System.Management.ManagementObject> result = CommonHelpers.GetNetworkPrinters();" + Environment.NewLine +
									m_TEST_STRING;


			List<System.Management.ManagementObject> result = CommonHelpers.GetLocalPrinters();

			if (result == null)
			{
				txtResults.Text += "No local printers were found.";
			}
			else
			{
				if (result.Count == 0)
				{
					txtResults.Text += "No local printers were found.";
				}
				else
				{
					foreach (System.Management.ManagementObject localPrinter in result)
					{
						String printerName = localPrinter.Properties["Name"].Value.ToString();
						String printerStatus = localPrinter.Properties["Status"].Value.ToString();
						String printerDefault = localPrinter.Properties["Default"].Value.ToString();

						txtResults.Text += $"{printerName} status: [{printerStatus}]  Default? [{printerDefault}]" + Environment.NewLine;
					}
				}
			}

		}

		private void GetOnlyDigits()
		{

			txtDescription.Text += "String extension function to get numbers from a string, with the option to include periods (such as when the number is a decimal value)." + Environment.NewLine + Environment.NewLine +
								   "\tString value2Check = \"Akery3mn.5n7X9.9c0\";" + Environment.NewLine +
								   "\tString result = value2Check.GetOnlyDigits(false);" + Environment.NewLine +
								   "\tString value2Check = \"USD $2,332.45\";" + Environment.NewLine +
								   "\tString result = value2Check.GetOnlyDigits(true);";

			String value2Check = "Akery3mn.5n7X9.9c0";

			String result = value2Check.GetOnlyDigits(false);

			txtResults.Text += $"The digits from [{value2Check}] are [{result}], without periods." + Environment.NewLine;

			value2Check = "USD $2,332.45";

			result = value2Check.GetOnlyDigits(true);

			txtResults.Text += $"The digits from [{value2Check}] are [{result}], with the period since it is a decimal number.";
		}

		private void GetOnlyLetters()
		{
			txtDescription.Text += "String extension function to get numbers from a string, with the option to include spaces (such as when pulling a name)." + Environment.NewLine + Environment.NewLine +
								   "\tString value2Check = \"Akery 3mn.5n7X9.9c0\";" + Environment.NewLine +
								   "\tString result = value2Check.GetOnlyLetters(false);" + Environment.NewLine +
								   "\tString value2Check = \"John Smith 999-99-9999\";" + Environment.NewLine +
								   "\tString result = value2Check.GetOnlyLetters(true).Trim();";

			String value2Check = "Akery 3mn.5n7X9.9c0";

			String result = value2Check.GetOnlyLetters(false);

			txtResults.Text += $"The letters from [{value2Check}] are [{result}], without spaces" + Environment.NewLine;

			value2Check = "John Smith 999-99-9999";

			result = value2Check.GetOnlyLetters(true).Trim();

			txtResults.Text += $"The letters from [{value2Check}] are [{result}], with the internal spaces.";
		}

		private void GetOnlyLettersAndDigits()
		{
			txtDescription.Text += "String extension function to get numbers and letters from a string, with the option to include periods and spaces." + Environment.NewLine + Environment.NewLine +
								   "\tString value2Check = \"##### ... WARNING ... 123 ... #######\";" + Environment.NewLine +
								   "\tString result = value2Check.GetOnlyLetters(false);" + Environment.NewLine +
								   "\tString value2Check = \"!@#$%^&*()+{}[]John Smith USD211.78\";" + Environment.NewLine +
								   "\tString result = value2Check.GetOnlyLetters(true).Trim();";

			String value2Check = "##### ... WARNING ... 123 ... #######";

			String result = value2Check.GetOnlyLettersAndDigits(false);

			txtResults.Text += $"The letters and digits from [{value2Check}] are [{result}], without spaces or periods" + Environment.NewLine;

			value2Check = "!@#$%^&*()+{}[]John Smith USD211.78";

			result = value2Check.GetOnlyLettersAndDigits(true).Trim();

			txtResults.Text += $"The letters and digits from [{value2Check}] are [{result}], with the internal spaces and periods.";

		}

		private void GetStackInfo()
		{
			txtDescription.Text += "Function to get the current stack info, or the stack info from an exception." + Environment.NewLine + Environment.NewLine +
								   "\tString result = CommonHelpers.GetStackInfo();" + Environment.NewLine +
								   "\tString result = CommonHelpers.GetStackInfo(ex);";

			String result = CommonHelpers.GetStackInfo();

			txtResults.Text += $"The stack info from the current state is:{Environment.NewLine} {result}{Environment.NewLine}" + Environment.NewLine;

			try
			{
				ArgumentException ex = new ArgumentException("Parameter 1 (name) was null.  It must be a string with length > 1.");

				throw ex;
			}
			catch (Exception exUnhandled)
			{
				result = CommonHelpers.GetStackInfo(exUnhandled);

				txtResults.Text += $"The stack info from the exception is:{Environment.NewLine} {result}{Environment.NewLine}" + Environment.NewLine;
			}

		}

		private void GetTotalHDDFreeSpace()
		{
			txtDescription.Text += "Method returns MB of free disk space." + Environment.NewLine + Environment.NewLine +
								   "\tInt32 result = CommonHelpers.GetTotalHDDFreeSpace(\"C\");";

			Int32 result = CommonHelpers.GetTotalHDDFreeSpace("C");

			txtResults.Text += $"Free disk space for C: is {result} MB.";

		}

		private void GetTotalHDDSize()
		{
			txtDescription.Text += "Method returns the total disk size in MB" + Environment.NewLine + Environment.NewLine +
								   "\tInt32 result = CommonHelpers.GetTotalHDDSize(\"C\");";

			Int32 result = CommonHelpers.GetTotalHDDSize("C");

			txtResults.Text += $"Total disk space for C: is {result} MB.";
		}

		private void Hex()
		{
			txtDescription.Text += "Returns the hex value of an integer." + Environment.NewLine + Environment.NewLine +
								   "\tString result = CommonHelpers.Hex(320);";

			String result = CommonHelpers.Hex(320);

			txtResults.Text += $"The hex value of decimal 320 is {result}" + Environment.NewLine;
		}

		private void IsBoolean()
		{
			txtDescription.Text += "String extension method that tells if a string value can be converted to a boolean value using the ConvertToBoolean() extension method." + Environment.NewLine +
									"Recognizes as true (case insensitive) true, on, yes, up, ok, good, 1, -1" + Environment.NewLine +
									"Recognizes as false (case insensitive): false, off, no, down, not ok, bad, 0" + Environment.NewLine + Environment.NewLine +
									"\tBoolean result1 = origString.IsBoolean();";


			String origString = "trUe";
			Boolean isBoolean = false;
			Boolean result1 = origString.IsBoolean();
			txtResults.Text += $"Is [{origString}] Boolean? {result1}].{Environment.NewLine}";

			origString = "oN";
			isBoolean = false;
			result1 = origString.IsBoolean();
			txtResults.Text += $"Is [{origString}] Boolean? {result1}].{Environment.NewLine}";

			origString = "yEs";
			isBoolean = false;
			result1 = origString.IsBoolean();
			txtResults.Text += $"Is [{origString}] Boolean? {result1}].{Environment.NewLine}";

			origString = "uP";
			isBoolean = false;
			result1 = origString.IsBoolean();
			txtResults.Text += $"Is [{origString}] Boolean? {result1}].{Environment.NewLine}";

			origString = "oK";
			isBoolean = false;
			result1 = origString.IsBoolean();
			txtResults.Text += $"Is [{origString}] Boolean? {result1}].{Environment.NewLine}";

			origString = "gOOd";
			isBoolean = false;
			result1 = origString.IsBoolean();
			txtResults.Text += $"Is [{origString}] Boolean? {result1}].{Environment.NewLine}";

			origString = "1";
			isBoolean = false;
			result1 = origString.IsBoolean();
			txtResults.Text += $"Is [{origString}] Boolean? {result1}].{Environment.NewLine}";

			origString = "-1";
			isBoolean = false;
			result1 = origString.IsBoolean();
			txtResults.Text += $"Is [{origString}] Boolean? {result1}].{Environment.NewLine}";

			origString = "Booger";
			isBoolean = false;
			result1 = origString.IsBoolean();
			txtResults.Text += $"Is [{origString}] Boolean? {isBoolean}.{Environment.NewLine}";

			// Recognizes as false (case insensitive): false, off, no, down, not ok, bad, 0
			origString = "fAlSe";
			isBoolean = false;
			result1 = origString.IsBoolean();
			txtResults.Text += $"Is [{origString}] Boolean? {result1}].{Environment.NewLine}";

			origString = "oFF";
			isBoolean = false;
			result1 = origString.IsBoolean();
			txtResults.Text += $"Is [{origString}] Boolean? {result1}].{Environment.NewLine}";

			origString = "nO";
			isBoolean = false;
			result1 = origString.IsBoolean();
			txtResults.Text += $"Is [{origString}] Boolean? {result1}].{Environment.NewLine}";

			origString = "dOWn";
			isBoolean = false;
			result1 = origString.IsBoolean();
			txtResults.Text += $"Is [{origString}] Boolean? {result1}].{Environment.NewLine}";

			origString = "nOt Ok";
			isBoolean = false;
			result1 = origString.IsBoolean();
			txtResults.Text += $"Is [{origString}] Boolean? {result1}].{Environment.NewLine}";

			origString = "BaD";
			isBoolean = false;
			result1 = origString.IsBoolean();
			txtResults.Text += $"Is [{origString}] Boolean? {result1}].{Environment.NewLine}";

			origString = "0";
			isBoolean = false;
			result1 = origString.IsBoolean();
			txtResults.Text += $"Is [{origString}] Boolean? {result1}].{Environment.NewLine}";
		}

		private void IsDaylightSavingsTime()
		{
			txtDescription.Text += "Checks to see if the current date-time is daylight savings time (DST) or not." + Environment.NewLine + Environment.NewLine +
								   "\tBoolean result = CommonHelpers.IsDaylightSavingsTime();" + Environment.NewLine +
								   "\tBoolean result = CommonHelpers.IsDaylightSavingsTime(date2Check);";

			Boolean result = CommonHelpers.IsDaylightSavingsTime();

			txtResults.Text += $"Currently daylight saving time (DST)? {result}" + Environment.NewLine;

			DateTime date2Check = "12/25/2020".GetDateTime(DateTime.MinValue);

			result = CommonHelpers.IsDaylightSavingsTime(date2Check);

			txtResults.Text += $"Is [12/25/2020] in daylight savngs time (DST)? {result}" + Environment.NewLine;
		}

		private void IsEmailFormat()
		{
			txtDescription.Text += "String extenstion method that returns true or false if the string is a properly formatted email address." + Environment.NewLine + Environment.NewLine +
								   "\tBoolean result = test1.IsEmailFormat();";

			String test1 = "John.Doe@domain";

			Boolean result = test1.IsEmailFormat();

			txtResults.Text += $"Is {test1} a correctly formatted email address? {result}" + Environment.NewLine;

			test1 = "John.Doe@domain.net";

			result = test1.IsEmailFormat();

			txtResults.Text += $"Is {test1} a correctly formatted email address? {result}";

			test1 = "Mary Smith@domain.net";

			result = test1.IsEmailFormat();

			txtResults.Text += $"Is {test1} a correctly formatted email address? {result}";
		}

		private void IsFileText()
		{
			try
			{
				txtDescription.Text += "Method to detect the encoding and whether a file is text or not." + Environment.NewLine + Environment.NewLine +
									   "\tBoolean result = CommonHelpers.IsFileText(out encodingType, @\"C:\\TestFile.txt\", 80);" + Environment.NewLine +
									   "\tBoolean result = CommonHelpers.IsFileText(out encodingType, @\"C:\\Windows\\regedit.exe\", 80);";

				Encoding encodingType = Encoding.Default;

				String contents = m_TEST_STRING;

				File.WriteAllText(@"C:\TestFile.txt", contents, Encoding.UTF8);

				Boolean result = CommonHelpers.IsFileText(out encodingType, @"C:\TestFile.txt", 80);

				txtResults.Text += $"The file [C:\\TestFile.txt] has the encoding type [{encodingType}].  Is it text? {result}" + Environment.NewLine;

				File.Delete(@"C:\TestFile.txt");

				if (File.Exists(@"C:\Windows\regedit.exe"))
				{
					result = CommonHelpers.IsFileText(out encodingType, @"C:\Windows\regedit.exe", 80);

					txtResults.Text += $"The file [C:\\Windows\\regedit.exe] has the encoding type [{encodingType}].  Is it text? {result}" + Environment.NewLine;
				}
			}
			catch (Exception exUnhandled)
			{
				MessageBox.Show(this, "This example requires \"Run as Administrator\" to access the C: drive for write access." + Environment.NewLine +
									  $"Error Message: {exUnhandled.Message}");
			}
		}

		private void IsInDomain()
		{
			txtDescription.Text += "Checks to see if the computer is in a domain.  True if it is, false if not." + Environment.NewLine + Environment.NewLine +
								   "\tBoolean result = CommonHelpers.IsInDomain();";

			Boolean result = CommonHelpers.IsInDomain();

			txtResults.Text += $"Is this computer in a domain? {result}";
		}

		private void IsIPAddress()
		{
			txtDescription.Text += "Checks if a string is a properly formmated IPv4 or IPv6 address, and converts it to an IPAddress object if valid." + Environment.NewLine + Environment.NewLine +
								   "\tBoolean result = CommonHelpers.IsIPAddress(ipAddr4, out ipAddra4IP);" + Environment.NewLine +
								   "\tBoolean result = CommonHelpers.IsIPAddress(ipAddr6, out ipAddra6IP);";

			String ipAddr4 = "23.55.228.170";
			IPAddress ipAddr4IP = null;

			String ipAddr6 = "2600:140b:12:4ba::356e";  // "2001:218:2000:5000::2a6";  // "fe80::35c7:d167:876d:c6e%13";
			IPAddress ipAddr6IP = null;

			Boolean result = CommonHelpers.IsIPAddress(ipAddr4, out ipAddr4IP);
			txtResults.Text += $"Is \"{ipAddr4}\" an IPv4 address? {result}" + Environment.NewLine;

			if (ipAddr4IP != null)
			{
				txtResults.Text += $"\"{ipAddr4}\" resolved as {ipAddr4IP.ToString()}, address family {ipAddr4IP.AddressFamily.ToString()}" + Environment.NewLine + Environment.NewLine;
			}

			result = CommonHelpers.IsIPAddress(ipAddr6, out ipAddr6IP);

			txtResults.Text += $"Is \"{ipAddr6}\" an IPv6 address? {result}" + Environment.NewLine;

			if (ipAddr6IP != null)
			{
				txtResults.Text += $"\"{ipAddr6}\" resolved as {ipAddr6IP.ToString()}, address family {ipAddr6IP.AddressFamily.ToString()}" + Environment.NewLine + Environment.NewLine;
			}

			ipAddr4 = "390.400.987.0";
			result = CommonHelpers.IsIPAddress(ipAddr4, out ipAddr4IP);
			txtResults.Text += $"Is \"{ipAddr4}\" an IPv4 address? {result}" + Environment.NewLine;

			if (ipAddr4IP != null)
			{
				txtResults.Text += $"\"{ipAddr4}\" resolved as {ipAddr4IP.ToString()}, address family {ipAddr4IP.AddressFamily.ToString()}" + Environment.NewLine + Environment.NewLine;
			}

			ipAddr6 = "abc:def";
			result = CommonHelpers.IsIPAddress(ipAddr6, out ipAddr6IP);

			txtResults.Text += $"Is \"{ipAddr6}\" an IPv6 address? {result}" + Environment.NewLine;

			if (ipAddr6IP != null)
			{
				txtResults.Text += $"\"{ipAddr6}\" resolved as {ipAddr6IP.ToString()}, address family {ipAddr6IP.AddressFamily.ToString()}" + Environment.NewLine;
			}
		}

		private void IsOnlyDigits()
		{
			txtDescription.Text += "String extension method that checks if only digits are in the string. Periods may be counted as part of a number." + Environment.NewLine + Environment.NewLine +
								   "\tBoolean result = string2Check.IsOnlyDigits(false);" + Environment.NewLine +
								   "\tBoolean result = string2Check.IsOnlyDigits(true);";

			String string2Check = "Nine.";
			Boolean result = string2Check.IsOnlyDigits(false);
			txtResults.Text += $"Does [{string2Check}] only contain digits? {result}." + Environment.NewLine;

			string2Check = "999.0";
			result = string2Check.IsOnlyDigits(false);
			txtResults.Text += $"Does [{string2Check}] only contain digits? {result}." + Environment.NewLine;

			string2Check = "999.0";
			result = string2Check.IsOnlyDigits(true);
			txtResults.Text += $"Does [{string2Check}] only contain digits (period allowed as part of digits)? {result}." + Environment.NewLine;

		}

		private void IsOnlyLetters()
		{
			txtDescription.Text += "String extension method that checks if only letters are in the string. Spaces may be counted as part of a word or phrase." + Environment.NewLine + Environment.NewLine +
								   "\tBoolean result = string2Check.IsOnlyLetters(false);" + Environment.NewLine +
								   "\tBoolean result = string2Check.IsOnlyLetters(true);";

			String string2Check = "Nine hundred forty two";
			Boolean result = string2Check.IsOnlyLetters(false);
			txtResults.Text += $"Does [{string2Check}] only contain letters, no spaces? {result}." + Environment.NewLine;

			string2Check = "999.0";
			result = string2Check.IsOnlyLetters(false);
			txtResults.Text += $"Does [{string2Check}] only contain letters, no spaces? {result}." + Environment.NewLine;

			string2Check = "Nine hunred forty two";
			result = string2Check.IsOnlyLetters(true);
			txtResults.Text += $"Does [{string2Check}] only contain letters and spaces? {result}." + Environment.NewLine;
		}

		private void IsOnlyLettersAndOrDigits()
		{
			txtDescription.Text += "String extension method that checks if only letters or digits are in the string. Spaces and periods may be counted as part of a number, word, or phrase." + Environment.NewLine + Environment.NewLine +
								   "\tBoolean result = string2Check.IsOnlyLettersAndOrDigits(false);" + Environment.NewLine +
								   "\tBoolean result = string2Check.IsOnlyLettersAndOrDigits(true);";

			String string2Check = "Nine hundred forty two 942.00";
			Boolean result = string2Check.IsOnlyLettersAndOrDigits(false);
			txtResults.Text += $"Does [{string2Check}] only contain letters, digits, no spaces or periods? {result}." + Environment.NewLine;

			string2Check = "999.0";
			result = string2Check.IsOnlyLettersAndOrDigits(false);
			txtResults.Text += $"Does [{string2Check}] only contain letters, digits, no spaces or periods? {result}." + Environment.NewLine;

			string2Check = "999.0";
			result = string2Check.IsOnlyLettersAndOrDigits(true);
			txtResults.Text += $"Does [{string2Check}] only contain letters, digits, spaces, and periods? {result}." + Environment.NewLine;

			string2Check = "Nine hundred forty two 942.00";
			result = string2Check.IsOnlyLettersAndOrDigits(true);
			txtResults.Text += $"Does [{string2Check}] only contain letters, digits, spaces, and periods? {result}." + Environment.NewLine;
		}

		private void Ping()
		{
			txtDescription.Text += "Simple synchronous ping that returns results." + Environment.NewLine + Environment.NewLine +
								   "\tPingReply result = CommonHelpers.Ping(\"www.microsoft.com\", 1000);" + Environment.NewLine +
								   "\tPingReply result = CommonHelpers.Ping(\"23.55.228.170\", 1000);";

			PingReply result = CommonHelpers.Ping("www.microsoft.com", 1000);

			txtResults.Text += $"Ping of \"www.microsoft.com\"  results: Status-{result.Status.ToString()}  Roundtrip Time- {result.RoundtripTime}ms" + Environment.NewLine;

			result = CommonHelpers.Ping("23.55.228.170", 1000);

			txtResults.Text += $"Ping of \"23.55.228.170\"  results: Status-{result.Status.ToString()}  Roundtrip Time- {result.RoundtripTime}ms" + Environment.NewLine;

		}

		private void RadianToDegree()
		{
			txtDescription.Text += "Converts radians to degrees," + Environment.NewLine + Environment.NewLine +
								   "\tDouble result = CommonHelpers.RadianToDegree(1.5d);";

			Double result = CommonHelpers.RadianToDegree(1.5d);

			txtResults.Text += $"1.5 radians = {result} degrees." + Environment.NewLine;
		}

		private void RowDelimiter()
		{
			txtDescription.Text += "Returns a common, nonprintable ASCII row delimiter." + Environment.NewLine + Environment.NewLine +
									"\tString result = CommonHelpers.ColumnDelimiter;";

			String result = CommonHelpers.RowDelimiter;
			Int32 delimValue = CommonHelpers.Asc(result);

			txtResults.Text += $"Row delimiter ASCII value = {delimValue}";
		}

		private void SetIntBitValue()
		{
			txtDescription.Text += "Function to set the bit value (on or off) of an Int32 used as a bitmask." + Environment.NewLine + Environment.NewLine +
									"\tCommonHelpers.SetIntBitValue(ref bitmask, 1, true);";

			Int32 bitmask = 0;
			Int32 previousBitmask = bitmask;
			CommonHelpers.SetIntBitValue(ref bitmask, 1, true);
			txtResults.Text += $"The number [{previousBitmask}] bit 1 is set on, resulting in {bitmask}." + Environment.NewLine;
			previousBitmask = bitmask;

			CommonHelpers.SetIntBitValue(ref bitmask, 2, true);
			txtResults.Text += $"The number [{previousBitmask}] bit 2 is set on, resulting in {bitmask}." + Environment.NewLine;
			previousBitmask = bitmask;

			CommonHelpers.SetIntBitValue(ref bitmask, 1, false);
			txtResults.Text += $"The number [{previousBitmask}] bit 1 is set off, resulting in {bitmask}." + Environment.NewLine;

		}

		private void StringToBase64()
		{
			txtDescription.Text += "Converts a string to a base 64 string." + Environment.NewLine + Environment.NewLine +
									"\tString result = CommonHelpers.Base64ToString(base64);";

			String orig = "I am a string";
			String result = CommonHelpers.StringToBase64(orig);

			txtResults.Text += $"The string [{orig}] converted to a Base64 string: [{result}].";
		}

		private void TableDelimiter()
		{
			txtDescription.Text += "Returns a common, nonprintable ASCII table delimiter." + Environment.NewLine + Environment.NewLine +
									"\tString result = CommonHelpers.TableDelimiter;";

			String result = CommonHelpers.TableDelimiter;
			Int32 delimValue = CommonHelpers.Asc(result);

			txtResults.Text += $"Table delimiter ASCII value = {delimValue}";

		}

		public void TryGetValue()
		{
			txtDescription.Text += "How to add, then retrieve a value (of any data type) to the singleton ContextManager." + Environment.NewLine + Environment.NewLine +
									"\tIPAddress[] ips = Dns.GetHostAddresses(Environment.MachineName);" + Environment.NewLine +
									"\tContextMgr.Instance.ContextValues.AddCheck(\"IP Addresses\", ips);" + Environment.NewLine +
									"\tdynamic ipsDynamic = null;" + Environment.NewLine +
									"\tContextMgr.Instance.ContextValues.TryGetValue(\"IP Addresses\", out ipsDynamic);" + Environment.NewLine +
									"\tIPAddress[] ipsCopy = (IPAddress[])ipsDynamic;";

			IPAddress[] ips = Dns.GetHostAddresses(Environment.MachineName);
			dynamic ipsDynamic = null;
			ContextMgr.Instance.ContextValues.AddCheck("IP Addresses", ips);

			for (int i = 0; i < ips.Length; i++)
			{
				txtResults.Text += $"Stored IP address {ips[i].ToString()}" + Environment.NewLine;
			}

			txtResults.Text += Environment.NewLine;

			ContextMgr.Instance.ContextValues.TryGetValue("IP Addresses", out ipsDynamic);

			IPAddress[] ipsCopy = (IPAddress[])ipsDynamic;

			for (int i = 0; i < ips.Length; i++)
			{
				txtResults.Text += $"Read IP address from context {ipsCopy[i].ToString()}" + Environment.NewLine;
			}

		}

		private void WriteToLog()
		{
			try
			{
				txtDescription.Text += "Method to write to directly a log file." + Environment.NewLine + Environment.NewLine +
									   "\tBoolean result = CommonHelpers.WriteToLog(@\"C:\\TestFile.log\", \"Main message to log\", \"Optional second message to log\");";

				Boolean result = CommonHelpers.WriteToLog(@"C:\TestFile.log", "Main message to log", "Optional second message to log");
				Thread.Sleep(1000);
				result = CommonHelpers.WriteToLog(@"C:\TestFile.log", "Main message to log, entry 2", "Optional second message to log");
				Thread.Sleep(1000);
				result = CommonHelpers.WriteToLog(@"C:\TestFile.log", "Main message to log, entry 3", "Optional second message to log");

				if (File.Exists(@"C:\TestFile.log"))
				{
					String results = File.ReadAllText(@"C:\TestFile.log");

					txtResults.Text += "The file [C:\\TestFile.log] has these contents:" + Environment.NewLine;
					txtResults.Text += $"{results}" + Environment.NewLine;

					File.Delete(@"C:\TestFile.log");
				}
				else
				{
					txtResults.Text += "The file [C:\\TestFile.log] was not found." + Environment.NewLine;
				}
			}
			catch (Exception exUnhandled)
			{
				MessageBox.Show(this, "This example requires \"Run as Administrator\" to access the C: drive for write access." + Environment.NewLine +
									  $"Error Message: {exUnhandled.Message}");
			}
		}

	}
}
