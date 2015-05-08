//-----------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Experian Data Quality">
//   Copyright (c) Experian. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

//// This file is used by Code Analysis to maintain SuppressMessage 
//// attributes that are applied to this project.
//// Project-level suppressions either have no target or are given 
//// a specific target and scoped to a namespace, type, member, etc.
////
//// To add a suppression to this file, right-click the message in the 
//// Code Analysis results, point to "Suppress Message", and click 
//// "In Suppression File".
//// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Experian.Qas.Updates.Metadata.WebApi.V1.AvailablePackagesReply.#PackageGroups", Justification = "Required for serialization.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Experian.Qas.Updates.Metadata.WebApi.V1.Package.#Files", Justification = "Required for serialization.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Experian.Qas.Updates.Metadata.WebApi.V1.PackageGroup.#Packages", Justification = "Required for serialization.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Experian.Qas.Updates.Metadata.WebApi.V1.IMetadataApi.#GetAvailablePackagesAsync()", Justification = "Requires a web service call.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "0#", Scope = "member", Target = "Experian.Qas.Updates.Metadata.WebApi.V1.MetadataApi.#Post`2(System.String,!!0)", Justification = "Matches the Web API infrastructure.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Experian.Qas.Updates.Metadata.WebApi.V1.FileDownloadReply.#DownloadUri", Justification = "Matches the Web API infrastructure.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "hh", Scope = "member", Target = "Experian.Qas.Updates.Metadata.WebApi.V1.Program.#MainInternal()", Justification = "Value is a format string.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ss", Scope = "member", Target = "Experian.Qas.Updates.Metadata.WebApi.V1.Program.#MainInternal()", Justification = "Value is a format string.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Experian.Qas.Updates.Metadata.WebApi.V1.AvailablePackagesReply.#PackageGroups", Justification = "Required for serialization.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Experian.Qas.Updates.Metadata.WebApi.V1.Package.#Files", Justification = "Required for serialization.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Experian.Qas.Updates.Metadata.WebApi.V1.PackageGroup.#Packages", Justification = "Required for serialization.")]
