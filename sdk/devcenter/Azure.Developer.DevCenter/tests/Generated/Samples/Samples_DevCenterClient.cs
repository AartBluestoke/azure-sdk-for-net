// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Developer.DevCenter;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Developer.DevCenter.Samples
{
    public class Samples_DevCenterClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetProject()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            DevCenterClient client = new DevCenterClient(endpoint, credential);

            Response response = client.GetProject("<projectName>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetProject_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            DevCenterClient client = new DevCenterClient(endpoint, credential);

            Response response = await client.GetProjectAsync("<projectName>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetProject_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            DevCenterClient client = new DevCenterClient(endpoint, credential);

            Response response = client.GetProject("<projectName>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetProject_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            DevCenterClient client = new DevCenterClient(endpoint, credential);

            Response response = await client.GetProjectAsync("<projectName>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetProjects()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            DevCenterClient client = new DevCenterClient(endpoint, credential);

            foreach (BinaryData item in client.GetProjects(null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetProjects_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            DevCenterClient client = new DevCenterClient(endpoint, credential);

            await foreach (BinaryData item in client.GetProjectsAsync(null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetProjects_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            DevCenterClient client = new DevCenterClient(endpoint, credential);

            foreach (BinaryData item in client.GetProjects("<filter>", 1234, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("description").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetProjects_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            DevCenterClient client = new DevCenterClient(endpoint, credential);

            await foreach (BinaryData item in client.GetProjectsAsync("<filter>", 1234, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("description").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAllDevBoxes()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            DevCenterClient client = new DevCenterClient(endpoint, credential);

            foreach (BinaryData item in client.GetAllDevBoxes(null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("poolName").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAllDevBoxes_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            DevCenterClient client = new DevCenterClient(endpoint, credential);

            await foreach (BinaryData item in client.GetAllDevBoxesAsync(null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("poolName").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAllDevBoxes_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            DevCenterClient client = new DevCenterClient(endpoint, credential);

            foreach (BinaryData item in client.GetAllDevBoxes("<filter>", 1234, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("projectName").ToString());
                Console.WriteLine(result[0].GetProperty("poolName").ToString());
                Console.WriteLine(result[0].GetProperty("hibernateSupport").ToString());
                Console.WriteLine(result[0].GetProperty("provisioningState").ToString());
                Console.WriteLine(result[0].GetProperty("actionState").ToString());
                Console.WriteLine(result[0].GetProperty("powerState").ToString());
                Console.WriteLine(result[0].GetProperty("uniqueId").ToString());
                Console.WriteLine(result[0].GetProperty("errorDetails").GetProperty("code").ToString());
                Console.WriteLine(result[0].GetProperty("errorDetails").GetProperty("message").ToString());
                Console.WriteLine(result[0].GetProperty("location").ToString());
                Console.WriteLine(result[0].GetProperty("osType").ToString());
                Console.WriteLine(result[0].GetProperty("user").ToString());
                Console.WriteLine(result[0].GetProperty("hardwareProfile").GetProperty("skuName").ToString());
                Console.WriteLine(result[0].GetProperty("hardwareProfile").GetProperty("vCPUs").ToString());
                Console.WriteLine(result[0].GetProperty("hardwareProfile").GetProperty("memoryGB").ToString());
                Console.WriteLine(result[0].GetProperty("storageProfile").GetProperty("osDisk").GetProperty("diskSizeGB").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("version").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("operatingSystem").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("osBuildNumber").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("publishedDate").ToString());
                Console.WriteLine(result[0].GetProperty("createdTime").ToString());
                Console.WriteLine(result[0].GetProperty("localAdministrator").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAllDevBoxes_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            DevCenterClient client = new DevCenterClient(endpoint, credential);

            await foreach (BinaryData item in client.GetAllDevBoxesAsync("<filter>", 1234, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("projectName").ToString());
                Console.WriteLine(result[0].GetProperty("poolName").ToString());
                Console.WriteLine(result[0].GetProperty("hibernateSupport").ToString());
                Console.WriteLine(result[0].GetProperty("provisioningState").ToString());
                Console.WriteLine(result[0].GetProperty("actionState").ToString());
                Console.WriteLine(result[0].GetProperty("powerState").ToString());
                Console.WriteLine(result[0].GetProperty("uniqueId").ToString());
                Console.WriteLine(result[0].GetProperty("errorDetails").GetProperty("code").ToString());
                Console.WriteLine(result[0].GetProperty("errorDetails").GetProperty("message").ToString());
                Console.WriteLine(result[0].GetProperty("location").ToString());
                Console.WriteLine(result[0].GetProperty("osType").ToString());
                Console.WriteLine(result[0].GetProperty("user").ToString());
                Console.WriteLine(result[0].GetProperty("hardwareProfile").GetProperty("skuName").ToString());
                Console.WriteLine(result[0].GetProperty("hardwareProfile").GetProperty("vCPUs").ToString());
                Console.WriteLine(result[0].GetProperty("hardwareProfile").GetProperty("memoryGB").ToString());
                Console.WriteLine(result[0].GetProperty("storageProfile").GetProperty("osDisk").GetProperty("diskSizeGB").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("version").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("operatingSystem").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("osBuildNumber").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("publishedDate").ToString());
                Console.WriteLine(result[0].GetProperty("createdTime").ToString());
                Console.WriteLine(result[0].GetProperty("localAdministrator").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAllDevBoxesByUser()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            DevCenterClient client = new DevCenterClient(endpoint, credential);

            foreach (BinaryData item in client.GetAllDevBoxesByUser("me", null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("poolName").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAllDevBoxesByUser_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            DevCenterClient client = new DevCenterClient(endpoint, credential);

            await foreach (BinaryData item in client.GetAllDevBoxesByUserAsync("me", null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("poolName").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAllDevBoxesByUser_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            DevCenterClient client = new DevCenterClient(endpoint, credential);

            foreach (BinaryData item in client.GetAllDevBoxesByUser("me", "<filter>", 1234, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("projectName").ToString());
                Console.WriteLine(result[0].GetProperty("poolName").ToString());
                Console.WriteLine(result[0].GetProperty("hibernateSupport").ToString());
                Console.WriteLine(result[0].GetProperty("provisioningState").ToString());
                Console.WriteLine(result[0].GetProperty("actionState").ToString());
                Console.WriteLine(result[0].GetProperty("powerState").ToString());
                Console.WriteLine(result[0].GetProperty("uniqueId").ToString());
                Console.WriteLine(result[0].GetProperty("errorDetails").GetProperty("code").ToString());
                Console.WriteLine(result[0].GetProperty("errorDetails").GetProperty("message").ToString());
                Console.WriteLine(result[0].GetProperty("location").ToString());
                Console.WriteLine(result[0].GetProperty("osType").ToString());
                Console.WriteLine(result[0].GetProperty("user").ToString());
                Console.WriteLine(result[0].GetProperty("hardwareProfile").GetProperty("skuName").ToString());
                Console.WriteLine(result[0].GetProperty("hardwareProfile").GetProperty("vCPUs").ToString());
                Console.WriteLine(result[0].GetProperty("hardwareProfile").GetProperty("memoryGB").ToString());
                Console.WriteLine(result[0].GetProperty("storageProfile").GetProperty("osDisk").GetProperty("diskSizeGB").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("version").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("operatingSystem").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("osBuildNumber").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("publishedDate").ToString());
                Console.WriteLine(result[0].GetProperty("createdTime").ToString());
                Console.WriteLine(result[0].GetProperty("localAdministrator").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAllDevBoxesByUser_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            DevCenterClient client = new DevCenterClient(endpoint, credential);

            await foreach (BinaryData item in client.GetAllDevBoxesByUserAsync("me", "<filter>", 1234, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("projectName").ToString());
                Console.WriteLine(result[0].GetProperty("poolName").ToString());
                Console.WriteLine(result[0].GetProperty("hibernateSupport").ToString());
                Console.WriteLine(result[0].GetProperty("provisioningState").ToString());
                Console.WriteLine(result[0].GetProperty("actionState").ToString());
                Console.WriteLine(result[0].GetProperty("powerState").ToString());
                Console.WriteLine(result[0].GetProperty("uniqueId").ToString());
                Console.WriteLine(result[0].GetProperty("errorDetails").GetProperty("code").ToString());
                Console.WriteLine(result[0].GetProperty("errorDetails").GetProperty("message").ToString());
                Console.WriteLine(result[0].GetProperty("location").ToString());
                Console.WriteLine(result[0].GetProperty("osType").ToString());
                Console.WriteLine(result[0].GetProperty("user").ToString());
                Console.WriteLine(result[0].GetProperty("hardwareProfile").GetProperty("skuName").ToString());
                Console.WriteLine(result[0].GetProperty("hardwareProfile").GetProperty("vCPUs").ToString());
                Console.WriteLine(result[0].GetProperty("hardwareProfile").GetProperty("memoryGB").ToString());
                Console.WriteLine(result[0].GetProperty("storageProfile").GetProperty("osDisk").GetProperty("diskSizeGB").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("version").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("operatingSystem").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("osBuildNumber").ToString());
                Console.WriteLine(result[0].GetProperty("imageReference").GetProperty("publishedDate").ToString());
                Console.WriteLine(result[0].GetProperty("createdTime").ToString());
                Console.WriteLine(result[0].GetProperty("localAdministrator").ToString());
            }
        }
    }
}
