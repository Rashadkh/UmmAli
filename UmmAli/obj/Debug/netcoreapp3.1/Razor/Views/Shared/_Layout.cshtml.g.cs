#pragma checksum "C:\Users\Asus\source\repos\UmmAli\UmmAli\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21324bead6bc76f26fa73ee927a594d278ad716f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Asus\source\repos\UmmAli\UmmAli\Views\_ViewImports.cshtml"
using UmmAli;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\source\repos\UmmAli\UmmAli\Views\_ViewImports.cshtml"
using UmmAli.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21324bead6bc76f26fa73ee927a594d278ad716f", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"116d2b9a4fc2eba15dd287a141c31a76aa20cfa8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/slider.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logoMazqiTofiq.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21324bead6bc76f26fa73ee927a594d278ad716f5140", async() => {
                WriteLiteral("\r\n\r\n    <title>Umm Ali Şirniyyat Evi </title>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21324bead6bc76f26fa73ee927a594d278ad716f5455", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21324bead6bc76f26fa73ee927a594d278ad716f6634", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <!-- CSS only -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css"" />
    <!-- <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Pacifico&display=swap"" rel=""stylesheet"">



    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Pacifico&display=swap"" rel=""stylesheet""> -->

    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Courgette&family=Kaushan+Script&display=swap"" rel=""stylesheet"">
    <link rel=""preconnect""");
                WriteLiteral(" href=\"https://fonts.googleapis.com\">\r\n    <link rel=\"preconnect\" href=\"https://fonts.gstatic.com\" crossorigin>\r\n    <link href=\"https://fonts.googleapis.com/css2?family=Lobster&display=swap\" rel=\"stylesheet\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21324bead6bc76f26fa73ee927a594d278ad716f9846", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <div class=\"col\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21324bead6bc76f26fa73ee927a594d278ad716f10274", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@" <h1 class=""hhh""></h1>

                    <p style=""display: inline-block;""></p>
                </div>
            </div>

            <div class=""col"">
                <img style=""max-width: 100%; margin-left: 28px;margin-top: 0px;"" src=""./img/Son versia.png""");
                BeginWriteAttribute("alt", " alt=\"", 1912, "\"", 1918, 0);
                EndWriteAttribute();
                WriteLiteral(@">


            </div>

            <div class=""col"" style=""text-align: right;"">
                <h6 style=""margin-right: 16px; margin-top: 38px; color: #ddbc5b; font-size: larger; letter-spacing: 0.2em;"">Bizi İzləyin</h6>
                <a href=""https://www.facebook.com/ummali.sirniyyat"" target=""black""><img src=""./img/facebook (1).svg""></a>
                <a href=""https://www.instagram.com/ummali_shirniyyat/"" target=""blank""><img src=""./img/instagram (2).svg""></a>
                <a href="" https://wa.me/994777567772"" target=""blank""><img src=""./img/whatsapp (1).svg""></a>
                <h6 style=""margin-right: 12px; margin-top:6px; color: #ddbc5b; font-size: larger;"">Hər  Kəs  Dadacaq</h6>
            </div>

        </div>
    </div>











    <div style="" margin-top:-15px;background-image: url(./img/SC-Rose-Slider-a.jpg); background-repeat: no-repeat;background-position: center;background-size: 1519.2px;  "">




        <h1 class=""animate__animated animate__fadeInUp"" st");
                WriteLiteral(@"yle=""text-align: center; margin-bottom: 5px; margin-top: 15px; padding-top: 0px; color: white;font-family: 'Lobster', cursive;"">Xidmətlərimiz</h1>
        <div class=""container"">
            <div class=""row"">
                <div class=""col"" style=""font-size: larger;"">


                    <ul>
                        <li class=""animate__animated animate__fadeInUp""><b>Doğum Günü Tortları</b></li>
                        <li class=""animate__animated animate__fadeInUp""><b>Nişan,Nikah,Toy Tortları</b></li>


                    </ul>
                </div>
                <div class=""col"">


                    <ul>

                        <li class=""animate__animated animate__fadeInUp"">
                            <b> Hədiyyəlik Şirniyyatlar</b>

                        </li>
                        <li class=""animate__animated animate__fadeInUp"">
                            <b> Hədiyyəlik Qablaşdırma </b>
                        </li>


                    </ul>
                </");
                WriteLiteral(@"div>
                <div class=""col"">
                    <ul>
                        <li class=""animate__animated animate__fadeInUp""><b>Gündəlik Tortlar</b> </li>
                        <li class=""animate__animated animate__fadeInUp""><b>Milli Şirniyyatlar</b> </li>


                    </ul>
                </div>

                <div class=""col"">
                    <ul>
                        <li class=""animate__animated animate__fadeInUp""> <b>Cup Cakelər</b></li>
                        <li class=""animate__animated animate__fadeInUp""> <b>Dessertlər</b></li>
                    </ul>
                </div>

                <div class=""col"">


                    <ul>

                        <li class=""animate__animated animate__fadeInUp"">
                            <b>Xüsusi Sifarişlər</b>
                        </li>
                        <li class=""animate__animated animate__fadeInUp"">
                            <b>Xəstəxana Çıxışı Tortları</b>
                     ");
                WriteLiteral(@"   </li>
                    </ul>
                </div>


            </div>
        </div>


        <h1 style=""text-align: center; margin-bottom: 5px; margin-top: 0px; padding-top: 0px;color: white; font-family: 'Lobster', cursive;"" class=""animate__animated animate__flipInX"">Əlaqə Vasitələri</h1>
        <div class=""container"">
            <div class=""row"">

                <div class=""col"">
                    <a class=""animate__animated animate__flipInX"" href=""tel:+994777567772""><img class=""animate__animated animate__flipInX"" style=""margin:5px; width: 50px;"" src=""./img/call-now.svg""> <b style=""  font-size: larger;  color: white; text-decoration: underline;""> (+994)77-756-77-72</b></a>
                </div>
                <div class=""col"">
                    <a class=""animate__animated animate__flipInX"" href=""tel:+994777567772""><img class=""animate__animated animate__flipInX"" style=""margin:5px; width: 50px; "" src=""./img/call-now.svg""><b style=""  font-size: larger;  color: white; text-d");
                WriteLiteral(@"ecoration: underline;""> (+994)77-716-77-72</b></a>
                </div>
                <div class=""col"">
                    <b class=""animate__animated animate__flipInX""><img class=""animate__animated animate__flipInX"" style=""margin:5px; width: 60px;  "" src=""./img/shipped.svg""> <b style=""color: white; font-size: larger;""> 7/24 Çatdırılma Xidməti Mövcutdur</b>
                </div>

            </div>
        </div>



        <h1 style=""text-align: center; margin-bottom: 5px; margin-top: 0px; padding-top: 0px;color: white; font-family: 'Lobster', cursive;"" class=""animate__animated animate__fadeInDownBig""> Fərqimiz</h1>
        <div class=""container"">
            <div class=""row"">
                <div class=""col"">
                    <p style=""color: white; font-size: larger;"" class=""animate__animated animate__fadeInLeftBig"">
                        Klassik, gündəlik və özəl günləriniz üçün tort və şirniyyatlar hər gün təzə və
                        ən yaxşı inqridientlərdən istifadə edil");
                WriteLiteral(@"ərək ev üsulu ilə hazırlanır.
                        Dadlı,həssas və mehriban münasibət üçün bizi tərcih edin fərqi hiss edin
                    </p>

                </div>
                <div class=""col"">
                    <P style=""color: white; font-size: larger;"" class=""animate__animated animate__fadeInRightBig"">
                        Tort və şirniyyatlarımızda heç bir qarışıq suni qoruyucu və ya qatı yağlar istifadə etmirik.
                        Yalnız ən təzə və ən yaxşı məhsullardan istifadə edərək sıfırdan bişiririk.
                    </P>
                </div>

            </div>
        </div>



    </div>






    <div style=""text-align: center; font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; letter-spacing: 5px; "">
        <h4 style=""margin-top: 7px;"">
            <b> WebSite   Üzərində   Çalışma   Gedir, Tezliklə   Tam   Versiya   Xidmətinizdə   Olacaq</b>
        </h4>


    </div");
                WriteLiteral(@">














    <div class=""slider"" style=""max-width: 100%; height: 900px; margin-bottom:  10px;  margin-top: -1px;   background-size: cover;
max-width: 100%;
height: 601px;

background-position: center;"">
        <input name=""control"" id=""page1"" type=""radio"" checked />
        <input name=""control"" id=""page2"" type=""radio"" />
        <input name=""control"" id=""page3"" type=""radio"" />
        <input name=""control"" id=""page4"" type=""radio"" />
        <div class=""slider--el slider--el-1 anim-4parts"">
            <div class=""slider--el-bg"">
                <div class=""part top left""></div>
                <div class=""part top right""></div>
                <div class=""part bot left""></div>
                <div class=""part bot right""></div>
            </div>
            <div class=""slider--el-content"">
                <h1 class=""slider-h1-right"">
                    LƏZZƏTLİ QURABİYƏLƏR !
                </h1>
                <p class=""slider-p-right"">
                    Hər g");
                WriteLiteral(@"ün təzə bişirilən peçenyelər.
                </p>
                <div class=""btn-group"" role=""group"" aria-label=""Basic mixed styles example"">

                    <button style=""margin-left: 590px;"" type=""button"" class=""btn btn-success WhatsApp""><a style=""text-decoration:none; color: white;"" href="" https://wa.me/994777567772"" target=""blank""><b>WhatsApp</b></a></button>
                </div>
            </div>
        </div>
        <div class=""slider--el slider--el-2 anim-9parts"">
            <div class=""slider--el-bg"">
                <div class=""part left-top""></div>
                <div class=""part mid-top""></div>
                <div class=""part right-top""></div>
                <div class=""part left-mid""></div>
                <div class=""part mid-mid""></div>
                <div class=""part right-mid""></div>
                <div class=""part left-bot""></div>
                <div class=""part mid-bot""></div>
                <div class=""part right-bot""></div>
            </div>
      ");
                WriteLiteral(@"      <div class=""slider--el-content"">
                <h1 class=""LimonCupcake"">LIMON CUPCAKELƏRİ !</h1>

                <p class=""limon"">
                    Sitrus ətirli,təbii qaymaqlı tam fərqli bir dad təqdim edirik.

                </p>

                <div class=""btn-group"" role=""group"" aria-label=""Basic mixed styles example"">

                    <button style=""     margin-left: 589px;
        margin-top: 9px;"" type=""button"" class=""btn btn-success WhatsApp"">
                        <a style=""text-decoration:none; color: white;"" href="" https://wa.me/994777567772"" target=""blank""><b>WhatsApp</b></a>
                    </button>
                </div>
            </div>
        </div>
        <div class=""slider--el slider--el-3 anim-5parts"">
            <div class=""slider--el-bg"">
                <div class=""part part-1""></div>
                <div class=""part part-2""></div>
                <div class=""part part-3""></div>
                <div class=""part part-4""></div>
         ");
                WriteLiteral(@"       <div class=""part part-5""></div>
            </div>
            <div class=""slider--el-content"">
                <h1 class=""slider-h1"">
                    NİŞAN,TOY TORTLARI !
                </h1>
                <p class=""slider-p"">
                    Seçdiyiniz tort ləzzətli və xüsusi olaraq sizin üçün hazırlanır.<br>

                    Xəyallarınızdakı toy tortunu hazırlamaq haqqında daha ətraflı<br> məlumat üçün

                    bizimlə əlaqə saxlayın
                </p>
                <div class=""btn-group"" role=""group"" aria-label=""Basic mixed styles example"">

                    <button style="" margin-left: -82px;"" type=""button"" class=""btn btn-success WhatsApp""><a style=""text-decoration:none; color: white;"" href="" https://wa.me/994777567772"" target=""blank""><b>WhatsApp</b></a></button>
                </div>
            </div>
        </div>
        <div class=""slider--el slider--el-4 anim-3parts"">
            <div class=""slider--el-bg"">
                <div class=""");
                WriteLiteral(@"part left""></div>
                <div class=""part mid""></div>
                <div class=""part right""></div>
            </div>
            <div class=""slider--el-content"">
                <h1 class=""slider-h1"" style=""color: #6c3f21;"">
                    ZƏRİF DADLI TORTLAR !
                </h1>
                <p class=""slider-p"" style=""color: #6c3f21;"">
                    <b>
                        Gündəlik ehtiyyaclarınıza uyğun sadə,<br>
                        giləmeyvli tort sifarişləri də qəbul edilir. </h2>
                    </b>
                    <div class=""btn-group"" role=""group"" aria-label=""Basic mixed styles example"">

                        <button style="" margin-left: -82px;"" type=""button"" class=""btn btn-success WhatsApp""><a style=""text-decoration:none; color: white;"" href="" https://wa.me/994777567772"" target=""blank""><b>WhatsApp</b></a></button>
                    </div>

                </p>
            </div>
        </div>
        <div class=""slider--control ");
                WriteLiteral(@"left"">
            <label class=""page1-left"" for=""page1""></label>
            <label class=""page2-left"" for=""page2""></label>
            <label class=""page3-left"" for=""page3""></label>
            <label class=""page4-left"" for=""page4""></label>
        </div>
        <div class=""slider--control right"">
            <label class=""page1-right"" for=""page1""></label>
            <label class=""page2-right"" for=""page2""></label>
            <label class=""page3-right"" for=""page3""></label>
            <label class=""page4-right"" for=""page4""></label>
        </div>
    </div>








    <footer class=""content-info"">

        <div class=""footer-meta"" style=""    margin-top: -12px;"">
            <p class=""text-center"">All Rigths Reserved © Umm Ali 2021</p>
        </div>
        <div style=""margin-top: -21px; margin-bottom: -13px;"">
            <p class=""text-center"">Web Developer  <a href="" https://wa.me/994507880807"" target=""blank""><b>Rashad</b></a></p>
        </div>
    </footer>

    ");
#nullable restore
#line 346 "C:\Users\Asus\source\repos\UmmAli\UmmAli\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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