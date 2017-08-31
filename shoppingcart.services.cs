<?xml version="1.0" encoding="utf-8"?>

<Project ToolsVersion="12.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />

  <PropertyGroup>

    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>

    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>

    <ProjectGuid>{13E869B9-2A61-4A93-B136-268BEEEA92B5}</ProjectGuid>

    <OutputType>Library</OutputType>

    <AppDesignerFolder>Properties</AppDesignerFolder>

    <RootNamespace>ShoppingCart.Services</RootNamespace>

    <AssemblyName>ShoppingCart.Services</AssemblyName>

    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>

    <FileAlignment>512</FileAlignment>

  </PropertyGroup>

  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">

    <DebugSymbols>true</DebugSymbols>

    <DebugType>full</DebugType>

    <Optimize>false</Optimize>

    <OutputPath>bin\Debug\</OutputPath>

    <DefineConstants>DEBUG;TRACE</DefineConstants>

    <ErrorReport>prompt</ErrorReport>

    <WarningLevel>4</WarningLevel>

  </PropertyGroup>

  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">

    <DebugType>pdbonly</DebugType>

    <Optimize>true</Optimize>

    <OutputPath>bin\Release\</OutputPath>

    <DefineConstants>TRACE</DefineConstants>

    <ErrorReport>prompt</ErrorReport>

    <WarningLevel>4</WarningLevel>

  </PropertyGroup>

  <ItemGroup>

    <Reference Include="AutoMapper, Version=5.0.2.0, Culture=neutral, PublicKeyToken=be96cd2c38ef1005, processorArchitecture=MSIL">

      <HintPath>..\packages\AutoMapper.5.0.2\lib\net45\AutoMapper.dll</HintPath>

      <Private>True</Private>

    </Reference>

    <Reference Include="System" />

    <Reference Include="System.Configuration" />

    <Reference Include="System.Core" />

    <Reference Include="System.Xml.Linq" />

    <Reference Include="System.Data.DataSetExtensions" />

    <Reference Include="Microsoft.CSharp" />

    <Reference Include="System.Data" />

    <Reference Include="System.Xml" />

  </ItemGroup>

  <ItemGroup>

    <Compile Include="AutoMapper.cs" />

    <Compile Include="Interfaces\IShoppingCartService.cs" />

    <Compile Include="MapperConfig.cs" />

    <Compile Include="Models\Generated\Database.cs">

      <AutoGen>True</AutoGen>

      <DesignTime>True</DesignTime>

      <DependentUpon>Database.tt</DependentUpon>

    </Compile>

    <Compile Include="Models\PetaPoco.cs" />

    <Compile Include="ShoppingCartService.cs" />

    <Compile Include="Properties\AssemblyInfo.cs" />

  </ItemGroup>

  <ItemGroup>

    <Service Include="{508349B6-6B84-4DF5-91F0-309BEEBAD82D}" />

  </ItemGroup>

  <ItemGroup>

    <None Include="app.config">

      <SubType>Designer</SubType>

    </None>

    <None Include="Models\Generated\PetaPoco.Core.ttinclude" />

    <None Include="Models\Generated\PetaPoco.Generator.ttinclude" />

    <None Include="packages.config" />

  </ItemGroup>

  <ItemGroup>

    <Content Include="Models\Generated\Database.tt">

      <Generator>TextTemplatingFileGenerator</Generator>

      <LastGenOutput>Database.cs</LastGenOutput>

    </Content>

  </ItemGroup>

  <ItemGroup>

    <ProjectReference Include="..\ShoppingCart.Models\ShoppingCart.Models.csproj">

      <Project>{fde6b1d3-c56a-4114-be37-2ecbf8b6b7ec}</Project>

      <Name>ShoppingCart.Models</Name>

    </ProjectReference>

  </ItemGroup>

  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />

  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 

       Other similar extension points exist, see Microsoft.Common.targets.

  <Target Name="BeforeBuild">

  </Target>

  <Target Name="AfterBuild">

  </Target>

  -->

</Project>