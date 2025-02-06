using WebAPI.Tests.Testing;

namespace WebAPI.Integration.Tests;

// https://xunit.net/docs/shared-context#collection-fixture
[Collection(AppHostCollection.Name)]
public class MultipleSingletonTests(AppHostFixture appHostFixture)
{
    /// <summary>
    /// a0ac
    /// oacloud
    /// gm9415
    /// </summary>
    /// <returns></returns>
    [Theory]
    [InlineData("a0ac", @"{""comps"":""                                    "",""comp"":""a0ac                "",""unino"":""00000000"",""comp_name"":""我該停用"",""comp_name_short"":""停"",""comp_en"":"""",""orgmark"":""2"",""lang"":"" "",""org_empname"":"""",""title"":"""",""fiorg"":""     "",""taxid"":""            "",""labno"":""                    "",""heano"":""                    "",""heano_ar"":""  "",""phone"":"""",""phone_fax"":"""",""adzip"":""          "",""adcity"":"""",""adcity2"":"""",""adother"":"""",""adother2"":"""",""dt_start"":""        "",""dt_stop"":""20231201"",""website"":"""",""email"":"""",""date_modi"":""20231215"",""time_modi"":""142128"",""empno_modi"":""admin               "",""date_cret"":""20231215"",""time_cret"":""142120"",""empno_cret"":""admin               "",""date_tran"":""        "",""time_tran"":""      "",""empno_tran"":""                    "",""empname_tax"":"""",""taxid2"":""            "",""adzip_tax"":""          "",""adcity_tax"":"""",""adcity2_tax"":"""",""adother_tax"":"""",""adother2_tax"":"""",""insno"":""00000000"",""bank"":"""",""account"":"""",""stype3"":"" "",""app_service_uuid"":""                                    "",""fiorg1"":""     ""}")]
    [InlineData("oacloud", @"{""comps"":""                                    "",""comp"":""oacloud             "",""unino"":""23362601"",""comp_name"":""金震科技股份有限公司"",""comp_name_short"":""金震科"",""comp_en"":"""",""orgmark"":""2"",""lang"":"" "",""org_empname"":""林智穎"",""title"":""總經理"",""fiorg"":""     "",""taxid"":""            "",""labno"":""05435463H           "",""heano"":""121885952           "",""heano_ar"":""02"",""phone"":"""",""phone_fax"":"""",""adzip"":""          "",""adcity"":"""",""adcity2"":"""",""adother"":"""",""adother2"":"""",""dt_start"":""        "",""dt_stop"":""        "",""website"":"""",""email"":"""",""date_modi"":""20161122"",""time_modi"":""205858"",""empno_modi"":""0000000035          "",""date_cret"":""20161122"",""time_cret"":""205903"",""empno_cret"":""0000000035          "",""date_tran"":""        "",""time_tran"":""      "",""empno_tran"":""                    "",""empname_tax"":"""",""taxid2"":""            "",""adzip_tax"":""          "",""adcity_tax"":"""",""adcity2_tax"":"""",""adother_tax"":"""",""adother2_tax"":"""",""insno"":""03568400"",""bank"":"""",""account"":"""",""stype3"":"" "",""app_service_uuid"":""                                    "",""fiorg1"":""     ""}")]
    [InlineData("gm9415", @"{""comps"":""                                    "",""comp"":""gm9415              "",""unino"":""01681969"",""comp_name"":""金讚清潔社"",""comp_name_short"":""金讚"",""comp_en"":"""",""orgmark"":""2"",""lang"":"" "",""org_empname"":"""",""title"":"""",""fiorg"":""     "",""taxid"":""            "",""labno"":""000000000           "",""heano"":""0                   "",""heano_ar"":""  "",""phone"":"""",""phone_fax"":"""",""adzip"":""          "",""adcity"":"""",""adcity2"":"""",""adother"":"""",""adother2"":"""",""dt_start"":""        "",""dt_stop"":""        "",""website"":"""",""email"":"""",""date_modi"":""        "",""time_modi"":""      "",""empno_modi"":""                    "",""date_cret"":""20141231"",""time_cret"":""141420"",""empno_cret"":""admin               "",""date_tran"":""        "",""time_tran"":""      "",""empno_tran"":""                    "",""empname_tax"":"""",""taxid2"":""            "",""adzip_tax"":""          "",""adcity_tax"":"""",""adcity2_tax"":"""",""adother_tax"":"""",""adother2_tax"":"""",""insno"":""01681969"",""bank"":"""",""account"":"""",""stype3"":"" "",""app_service_uuid"":""                                    "",""fiorg1"":""     ""}")]
    public async Task GetWebResourceRootReturns(string tenantId, string agencyInfo)
    {
        appHostFixture.httpClient.DefaultRequestHeaders.Clear();
        appHostFixture.httpClient.DefaultRequestHeaders.Add("TenantId", tenantId);
        var response = await appHostFixture.httpClient.GetAsync("/todos/AgencyInfo");
        var responseContent = await response.Content.ReadAsStringAsync();

        // Assert
        Assert.Equal(agencyInfo, responseContent);
    }
}

