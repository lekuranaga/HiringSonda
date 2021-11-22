#pragma checksum "D:\Projeto\HiringSonda\HiringSonda\Views\Home\Challenge.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf14d77f96994d731430ebebac5b8a623ee23578"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Challenge), @"mvc.1.0.view", @"/Views/Home/Challenge.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Projeto\HiringSonda\HiringSonda\Views\_ViewImports.cshtml"
using HiringSonda;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projeto\HiringSonda\HiringSonda\Views\_ViewImports.cshtml"
using HiringSonda.Domain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf14d77f96994d731430ebebac5b8a623ee23578", @"/Views/Home/Challenge.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a76e66f4d06baa41d6822491ca3049c0af7d4cb9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Challenge : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Projeto\HiringSonda\HiringSonda\Views\Home\Challenge.cshtml"
  
    ViewData["Title"] = "Desafio";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 id=""formul-rio-de-cadastro-de-usu-rio"">Formulário de Cadastro de Usuário</h1>
<p>Desenvolver uma aplicação utilizando ASP.NET Core MVC, esta aplicação deverá ter três páginas.</p>
<h2 id=""p-gina-1"">Página 1</h2>
<ul>
<li>Formulário de Cadastro de Usuário *</li>
</ul>
<h2 id=""p-gina-2"">Página 2</h2>
<ul>
<li>Lista de usuários cadastrados
<em>Exibir apenas os nomes completos em lista e ao clicar em um nome ir para página 3.</em></li>
</ul>
<h2 id=""p-gina-3"">Página 3</h2>
<ul>
<li>Detalhes do usuário selecionado</li>
<li>Exibir todos os dados do usuário</li>
</ul>
<hr>
<h2 id=""descri-o-do-formul-rio"">DESCRIÇÃO DO FORMULÁRIO</h2>
<p>O formulário irá solicitar os seguintes campos do usuário.</p>
<p><h3>Dados de usuário</h3>
Nome Completo [STRING] <br />
Data de Nascimento [DATETIME] <br />
CPF [STRING] <br />
Email [STRING]</p>
<p><h3>Dados de endereço</h3>
CEP [STRING] <br />
Logradouro [STRING] <br />
Complemento [STRING] <br />
Bairro [STRING] <br />
Cidade [STRING] <br />
Es");
            WriteLiteral(@"tado [STRING]</p>
<h2>Observações</h2>
<p>Adicionar uma validação de campos em javascript ou jquery no formulário de cadastro de usuário, todos os campos são obrigatórios.</p>
<p>Ao preencher o CEP as demais informações de endereço deverão ser preenchidas automaticamente.
<a href=""https://viacep.com.br/"">https://viacep.com.br/</a></p>
<p>Ao salvar o formulário, salvar as informações em banco. UTILIZAR ENTITY FRAMEWORK
Utilizar duas tabelas, uma tabela Usuários para salvar os dados de um usuário e uma tabela Endereços para salvar os dados de endereço.
A associação neste caso é de 1:1.</p>
<p>Hospedar o código em um repositório público no GitHub e enviar o link.</p>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
