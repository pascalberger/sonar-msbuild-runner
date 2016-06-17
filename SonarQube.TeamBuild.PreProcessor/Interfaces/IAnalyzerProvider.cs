﻿//-----------------------------------------------------------------------
// <copyright file="IAnalyzerProvider.cs" company="SonarSource SA and Microsoft Corporation">
//   Copyright (c) SonarSource SA and Microsoft Corporation.  All rights reserved.
//   Licensed under the MIT License. See License.txt in the project root for license information.
// </copyright>
//-----------------------------------------------------------------------

using SonarQube.Common;
using SonarQube.TeamBuild.Integration;
using SonarQube.TeamBuild.PreProcessor.Roslyn;
using System.Collections.Generic;

namespace SonarQube.TeamBuild.PreProcessor
{
    public interface IAnalyzerProvider
    {
        /// <summary>
        /// Sets up the client to run the Roslyn analyzers as part of the build
        /// i.e. creates the Roslyn rulesets and provisions the analyzers' assemblies
        /// and rule parameter files
        /// </summary>
        /// <param name="projectKey">Identifier for the project being analyzed</param>
        /// <returns>The settings required to configure the build for Roslyn analysis</returns>
        IEnumerable<AnalyzerSettings> SetupAnalyzers(ISonarQubeServer server, TeamBuildSettings settings, string projectKey, string projectBranch);
    }
}
