/*
 * Created by SharpDevelop.
 * User: Peter
 * Date: 12/1/2013
 * Time: 11:22 PM
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;
using PeterO;
namespace Test
{
  [TestFixture]
  public class BigIntTests
  {
    [Test]
    public void TestShifts(){
      TestCommon.DoTestShiftLeft("-123811",139,"-86283673867977343180521212970464571450529415168");
      TestCommon.DoTestShiftRight("-1042721",127,"-1");
      TestCommon.DoTestShiftLeft("28289813377724706864",42,"124419915025685412732996321017856");
      TestCommon.DoTestShiftRight("-88556196",89,"-1");
      TestCommon.DoTestShiftLeft("95420016902683",124,"2029359325205057921124007216852651400359607982358528");
      TestCommon.DoTestShiftRight("54724161556258550",46,"777");
      TestCommon.DoTestShiftLeft("3155330479",172,"18888788629006754555486743276665668286507090108498535077904384");
      TestCommon.DoTestShiftRight("505922772707026529601",162,"0");
      TestCommon.DoTestShiftLeft("43",179,"32948654128616610454704461083731647447802891126947446784");
      TestCommon.DoTestShiftRight("55107506188695852",155,"0");
      TestCommon.DoTestShiftLeft("139927165764765735",98,"44344688917485059031953365589728191494058147840");
      TestCommon.DoTestShiftRight("-129681850326606",82,"-1");
      TestCommon.DoTestShiftLeft("-5932507074570",65,"-218870879440128273010605152010240");
      TestCommon.DoTestShiftRight("-164856599394495851262",136,"-1");
      TestCommon.DoTestShiftLeft("977182433954",76,"73833817180053605702782459779743744");
      TestCommon.DoTestShiftRight("806",59,"0");
      TestCommon.DoTestShiftLeft("-622514242515706286301",48,"-175222181914160088088864870373523456");
      TestCommon.DoTestShiftRight("-3705319301976962591455",198,"-1");
      TestCommon.DoTestShiftLeft("-3291470468389122029764629",164,"-76967831660432252522639645744788730028057863137718831277031149803315134464");
      TestCommon.DoTestShiftRight("-7874",6,"-124");
      TestCommon.DoTestShiftLeft("-98",122,"-521057374347687022178292367629895073792");
      TestCommon.DoTestShiftRight("-68211003",140,"-1");
      TestCommon.DoTestShiftLeft("-49",91,"-121318123849967266940114173952");
      TestCommon.DoTestShiftRight("6068902883",26,"90");
      TestCommon.DoTestShiftLeft("-648511782422",3,"-5188094259376");
      TestCommon.DoTestShiftRight("-40179201736463413834",119,"-1");
      TestCommon.DoTestShiftLeft("404345",2,"1617380");
      TestCommon.DoTestShiftRight("3885671755362666632018353",98,"0");
      TestCommon.DoTestShiftLeft("6693",78,"2022835127670178266577108992");
      TestCommon.DoTestShiftRight("-46103832",141,"-1");
      TestCommon.DoTestShiftLeft("-529",125,"-22501171512647055896515645916425672982528");
      TestCommon.DoTestShiftRight("9513521405775",126,"0");
      TestCommon.DoTestShiftLeft("874040407364540365",46,"61505125826776570556365259407360");
      TestCommon.DoTestShiftRight("-841759",42,"-1");
      TestCommon.DoTestShiftLeft("5217653305",38,"1434217619637844049920");
      TestCommon.DoTestShiftRight("45",23,"0");
      TestCommon.DoTestShiftLeft("-96686542299678294981",195,"-4855290099662786731169262873707071307803974155563754428764583550664097092599808");
      TestCommon.DoTestShiftRight("-30237963515951208960",165,"-1");
      TestCommon.DoTestShiftLeft("8499707889996682",44,"149528442524012194768944627712");
      TestCommon.DoTestShiftRight("-8360715847",13,"-1020596");
      TestCommon.DoTestShiftLeft("-13500389315847",74,"-255015144043389332767251838216962048");
      TestCommon.DoTestShiftRight("644885602",15,"19680");
      TestCommon.DoTestShiftLeft("0",168,"0");
      TestCommon.DoTestShiftRight("883",161,"0");
      TestCommon.DoTestShiftLeft("-846142254218060",43,"-7442745978122825221254676480");
      TestCommon.DoTestShiftRight("2429",70,"0");
      TestCommon.DoTestShiftLeft("70238713904",122,"373453059636496095662395719277785618832808738816");
      TestCommon.DoTestShiftRight("682796443119308234148",24,"40697839446026");
      TestCommon.DoTestShiftLeft("6477547737146361502",81,"15661749414445103242955092351813456656072704");
      TestCommon.DoTestShiftRight("-3903",103,"-1");
      TestCommon.DoTestShiftLeft("-266357775008",122,"-1416200845742453577740480658355175655915684626432");
      TestCommon.DoTestShiftRight("3647870029988653182652",184,"0");
      TestCommon.DoTestShiftLeft("-79809915886898858",3,"-638479327095190864");
      TestCommon.DoTestShiftRight("3",121,"0");
      TestCommon.DoTestShiftLeft("-2422110",17,"-317470801920");
      TestCommon.DoTestShiftRight("-401218",66,"-1");
      TestCommon.DoTestShiftLeft("992748386",3,"7941987088");
      TestCommon.DoTestShiftRight("4778037404628",13,"583256519");
      TestCommon.DoTestShiftLeft("63975617419684836311569",90,"79197978341831104917323202958826721363112499347456");
      TestCommon.DoTestShiftRight("96435828997095659644",111,"0");
      TestCommon.DoTestShiftLeft("-5",36,"-343597383680");
      TestCommon.DoTestShiftRight("260454703626230583606495",9,"508700593019981608606");
      TestCommon.DoTestShiftLeft("-601433411293917760",28,"-161446052014318363932098560");
      TestCommon.DoTestShiftRight("4305",29,"0");
      TestCommon.DoTestShiftLeft("5",14,"81920");
      TestCommon.DoTestShiftRight("638492240656249",126,"0");
      TestCommon.DoTestShiftLeft("-174114439481063087626",37,"-23930106346641189525326472937472");
      TestCommon.DoTestShiftRight("-86865914012216193570",67,"-1");
      TestCommon.DoTestShiftLeft("7448512080846",56,"536721859708202934021553913856");
      TestCommon.DoTestShiftRight("-363324644456667305376877",54,"-20168570");
      TestCommon.DoTestShiftLeft("-59703",93,"-591269873323640468418419308363776");
      TestCommon.DoTestShiftRight("5512",3,"689");
      TestCommon.DoTestShiftLeft("71487",98,"22655134614628858806198705510678528");
      TestCommon.DoTestShiftRight("-147781341312",189,"-1");
      TestCommon.DoTestShiftLeft("24",11,"49152");
      TestCommon.DoTestShiftRight("0",165,"0");
      TestCommon.DoTestShiftLeft("3",193,"37662610412320084583014736539245998496614132666784207077376");
      TestCommon.DoTestShiftRight("-49",121,"-1");
      TestCommon.DoTestShiftLeft("67819",52,"305429623128639668224");
      TestCommon.DoTestShiftRight("2234156114144769734811162",160,"0");
      TestCommon.DoTestShiftLeft("700",134,"15244650038058043163159182412943215873228800");
      TestCommon.DoTestShiftRight("-77942712427873200200",42,"-17722121");
      TestCommon.DoTestShiftLeft("6276576613950791521892",136,"546766936667080900941860629192067668342714170840790299953856512");
      TestCommon.DoTestShiftRight("-903805304660224075644",107,"-1");
      TestCommon.DoTestShiftLeft("-2836032695181159871589597",43,"-24946007400836748172953351472782770176");
      TestCommon.DoTestShiftRight("346",102,"0");
      TestCommon.DoTestShiftLeft("73180669",179,"56074524460041292967155038590510394807031584948934374034767872");
      TestCommon.DoTestShiftRight("-462574",63,"-1");
      TestCommon.DoTestShiftLeft("-61846691821771550761",96,"-4899999750624939552759129778674981145424687005696");
      TestCommon.DoTestShiftRight("4070",171,"0");
      TestCommon.DoTestShiftLeft("5",157,"913438523331814323877303020447676887284957839360");
      TestCommon.DoTestShiftRight("89205727177314305",129,"0");
      TestCommon.DoTestShiftLeft("7353164484186685777542992",192,"46156561544271952617470445314182180457600033770710223735869306004759221308418424832");
      TestCommon.DoTestShiftRight("39",29,"0");
      TestCommon.DoTestShiftLeft("-45706435372006593296132",73,"-431685076904423040042061488261919348300447744");
      TestCommon.DoTestShiftRight("-50477768822581203",32,"-11752772");
      TestCommon.DoTestShiftLeft("233613",53,"2104198839497807364096");
      TestCommon.DoTestShiftRight("-381495",158,"-1");
      TestCommon.DoTestShiftLeft("501640124",112,"2604664439960221389894664116371513780731904");
      TestCommon.DoTestShiftRight("-8961068350471589879",162,"-1");
      TestCommon.DoTestShiftLeft("-1",137,"-174224571863520493293247799005065324265472");
      TestCommon.DoTestShiftRight("9717938618514529802101200",172,"0");
      TestCommon.DoTestShiftLeft("-69361174639252149690567",80,"-83852514900191336137353800653459076861543841792");
      TestCommon.DoTestShiftRight("3555206",136,"0");
      TestCommon.DoTestShiftLeft("9003966547185242187",99,"5706941798987135232828143652732062465862880198656");
      TestCommon.DoTestShiftRight("7362294472154",137,"0");
      TestCommon.DoTestShiftLeft("26157856168344161230",83,"252983261661416388301424194976434643366051840");
      TestCommon.DoTestShiftRight("891123745507778486444707",182,"0");
      TestCommon.DoTestShiftLeft("-6296435485198158",177,"-1206157413051990810652567234011004812833057585885263191632909199998976");
      TestCommon.DoTestShiftRight("-382988301589610888064772",58,"-1328758");
      TestCommon.DoTestShiftLeft("62784",30,"67413806678016");
      TestCommon.DoTestShiftRight("-3291246071",51,"-1");
      TestCommon.DoTestShiftLeft("-1907",115,"-79213680873807330300861251998581784576");
      TestCommon.DoTestShiftRight("412",38,"0");
      TestCommon.DoTestShiftLeft("-5814660581727282747714",181,"-17821882826291432240087538109542473506206387058060837927869725636311098851328");
      TestCommon.DoTestShiftRight("4999343069658270652",49,"8880");
      TestCommon.DoTestShiftLeft("9426764351514347372",165,"440871409103065790281574788744142448682977823185765935880479445090304");
      TestCommon.DoTestShiftRight("503385687552",90,"0");
      TestCommon.DoTestShiftLeft("7982017008",159,"5832865463197557408549322571506502950717625933067561467904");
      TestCommon.DoTestShiftRight("-9453086317049542866898158",129,"-1");
      TestCommon.DoTestShiftLeft("694015497",177,"132946956805540458297541352018274290221602936299449548678365184");
      TestCommon.DoTestShiftRight("82561056005194903194926",175,"0");
      TestCommon.DoTestShiftLeft("-346368781400224616899",15,"-11349812228922560246546432");
      TestCommon.DoTestShiftRight("-2132051051606692161325415",149,"-1");
      TestCommon.DoTestShiftLeft("578",14,"9469952");
      TestCommon.DoTestShiftRight("-617445132045510",7,"-4823790094106");
      TestCommon.DoTestShiftLeft("321390741239",44,"5653965712829249616871424");
      TestCommon.DoTestShiftRight("394866477762133948329677",7,"3084894357516671471325");
      TestCommon.DoTestShiftLeft("-3571856767",41,"-7854596096133781520384");
      TestCommon.DoTestShiftRight("-77740673380579212872779",126,"-1");
      TestCommon.DoTestShiftLeft("554716281",87,"85838186836672505470349979961786368");
      TestCommon.DoTestShiftRight("-2491111508224483833843",98,"-1");
      TestCommon.DoTestShiftLeft("-43763",100,"-55476193217788003297700222376869888");
      TestCommon.DoTestShiftRight("-71899707484548",48,"-1");
      TestCommon.DoTestShiftLeft("6",191,"18831305206160042291507368269622999248307066333392103538688");
      TestCommon.DoTestShiftRight("-291706875275252552049",105,"-1");
      TestCommon.DoTestShiftLeft("28",93,"277298568799925181577403826176");
      TestCommon.DoTestShiftRight("-9150980379467",33,"-1066");
      TestCommon.DoTestShiftLeft("-1964241106476506",185,"-96326103579543201568342980649038011122960462193050200876974918223265792");
      TestCommon.DoTestShiftRight("-788549887",79,"-1");
      TestCommon.DoTestShiftLeft("28156466",89,"17428008313088737003633922321416192");
      TestCommon.DoTestShiftRight("-265905120797",193,"-1");
      TestCommon.DoTestShiftLeft("486756148166895328075886",171,"1456936770614888654996623992625677003450662958466370311338933684396598755328");
      TestCommon.DoTestShiftRight("-39002800",12,"-9523");
      TestCommon.DoTestShiftLeft("32628",172,"195321345731922740900453698444766750168407109682056921088");
      TestCommon.DoTestShiftRight("70179081893360304",39,"127655");
      TestCommon.DoTestShiftLeft("-2895683052002632477775333",15,"-94885742248022261031742111744");
      TestCommon.DoTestShiftRight("-806780351465401907682719",105,"-1");
      TestCommon.DoTestShiftLeft("-52028176198826166407898",65,"-1919500901923225862483227951132725882126336");
      TestCommon.DoTestShiftRight("3740338",180,"0");
      TestCommon.DoTestShiftLeft("238058",159,"173961078389860043450866401953386451546625994657890304");
      TestCommon.DoTestShiftRight("-3748690276920105573",187,"-1");
      TestCommon.DoTestShiftLeft("-3284484",154,"-75004355371674270943645493345301689336431186601312256");
      TestCommon.DoTestShiftRight("3567941358019290278",59,"6");
      TestCommon.DoTestShiftLeft("-4",36,"-274877906944");
      TestCommon.DoTestShiftRight("-25273360741553115441",21,"-12051277514245");
      TestCommon.DoTestShiftLeft("431789683521346388758",120,"573946935627682376381303076078844989588951071785492676608");
      TestCommon.DoTestShiftRight("13671044744856",81,"0");
      TestCommon.DoTestShiftLeft("67174626506",16,"4402356322697216");
      TestCommon.DoTestShiftRight("-26625",99,"-1");
      TestCommon.DoTestShiftLeft("867588022729552",123,"9225778308958403539119154468855817316895316944879616");
      TestCommon.DoTestShiftRight("-13358105978685665",190,"-1");
      TestCommon.DoTestShiftLeft("-45756607993",126,"-3892541717532892924092346256291420636607730941952");
      TestCommon.DoTestShiftRight("-855389270870349808174741",71,"-363");
      TestCommon.DoTestShiftLeft("-2304118921677598987040",34,"-39584461658800292420558111375360");
      TestCommon.DoTestShiftRight("-38",9,"-1");
      TestCommon.DoTestShiftLeft("-39",162,"-227994255423620855239774833903740151066325476704256");
      TestCommon.DoTestShiftRight("82961289139145624",86,"0");
      TestCommon.DoTestShiftLeft("520096021644",75,"19648672163883769218344286569889792");
      TestCommon.DoTestShiftRight("7328746659973",164,"0");
      TestCommon.DoTestShiftLeft("-90",100,"-114088554020540646134703288483840");
      TestCommon.DoTestShiftRight("-29337",193,"-1");
      TestCommon.DoTestShiftLeft("-73311599717",9,"-37535539055104");
      TestCommon.DoTestShiftRight("6360",149,"0");
      TestCommon.DoTestShiftLeft("7409431609",15,"242792254963712");
      TestCommon.DoTestShiftRight("-9",187,"-1");
      TestCommon.DoTestShiftLeft("-400705",175,"-19189957053208312343390045172320770044435839373580634685440");
      TestCommon.DoTestShiftRight("-669716254155788",137,"-1");
      TestCommon.DoTestShiftLeft("5",42,"21990232555520");
      TestCommon.DoTestShiftRight("-5463532",80,"-1");
      TestCommon.DoTestShiftLeft("205127767121",111,"532542130410316001526540173233402599920631808");
      TestCommon.DoTestShiftRight("-868",33,"-1");
      TestCommon.DoTestShiftLeft("-748",130,"-1018124841827447882682416825435850488676352");
      TestCommon.DoTestShiftRight("7669818074419242",131,"0");
      TestCommon.DoTestShiftLeft("-32785410697205",30,"-35203066682606008401920");
      TestCommon.DoTestShiftRight("403415734450823",174,"0");
      TestCommon.DoTestShiftLeft("-90899630931933073401267",163,"-1062799675518359803915259742908872710540972551013718838276842631762804736");
      TestCommon.DoTestShiftRight("6095284762439",25,"181653");
      TestCommon.DoTestShiftLeft("9079",34,"155976032321536");
      TestCommon.DoTestShiftRight("715300",29,"0");
      TestCommon.DoTestShiftLeft("2347045339",76,"177337731882704386294221692207104");
      TestCommon.DoTestShiftRight("2341844084040",25,"69792");
      TestCommon.DoTestShiftLeft("1970639750289749185",174,"47187447343314208396017248234478749860829861211041535274881408607191040");
      TestCommon.DoTestShiftRight("5",70,"0");
      TestCommon.DoTestShiftLeft("-3954026059581734380670",48,"-1112959393034095598235580141949419520");
      TestCommon.DoTestShiftRight("17952157",7,"140251");
      TestCommon.DoTestShiftLeft("66885411437995",75,"2526859401341868697653840355430236160");
      TestCommon.DoTestShiftRight("-312298325770276160960",196,"-1");
      TestCommon.DoTestShiftLeft("429895",146,"38347915428489288941721990427280669478453803745280");
      TestCommon.DoTestShiftRight("-7",120,"-1");
    }

    [Test]
    public void TestVarious2(){
      TestCommon.DoTestAdd("9731846470799281784086","6611","9731846470799281790697");
      TestCommon.DoTestSubtract("-72","957411","-957483");
      TestCommon.DoTestMultiply("430629184422466","988633028108014","425734234587266973533256242524");
      TestCommon.DoTestDivide("-27526500133","8979","-3065653");
      TestCommon.DoTestRemainder("5874281518905759887121","-2278492313706247","231277881421553");
      Assert.AreEqual(47,BigInteger.fromString("-85982603081837569410528286507767742826808344678").getDigitCount(),"-85982603081837569410528286507767742826808344678");
      TestCommon.DoTestDivideAndRemainder("34073209154330329606552","-188128765664805140",
                                          "-181116",
                                          "79632183481870312"
                                         );
      TestCommon.DoTestPow("46",5,"205962976");
      TestCommon.DoTestShiftLeft("-9945865215736428406542269",24,"-166863929031296658445095460143104");
      TestCommon.DoTestShiftRight("406",66,"0");
      TestCommon.DoTestAdd("866763280043291101","-5","866763280043291096");
      TestCommon.DoTestSubtract("-766411607999738756447","-1636463758820399635","-764775144240918356812");
      TestCommon.DoTestMultiply("-540416","420115545","-227037162366720");
      TestCommon.DoTestDivide("-97841761957","79290972035269","0");
      TestCommon.DoTestRemainder("-9","-532848867432985518","-9");
      Assert.AreEqual(22,BigInteger.fromString("3754645159261318682646").getDigitCount(),"3754645159261318682646");
      TestCommon.DoTestDivideAndRemainder("-406492108605301","-31709120429660215161",
                                          "0",
                                          "-406492108605301"
                                         );
      TestCommon.DoTestPow("-265841442049945599096",8,"24944883084885856647891730011474971913720080452974650776019885458196955806924926937306723373915992476146444600747715202824669947517287802065707842519256876068110336");
      TestCommon.DoTestShiftLeft("-3538689",131,"-9633227749736710482677965009584931363432169472");
      TestCommon.DoTestShiftRight("-76455707392",137,"-1");
      TestCommon.DoTestAdd("46616995543283","-979","46616995542304");
      TestCommon.DoTestSubtract("1744","67226110717709141","-67226110717707397");
      TestCommon.DoTestMultiply("-7139886","877374","-6264350339364");
      TestCommon.DoTestDivide("-34343693559184","-5308","6470175877");
      TestCommon.DoTestRemainder("0","-862107795463271","0");
      Assert.AreEqual(15,BigInteger.fromString("-751469454502192").getDigitCount(),"-751469454502192");
      TestCommon.DoTestDivideAndRemainder("-455961453567943","1897485864753694545",
                                          "0",
                                          "-455961453567943"
                                         );
      TestCommon.DoTestPow("6380422",7,"430472910666622499516951316522525657077202249088");
      TestCommon.DoTestShiftLeft("-140939",120,"-187340064497930258211189663268851484196864");
      TestCommon.DoTestShiftRight("664547",90,"0");
      TestCommon.DoTestAdd("-9449501974461756741","980231675025516425","-8469270299436240316");
      TestCommon.DoTestSubtract("-2438241702557351719933806","2528303407048956146163","-2440770005964400676079969");
      TestCommon.DoTestMultiply("-712137415461787535","-2736210955245897","1948558197827041891199253094493895");
      TestCommon.DoTestDivide("7","488113909823934807582","0");
      TestCommon.DoTestRemainder("52550232636324","-5987168","2935300");
      Assert.AreEqual(23,BigInteger.fromString("16142821412008035581565").getDigitCount(),"16142821412008035581565");
      TestCommon.DoTestDivideAndRemainder("-3","44029",
                                          "0",
                                          "-3"
                                         );
      TestCommon.DoTestPow("535695608",9,"3632978031373267973380418025282921948365264209491300673708852404761485931184128");
      TestCommon.DoTestShiftLeft("869530830227205669061",145,"38782370974327406508135588178463937295202950561153915940086218752");
      TestCommon.DoTestShiftRight("559192098",66,"0");
      TestCommon.DoTestAdd("3556520425357444069951941","-9","3556520425357444069951932");
      TestCommon.DoTestSubtract("152634","-596252","748886");
      TestCommon.DoTestMultiply("-2052918178408","-60055586","123289204214344987088");
      TestCommon.DoTestDivide("1777","-271","-6");
      TestCommon.DoTestRemainder("-864670948519593993","-7892821","-5091196");
      Assert.AreEqual(15,BigInteger.fromString("808625313730178").getDigitCount(),"808625313730178");
      TestCommon.DoTestDivideAndRemainder("-1","633",
                                          "0",
                                          "-1"
                                         );
      TestCommon.DoTestPow("-99",8,"9227446944279201");
      TestCommon.DoTestShiftLeft("-721970664721432",63,"-6659004040421110696965111132717056");
      TestCommon.DoTestShiftRight("-97802555799727830676",165,"-1");
      TestCommon.DoTestAdd("1786390916635395","-309349613240","1786081567022155");
      TestCommon.DoTestSubtract("5457564279228594","95803103613488024500514","-95803098155923745271920");
      TestCommon.DoTestMultiply("91459533325","256850050027787","23491385710044302302501775");
      TestCommon.DoTestDivide("842","-3191768355","0");
      TestCommon.DoTestRemainder("44","594191381","44");
      Assert.AreEqual(26,BigInteger.fromString("33247193590013259359290820").getDigitCount(),"33247193590013259359290820");
      TestCommon.DoTestDivideAndRemainder("28746521232883","18",
                                          "1597028957382",
                                          "7"
                                         );
      TestCommon.DoTestPow("13054872470",5,"379195494296093488944848471018074807358046100700000");
      TestCommon.DoTestShiftLeft("40",74,"755578637259143234191360");
      TestCommon.DoTestShiftRight("950852365613099564",100,"0");
      TestCommon.DoTestAdd("1984676104783","-91567749261","1893108355522");
      TestCommon.DoTestSubtract("252770016091","-86722402912112","86975172928203");
      TestCommon.DoTestMultiply("-65138829359762","-481757","31381087015870861834");
      TestCommon.DoTestDivide("-264163628529","97422285275","-2");
      TestCommon.DoTestRemainder("-6713114","-6126539013521271867449","-6713114");
      Assert.AreEqual(34,BigInteger.fromString("-8966987758778646498123659357330112").getDigitCount(),"-8966987758778646498123659357330112");
      TestCommon.DoTestDivideAndRemainder("19099520195680903290","-15",
                                          "-1273301346378726886",
                                          "0"
                                         );
      TestCommon.DoTestPow("64305223",5,"1099591168650287178130469031088840602343");
      TestCommon.DoTestShiftLeft("249954315338257105",41,"549655352254405347130694696960");
      TestCommon.DoTestShiftRight("-2370756312883",149,"-1");
      TestCommon.DoTestAdd("-257281050825671722296","-90","-257281050825671722386");
      TestCommon.DoTestSubtract("46255100730","37648913138244712758","-37648913091989612028");
      TestCommon.DoTestMultiply("46566667189725","94179359","4385618866694631886275");
      TestCommon.DoTestDivide("3256199462125848","-3248221","-1002456255");
      TestCommon.DoTestRemainder("85516011","7","0");
      Assert.AreEqual(31,BigInteger.fromString("2513414139966907201297604732544").getDigitCount(),"2513414139966907201297604732544");
      TestCommon.DoTestDivideAndRemainder("83461019770","4121237857247788",
                                          "0",
                                          "83461019770"
                                         );
      TestCommon.DoTestPow("12425698791199360453759",2,"154397990449613247579532580001260994377230081");
      TestCommon.DoTestShiftLeft("-7356988471972993964613",137,"-1281768166734350711541146213743361513999928714099424033385742336");
      TestCommon.DoTestShiftRight("1116707",35,"0");
      TestCommon.DoTestAdd("-8670307251934110434","52285771663940680","-8618021480270169754");
      TestCommon.DoTestSubtract("-6052743972","-2069371868147737","2069365815403765");
      TestCommon.DoTestMultiply("99422498529858445","64939104341353681","6456408005908560512517548609686045");
      TestCommon.DoTestDivide("-6527015266007105377561","-66","98894170697077354205");
      TestCommon.DoTestRemainder("-61","462","-61");
      Assert.AreEqual(35,BigInteger.fromString("-43837884353520374452206381591148518").getDigitCount(),"-43837884353520374452206381591148518");
      TestCommon.DoTestDivideAndRemainder("-18","-27738",
                                          "0",
                                          "-18"
                                         );
      TestCommon.DoTestPow("-719677956246348115981021",0,"1");
      TestCommon.DoTestShiftLeft("-7",60,"-8070450532247928832");
      TestCommon.DoTestShiftRight("8300789617",22,"1979");
      TestCommon.DoTestAdd("-366479030","-26","-366479056");
      TestCommon.DoTestSubtract("3838432365011545272963","-634026555120476","3838432999038100393439");
      TestCommon.DoTestMultiply("8068","549669465507158875","4434733247711757803500");
      TestCommon.DoTestDivide("-3786407156511074831555","3754666418352965475293977","0");
      TestCommon.DoTestRemainder("-354773961029096170880534","715192857350396","-199438639721962");
      Assert.AreEqual(36,BigInteger.fromString("179048279487211368703894835967443904").getDigitCount(),"179048279487211368703894835967443904");
      TestCommon.DoTestDivideAndRemainder("-9940517216642016899","1036319595332527",
                                          "-9592",
                                          "-139658212417915"
                                         );
      TestCommon.DoTestPow("8547730345602592650133890",3,"624528754888191142521533366491398790101420823173927063730527747378382869000");
      TestCommon.DoTestShiftLeft("-79530316044",183,"-975038837608678866593741520597535504524111599904392099613168893952");
      TestCommon.DoTestShiftRight("41293969834007744",133,"0");
      TestCommon.DoTestAdd("-49368188332056","132146032938","-49236042299118");
      TestCommon.DoTestSubtract("7360765762550","-1746178","7360767508728");
      TestCommon.DoTestMultiply("-5460141368146566898244","315851077748135099","-1724591535786270051675244081715897866156");
      TestCommon.DoTestDivide("89286257958463011513","-57918","-1541597740917556");
      TestCommon.DoTestRemainder("9392487551828735146630","93067589280717954","13374029398510996");
      Assert.AreEqual(27,BigInteger.fromString("-716358188845970974634892000").getDigitCount(),"-716358188845970974634892000");
      TestCommon.DoTestDivideAndRemainder("-636153540613511409398622","361837",
                                          "-1758121863196719543",
                                          "-118131"
                                         );
      TestCommon.DoTestPow("-3656232766594",3,"-48876658719776941025866305896074712584");
      TestCommon.DoTestShiftLeft("5010455661618361548543168",111,"13007886595824529991484626484114240823420982412709214552064");
      TestCommon.DoTestShiftRight("-9152626699684",150,"-1");
      TestCommon.DoTestAdd("-9434925914222","5760984348","-9429164929874");
      TestCommon.DoTestSubtract("-5980950","4412015707922768978571772","-4412015707922768984552722");
      TestCommon.DoTestMultiply("2181","-8099056784977607739957","-17664042848036162480846217");
      TestCommon.DoTestDivide("-504695092473119833879","-592","852525494042432151");
      TestCommon.DoTestRemainder("-9235251797487266778","188249896128655743808","-9235251797487266778");
      Assert.AreEqual(34,BigInteger.fromString("4405892980538707593193144952448368").getDigitCount(),"4405892980538707593193144952448368");
      TestCommon.DoTestDivideAndRemainder("-6644160000397100446144135","-1699131408403345002072",
                                          "3910",
                                          "-556193540021488042615"
                                         );
      TestCommon.DoTestPow("-87481447985639259",7,"-39211345035971807833483875743559491297331139121547323166854004972572026408640535835556892448917684665982677886232335219");
      TestCommon.DoTestShiftLeft("4292258570889981271",158,"1568285732300827265314528313881501658491978713289933532902010650624");
      TestCommon.DoTestShiftRight("-50332563",29,"-1");
      TestCommon.DoTestAdd("205174297224976","16316374456","205190613599432");
      TestCommon.DoTestSubtract("899482164470130551328432","-3250164636065046882","899485414634766616375314");
      TestCommon.DoTestMultiply("803103954","-34787904220376214654842","-27938303430757425356856355445268");
      TestCommon.DoTestDivide("-381409112","48149636373795","0");
      TestCommon.DoTestRemainder("-5","-9719210694093545","-5");
      Assert.AreEqual(31,BigInteger.fromString("1633816882945304883107212489580").getDigitCount(),"1633816882945304883107212489580");
      TestCommon.DoTestDivideAndRemainder("-38076850019","629934969",
                                          "-60",
                                          "-280751879"
                                         );
      TestCommon.DoTestPow("-19795577011",2,"391864869198431694121");
      TestCommon.DoTestShiftLeft("5714206687956073432316",110,"7417464358723255534121072764373251082684611976530755584");
      TestCommon.DoTestShiftRight("630420259755228",0,"630420259755228");
      TestCommon.DoTestAdd("59323999354","-93955226345241593218862","-93955226345182269219508");
      TestCommon.DoTestSubtract("90908229762394150867","32837841754037469024942","-32746933524275074874075");
      TestCommon.DoTestMultiply("305610689839504063","-561569613053","-171621676838030695332331334339");
      TestCommon.DoTestDivide("-47375","369210599428659762","0");
      TestCommon.DoTestRemainder("-19758640220076986026694","793506597","-223856450");
      Assert.AreEqual(37,BigInteger.fromString("-7154022545719475306392761604851676204").getDigitCount(),"-7154022545719475306392761604851676204");
      TestCommon.DoTestDivideAndRemainder("0","-47847975853981096",
                                          "0",
                                          "0"
                                         );
      TestCommon.DoTestPow("90003092",7,"47841193694597145976079932815977021860866449765256347648");
      TestCommon.DoTestShiftLeft("-677662",146,"-60449470370906636557357511664317735819462802669568");
      TestCommon.DoTestShiftRight("-76152165979",78,"-1");
      TestCommon.DoTestAdd("933176813037073461724","-184112761678312617","932992700275395149107");
      TestCommon.DoTestSubtract("-1953996019256987957936","19416739722753652921699","-21370735742010640879635");
      TestCommon.DoTestMultiply("-590536","262352189242146294991","-154928412426300104458805176");
      TestCommon.DoTestDivide("-355677238","-189433689206917717205","0");
      TestCommon.DoTestRemainder("-4","-37330799924187360","-4");
      Assert.AreEqual(18,BigInteger.fromString("-333249837724620456").getDigitCount(),"-333249837724620456");
      TestCommon.DoTestDivideAndRemainder("9","-87457508504",
                                          "0",
                                          "9"
                                         );
      TestCommon.DoTestPow("17037206754",3,"4945328908694596499507279549064");
      TestCommon.DoTestShiftLeft("1622",136,"141296127781315120060823964993107977979297792");
      TestCommon.DoTestShiftRight("-38746",75,"-1");
      TestCommon.DoTestAdd("42","129605425812","129605425854");
      TestCommon.DoTestSubtract("-300968937666","276076102838","-577045040504");
      TestCommon.DoTestMultiply("4","361942","1447768");
      TestCommon.DoTestDivide("-7012969878486169188439","84564983","-82929950786913");
      TestCommon.DoTestRemainder("-783915174","2748746827552020442258170","-783915174");
      Assert.AreEqual(25,BigInteger.fromString("-1558177375744786559778489").getDigitCount(),"-1558177375744786559778489");
      TestCommon.DoTestDivideAndRemainder("-58195184484","-38568214250493075",
                                          "0",
                                          "-58195184484"
                                         );
      TestCommon.DoTestPow("-765",1,"-765");
      TestCommon.DoTestShiftLeft("-568873",82,"-2750901031126531770010505838592");
      TestCommon.DoTestShiftRight("-9665695350313",34,"-563");
      TestCommon.DoTestAdd("7491786218315852898","5103362202201289992598","5110853988419605845496");
      TestCommon.DoTestSubtract("96092276918","594199360","95498077558");
      TestCommon.DoTestMultiply("5766","63149","364117134");
      TestCommon.DoTestDivide("13041619641","-28","-465772130");
      TestCommon.DoTestRemainder("85485930","-15371417788525","85485930");
      Assert.AreEqual(33,BigInteger.fromString("171406899976143266485223706680806").getDigitCount(),"171406899976143266485223706680806");
      TestCommon.DoTestDivideAndRemainder("-83","-9586401142830749547458130",
                                          "0",
                                          "-83"
                                         );
      TestCommon.DoTestPow("-6042082619014",0,"1");
      TestCommon.DoTestShiftLeft("-575002195",26,"-38587744103956480");
      TestCommon.DoTestShiftRight("-4710382587656721850",76,"-1");
      TestCommon.DoTestAdd("-74010504912954382","-1894861166","-74010506807815548");
      TestCommon.DoTestSubtract("-2","-799090","799088");
      TestCommon.DoTestMultiply("-5152711897","-45063722679502078","232200379973779075346821966");
      TestCommon.DoTestDivide("777513003012368050398","715549562682074377376536","0");
      TestCommon.DoTestRemainder("-54649","2300","-1749");
      Assert.AreEqual(24,BigInteger.fromString("147828077716159306954944").getDigitCount(),"147828077716159306954944");
      TestCommon.DoTestDivideAndRemainder("5485150312424207739","532",
                                          "10310432918090616",
                                          "27"
                                         );
      TestCommon.DoTestPow("6218486328002179124987",4,"1495335815024281914778947508478192690190165974210107600439411045154533942045693599528561");
      TestCommon.DoTestShiftLeft("-1083",111,"-2811628748896609160849263762272681984");
      TestCommon.DoTestShiftRight("-45396",142,"-1");
      TestCommon.DoTestAdd("-150856395799","-20118516650091068561","-20118516800947464360");
      TestCommon.DoTestSubtract("-37418","9","-37427");
      TestCommon.DoTestMultiply("-612209782162","-8","4897678257296");
      TestCommon.DoTestDivide("8820957228542767684620611","832861717152075495246","10591");
      TestCommon.DoTestRemainder("-7435564","645721263241","-7435564");
      Assert.AreEqual(41,BigInteger.fromString("38050992151411552366387017168138983911084").getDigitCount(),"38050992151411552366387017168138983911084");
      TestCommon.DoTestDivideAndRemainder("430136821968423245722561","677951",
                                          "634465945132352110",
                                          "395951"
                                         );
      TestCommon.DoTestPow("-12851828805",9,"-9564987050831726901194260057377086768481628221467502865706105061018581679205727010626953125");
      TestCommon.DoTestShiftLeft("-449857387767155152",63,"-4149202050904114520343568832912162816");
      TestCommon.DoTestShiftRight("208949",37,"0");
      TestCommon.DoTestAdd("8809648935829556","-189285739287349065","-180476090351519509");
      TestCommon.DoTestSubtract("-680","7378","-8058");
      TestCommon.DoTestMultiply("1633253307170562600","279784","456958143293408686478400");
      TestCommon.DoTestDivide("760","5216039096","0");
      TestCommon.DoTestRemainder("271","139820","271");
      Assert.AreEqual(39,BigInteger.fromString("216596539380561487338426738143879581168").getDigitCount(),"216596539380561487338426738143879581168");
      TestCommon.DoTestDivideAndRemainder("79931423","-1129766937658217",
                                          "0",
                                          "79931423"
                                         );
      TestCommon.DoTestPow("-678",4,"211309379856");
      TestCommon.DoTestShiftLeft("-91",21,"-190840832");
      TestCommon.DoTestShiftRight("989565522383473328033",180,"0");
      TestCommon.DoTestAdd("78967964181499783","1326890801","78967965508390584");
      TestCommon.DoTestSubtract("5009027630439","-730388670","5009758019109");
      TestCommon.DoTestMultiply("526502","640668","337312983336");
      TestCommon.DoTestDivide("-9182678","-2231306179211515","0");
      TestCommon.DoTestRemainder("283068606558145","-48106462829893262555","283068606558145");
      Assert.AreEqual(14,BigInteger.fromString("39865519441176").getDigitCount(),"39865519441176");
      TestCommon.DoTestDivideAndRemainder("9167781792878055","264943372",
                                          "34602797",
                                          "75066571"
                                         );
      TestCommon.DoTestPow("85890557408149647995",4,"54422900601964953490460588956859321163508720903319827389679763013174670776000625");
      TestCommon.DoTestShiftLeft("7795763281589681239777168",109,"5059739649609907591874282889704550188400527860520783446016");
      TestCommon.DoTestShiftRight("4564870311256095485543163",191,"0");
      TestCommon.DoTestAdd("1313262825280479","-153","1313262825280326");
      TestCommon.DoTestSubtract("-202899423154859971374","-357204719","-202899423154502766655");
      TestCommon.DoTestMultiply("-3344114170168","-3944269080702054955","13190086123731252728692157582440");
      TestCommon.DoTestDivide("-26888681913509340555666","3772802238140","-7126978891");
      TestCommon.DoTestRemainder("5198423425011512","-894323657803","614325860476");
      Assert.AreEqual(35,BigInteger.fromString("20773342301970518523732459183784623").getDigitCount(),"20773342301970518523732459183784623");
      TestCommon.DoTestDivideAndRemainder("8","-76395",
                                          "0",
                                          "8"
                                         );
      TestCommon.DoTestPow("8833570108138",8,"37075761650273906759685772136743989510619278281979791361859963287135260966601118219869653388262624420096");
      TestCommon.DoTestShiftLeft("-1",106,"-81129638414606681695789005144064");
      TestCommon.DoTestShiftRight("-23174444670849102355683",58,"-80403");
      TestCommon.DoTestAdd("50","-8969743562125","-8969743562075");
      TestCommon.DoTestSubtract("-12127946039471","40963577385","-12168909616856");
      TestCommon.DoTestMultiply("-3234337035251690255667968","7771186517277970280283723","-25134636360680738588528133767881467966399922884864");
      TestCommon.DoTestDivide("69769","-4463","-15");
      TestCommon.DoTestRemainder("2","10348933099707","2");
      Assert.AreEqual(42,BigInteger.fromString("-393829286496444969299809344858420564215699").getDigitCount(),"-393829286496444969299809344858420564215699");
      TestCommon.DoTestDivideAndRemainder("-625542621","8032646575377982497",
                                          "0",
                                          "-625542621"
                                         );
      TestCommon.DoTestPow("622013315099093186",4,"149692046547762535712194352997731202540921590945768491717171554763315216");
      TestCommon.DoTestShiftLeft("0",103,"0");
      TestCommon.DoTestShiftRight("-48",133,"-1");
      TestCommon.DoTestAdd("-9315341018025394","4855796269744321","-4459544748281073");
      TestCommon.DoTestSubtract("-1591103958166569046950","-3","-1591103958166569046947");
      TestCommon.DoTestMultiply("178728244341421946323105","5903420113757815756706","1055107912541771836673753988483744129946492130");
      TestCommon.DoTestDivide("403532933736374324","752062077380","536568");
      TestCommon.DoTestRemainder("-569913431019149841463","-9687758857","-4870341119");
      Assert.AreEqual(29,BigInteger.fromString("-32364289372572444489035992466").getDigitCount(),"-32364289372572444489035992466");
      TestCommon.DoTestDivideAndRemainder("2","-4373228701111054",
                                          "0",
                                          "2"
                                         );
      TestCommon.DoTestPow("69722341134687",9,"38935670027728431022398997751831130368713657700746202072899844233375879624464653778727129082745171242677049845156829962488927");
      TestCommon.DoTestShiftLeft("-7467915944",148,"-2664641450099012574894879346140845407935791999970443264");
      TestCommon.DoTestShiftRight("-69",36,"-1");
      TestCommon.DoTestAdd("-50671440727391","5","-50671440727386");
      TestCommon.DoTestSubtract("-5672756325282","-8218578729416832","8212905973091550");
      TestCommon.DoTestMultiply("-6181305547759983625","-49943699153009","308717264650150126969136209477625");
      TestCommon.DoTestDivide("8","341130793824","0");
      TestCommon.DoTestRemainder("-71606594","750013460855411791719","-71606594");
      Assert.AreEqual(34,BigInteger.fromString("-5573956962349646430660386029992088").getDigitCount(),"-5573956962349646430660386029992088");
      TestCommon.DoTestDivideAndRemainder("-8903","-206687211964",
                                          "0",
                                          "-8903"
                                         );
      TestCommon.DoTestPow("45060813590581554572",4,"4122836528521330523426429484651778522583519431875873833016966033466413398937856");
      TestCommon.DoTestShiftLeft("-65016317253218",55,"-2342459697236756278613874049024");
      TestCommon.DoTestShiftRight("0",23,"0");
      TestCommon.DoTestAdd("-22937887000964250","396126417","-22937886604837833");
      TestCommon.DoTestSubtract("49290819","24145000381160","-24144951090341");
      TestCommon.DoTestMultiply("34943092","-6346585439147371582602746","-221769318885987006769073352930632");
      TestCommon.DoTestDivide("-87","91135087562549738160327","0");
      TestCommon.DoTestRemainder("83","-51585621505403088610773","83");
      Assert.AreEqual(32,BigInteger.fromString("-49814678981791067720540226214369").getDigitCount(),"-49814678981791067720540226214369");
      TestCommon.DoTestDivideAndRemainder("-488","-760230568576591264292311",
                                          "0",
                                          "-488"
                                         );
      TestCommon.DoTestPow("-7",3,"-343");
      TestCommon.DoTestShiftLeft("-23659894434947260767",185,"-1160277847005258759737599069735018537621461165971573942606887491073940127744");
      TestCommon.DoTestShiftRight("-6",191,"-1");
      TestCommon.DoTestAdd("-872476061","23754203694441414","23754202821965353");
      TestCommon.DoTestSubtract("1181543953045636326","-948766597115480","1182492719642751806");
      TestCommon.DoTestMultiply("8792164221674402659355","-27290","-239938161609494448573797950");
      TestCommon.DoTestDivide("-8","490110","0");
      TestCommon.DoTestRemainder("-32040939155736378632","81069163926133725940","-32040939155736378632");
      Assert.AreEqual(32,BigInteger.fromString("31786583417994378569476340669328").getDigitCount(),"31786583417994378569476340669328");
      TestCommon.DoTestDivideAndRemainder("-8135492335273667898569","58898664670957716",
                                          "-138126",
                                          "-55378932962418353"
                                         );
      TestCommon.DoTestPow("7150",5,"18686596544687500000");
      TestCommon.DoTestShiftLeft("9646529521393",136,"840331237916753339142080478467441732034651980717621248");
      TestCommon.DoTestShiftRight("-6009907",187,"-1");
      TestCommon.DoTestAdd("-51033283577","-4719","-51033288296");
      TestCommon.DoTestSubtract("40443","-7066167476611873","7066167476652316");
      TestCommon.DoTestMultiply("-386050906274107240382","-90177606","34813146521929370724915285492");
      TestCommon.DoTestDivide("47113327453589978759","265267352370","177606957");
      TestCommon.DoTestRemainder("-2563998802456163354608","-819317118","-82509478");
      Assert.AreEqual(24,BigInteger.fromString("714666605282148399581892").getDigitCount(),"714666605282148399581892");
      TestCommon.DoTestDivideAndRemainder("8688611","-7334525345674899816342307",
                                          "0",
                                          "8688611"
                                         );
      TestCommon.DoTestPow("-7742291532871256263",9,"-99959870374553629864365333917130501226912157998120952061812594992870799058775459159210553139199565969404311741645875852583762021172303231783541016762219211402052155055623");
      TestCommon.DoTestShiftLeft("-29082719976353260052",147,"-5188530622982964815156323099040240230323993585850459648537133056");
      TestCommon.DoTestShiftRight("-682211",188,"-1");
      TestCommon.DoTestAdd("-6845951021","5259940321068316","5259933475117295");
      TestCommon.DoTestSubtract("-13581102299400966","31335","-13581102299432301");
      TestCommon.DoTestMultiply("26790623074660034","-64666615467597284200","-1732458920506379266301795736679662800");
      TestCommon.DoTestDivide("979813694096439560","833531383218271","1175");
      TestCommon.DoTestRemainder("1567582265707026469998","-96078440969003864027045","1567582265707026469998");
      Assert.AreEqual(34,BigInteger.fromString("-8648182228706299099071706246361812").getDigitCount(),"-8648182228706299099071706246361812");
      TestCommon.DoTestDivideAndRemainder("1","65847421127128047357",
                                          "0",
                                          "1"
                                         );
      TestCommon.DoTestPow("379292533011114149",9,"162468300276873995897064314648123092273802972559572515203896281194108855142636909123519622546183482956357000376652179512401740615993344301298466020863013017349");
      TestCommon.DoTestShiftLeft("-413126267",119,"-274569499945257014740898130450931364078288896");
      TestCommon.DoTestShiftRight("1974891274605559",154,"0");
      TestCommon.DoTestAdd("-5775520998382","-52876611817","-5828397610199");
      TestCommon.DoTestSubtract("91884152126876","-1","91884152126877");
      TestCommon.DoTestMultiply("572424463646518915337439","-4359123","-2495268645244204473782483105997");
      TestCommon.DoTestDivide("-657283362228931128","-53832176536202","12209");
      TestCommon.DoTestRemainder("209222335787312","6623837338205318709","209222335787312");
      Assert.AreEqual(33,BigInteger.fromString("109816316242855734506307792130998").getDigitCount(),"109816316242855734506307792130998");
      TestCommon.DoTestDivideAndRemainder("-7973216359739201810541779","-2487828954678317292565989",
                                          "3",
                                          "-509729495704249932843812"
                                         );
      TestCommon.DoTestPow("277222191884",0,"1");
      TestCommon.DoTestShiftLeft("837864839",20,"878564961419264");
      TestCommon.DoTestShiftRight("551419",30,"0");
      TestCommon.DoTestAdd("72617810158386243855311","-8296084","72617810158386235559227");
      TestCommon.DoTestSubtract("863455587165896086011","-38090500361930702","863493677666258016713");
      TestCommon.DoTestMultiply("-649936255586264","-1835108513654","1192703555958755183418848656");
      TestCommon.DoTestDivide("878948573","-2729093602312","0");
      TestCommon.DoTestRemainder("331571045","411551504701225","331571045");
      Assert.AreEqual(28,BigInteger.fromString("-2535074714056093968530986401").getDigitCount(),"-2535074714056093968530986401");
      TestCommon.DoTestDivideAndRemainder("2467500717","554553820000002981",
                                          "0",
                                          "2467500717"
                                         );
      TestCommon.DoTestPow("6491284354590546",9,"20463301671271597365317758241131533688053703607245372853055136940319176701440436432947698346257997443581449869323221131477970296781721266541056");
      TestCommon.DoTestShiftLeft("-9152238809373122949734851",146,"-816406982735733194882711048471542623688800222810671836220791994712064");
      TestCommon.DoTestShiftRight("-27730009671167262693228",75,"-1");
      TestCommon.DoTestAdd("981969006552933","-488407991838","981480598561095");
      TestCommon.DoTestSubtract("-5138263341198289387825","-589725446691","-5138263340608563941134");
      TestCommon.DoTestMultiply("6","3595729","21574374");
      TestCommon.DoTestDivide("1702563592870805008","5486435424","310322360");
      TestCommon.DoTestRemainder("2847","-2735035312646","2847");
      Assert.AreEqual(23,BigInteger.fromString("15780907419932139705091").getDigitCount(),"15780907419932139705091");
      TestCommon.DoTestDivideAndRemainder("-62933093349221924","7520013635512324",
                                          "-8",
                                          "-2772984265123332"
                                         );
      TestCommon.DoTestPow("160689912935834161784",0,"1");
      TestCommon.DoTestShiftLeft("42",169,"31428131209163736353052038642730950054681173404155904");
      TestCommon.DoTestShiftRight("-506015203345992134956",199,"-1");
      TestCommon.DoTestAdd("-30341664703258392","9357275727952088","-20984388975306304");
      TestCommon.DoTestSubtract("-3527260524358847168442795","-596215933130211","-3527260523762631235312584");
      TestCommon.DoTestMultiply("-590823692699967258122007","-644478072737","380772914798632434497473281366423159");
      TestCommon.DoTestDivide("828999366","8160740378","0");
      TestCommon.DoTestRemainder("-852637700","1145971196434667454566941","-852637700");
      Assert.AreEqual(40,BigInteger.fromString("5923758091701971454609586040941881666000").getDigitCount(),"5923758091701971454609586040941881666000");
      TestCommon.DoTestDivideAndRemainder("-971129","8",
                                          "-121391",
                                          "-1"
                                         );
      TestCommon.DoTestPow("483021532676835275101",0,"1");
      TestCommon.DoTestShiftLeft("892",28,"239444426752");
      TestCommon.DoTestShiftRight("-531",122,"-1");
      TestCommon.DoTestAdd("1809","-931524800","-931522991");
      TestCommon.DoTestSubtract("-405168064338216451566","79","-405168064338216451645");
      TestCommon.DoTestMultiply("8078112689277848","142957","1154822755721093316536");
      TestCommon.DoTestDivide("63498","-48889978","0");
      TestCommon.DoTestRemainder("-3857047976361402549","28184175453204612","-24000114725575317");
      Assert.AreEqual(21,BigInteger.fromString("-130674220858722863721").getDigitCount(),"-130674220858722863721");
      TestCommon.DoTestDivideAndRemainder("82","6227270048529750898903",
                                          "0",
                                          "82"
                                         );
      TestCommon.DoTestPow("-82718993360230296",6,"320354953811471967529305919699358378842003861933967406551547519793989201176042327751416831802450640896");
      TestCommon.DoTestShiftLeft("-3423287",125,"-145610525376209833721768158718909438161321984");
      TestCommon.DoTestShiftRight("70745567529714182178",136,"0");
      TestCommon.DoTestAdd("6050891","3175702044243277284","3175702044249328175");
      TestCommon.DoTestSubtract("751627364748630693535","-685438090128","751627365434068783663");
      TestCommon.DoTestMultiply("69026380","7825510495297158","540166661142369841028040");
      TestCommon.DoTestDivide("29375547719183623953012","-863215396","-34030379735237");
      TestCommon.DoTestRemainder("2219994645351","-6882979476740684974","2219994645351");
      Assert.AreEqual(36,BigInteger.fromString("-100792883962849552789190930667314790").getDigitCount(),"-100792883962849552789190930667314790");
      TestCommon.DoTestDivideAndRemainder("631507828885","-78364",
                                          "-8058647",
                                          "15377"
                                         );
      TestCommon.DoTestPow("-85",9,"-231616946283203125");
      TestCommon.DoTestShiftLeft("-57006866200808070437",1,"-114013732401616140874");
      TestCommon.DoTestShiftRight("844034789995934",14,"51515795287");
      TestCommon.DoTestAdd("37811984","766949381","804761365");
      TestCommon.DoTestSubtract("2565386812","91339174","2474047638");
      TestCommon.DoTestMultiply("45059","435779953783513814450616","19635808937531348965330306344");
      TestCommon.DoTestDivide("-3442846326594069136","4967","-693144015823247");
      TestCommon.DoTestRemainder("15740592263754731096678","-352975329966","244730968352");
      Assert.AreEqual(25,BigInteger.fromString("-4804333180012161279394155").getDigitCount(),"-4804333180012161279394155");
      TestCommon.DoTestDivideAndRemainder("7","7704500957244489825969",
                                          "0",
                                          "7"
                                         );
      TestCommon.DoTestPow("51491969",2,"2651422871496961");
      TestCommon.DoTestShiftLeft("19468552677",96,"1542457655410872020342421812231087849472");
      TestCommon.DoTestShiftRight("3483371670219857",118,"0");
      TestCommon.DoTestAdd("829967662869076249270299","820068167","829967662869077069338466");
      TestCommon.DoTestSubtract("-5816619","5063431790","-5069248409");
      TestCommon.DoTestMultiply("-57521329090","-991","57003637128190");
      TestCommon.DoTestDivide("-37863918094","-5455875843095034650","0");
      TestCommon.DoTestRemainder("820066064336506985350188","246580357343369518456970","80324992306398429979278");
      Assert.AreEqual(31,BigInteger.fromString("3552462138337078525266861589638").getDigitCount(),"3552462138337078525266861589638");
      TestCommon.DoTestDivideAndRemainder("962891","7865301867998830540",
                                          "0",
                                          "962891"
                                         );
      TestCommon.DoTestPow("-7",0,"1");
      TestCommon.DoTestShiftLeft("-1859856389554819575986",175,"-89069425738865390986416748800313709628939508364424212341304952179075842048");
      TestCommon.DoTestShiftRight("-70767327522937599",79,"-1");
      TestCommon.DoTestAdd("-9298779257694211467581619","-83678","-9298779257694211467665297");
      TestCommon.DoTestSubtract("46","-3999542951505653957","3999542951505654003");
      TestCommon.DoTestMultiply("592373083724489","87454170993","51805496955692166307547577");
      TestCommon.DoTestDivide("380833886","-444107279171271357","0");
      TestCommon.DoTestRemainder("5","-714839756","5");
      Assert.AreEqual(9,BigInteger.fromString("-257403792").getDigitCount(),"-257403792");
      TestCommon.DoTestDivideAndRemainder("-748099975526882834456741","107717897",
                                          "-6944992395524420",
                                          "-99912001"
                                         );
      TestCommon.DoTestPow("1420711529715826",7,"11682649163945956285857495859344188461133037546802214199820445273723714745500419069832785978430720584475776");
      TestCommon.DoTestShiftLeft("849099",171,"2541485217292354226060965043762305424807593300599559421952");
      TestCommon.DoTestShiftRight("216",62,"0");
      TestCommon.DoTestAdd("-645","1881","1236");
      TestCommon.DoTestSubtract("-735625220005213681115076","-396391287250468007642372","-339233932754745673472704");
      TestCommon.DoTestMultiply("1434646246395897113","56807660733720002","81498897238162995365175702542154226");
      TestCommon.DoTestDivide("1","20","0");
      TestCommon.DoTestRemainder("-5524931926044999560","-6599141848","-4852192320");
      Assert.AreEqual(18,BigInteger.fromString("148565998051230864").getDigitCount(),"148565998051230864");
      TestCommon.DoTestDivideAndRemainder("620299","-34483",
                                          "-17",
                                          "34088"
                                         );
      TestCommon.DoTestPow("-522825965554673551",2,"273346990258176694430766178178949601");
      TestCommon.DoTestShiftLeft("31162330890585059905",33,"267682384084386773196351733760");
      TestCommon.DoTestShiftRight("8387993339547794194955",183,"0");
      TestCommon.DoTestAdd("-3714621390","6628","-3714614762");
      TestCommon.DoTestSubtract("124196396","1","124196395");
      TestCommon.DoTestMultiply("297716500","-368345","-109662384192500");
      TestCommon.DoTestDivide("-364379494595898837","-43869665237002","8305");
      TestCommon.DoTestRemainder("-333581","646435187905725934964603","-333581");
      Assert.AreEqual(41,BigInteger.fromString("-58605188558057171052020915830032882725807").getDigitCount(),"-58605188558057171052020915830032882725807");
      TestCommon.DoTestDivideAndRemainder("-1661968768726098245","2886578861923730347573751",
                                          "0",
                                          "-1661968768726098245"
                                         );
      TestCommon.DoTestPow("-71745680784747440556326",2,"5147442711266878117774919803064408920378618276");
      TestCommon.DoTestShiftLeft("341203299554072833350",17,"44722198879151434412851200");
      TestCommon.DoTestShiftRight("729565380536512930",117,"0");
      TestCommon.DoTestAdd("-911854564869","3164399307825547","3163487453260678");
      TestCommon.DoTestSubtract("1584194","-17132","1601326");
      TestCommon.DoTestMultiply("2","-3762","-7524");
      TestCommon.DoTestDivide("9415743084600564358","-318179972497460393555","0");
      TestCommon.DoTestRemainder("24545025060","-686055299619232051313","24545025060");
      Assert.AreEqual(12,BigInteger.fromString("157491520336").getDigitCount(),"157491520336");
      TestCommon.DoTestDivideAndRemainder("-4087","-43901437",
                                          "0",
                                          "-4087"
                                         );
      TestCommon.DoTestPow("833391770111077646924",1,"833391770111077646924");
      TestCommon.DoTestShiftLeft("4788037730930311563160283",102,"24278235614116875987603714041350242511922210570221125632");
      TestCommon.DoTestShiftRight("7066538939074577402586816",142,"0");
      TestCommon.DoTestAdd("-1270351532","7908040042026","7906769690494");
      TestCommon.DoTestSubtract("2","3","-1");
      TestCommon.DoTestMultiply("742683371276","7969916332531","5919124330631776949779556");
      TestCommon.DoTestDivide("-5","513251235288304844624029","0");
      TestCommon.DoTestRemainder("40043644916","67","2");
      Assert.AreEqual(19,BigInteger.fromString("-8398529585734166541").getDigitCount(),"-8398529585734166541");
      TestCommon.DoTestDivideAndRemainder("-6069297738768908925213","186",
                                          "-32630633004133918952",
                                          "-141"
                                         );
      TestCommon.DoTestPow("49337161518",4,"5925113030570194468834573988323450697576976");
      TestCommon.DoTestShiftLeft("36892790604930587958",84,"713610353918985630838287016066997593181257728");
      TestCommon.DoTestShiftRight("-6699133215312626793541280",1,"-3349566607656313396770640");
      TestCommon.DoTestAdd("-29888210551","85171","-29888125380");
      TestCommon.DoTestSubtract("-95464116691727463","-9593541","-95464116682133922");
      TestCommon.DoTestMultiply("-852269067272301737","1416305096787449360683","-1207073023812046501916222473474520406371");
      TestCommon.DoTestDivide("-160352600991403582422080","90922770544064","-1763613229");
      TestCommon.DoTestRemainder("-1444734435806253811328","-6128","-4096");
      Assert.AreEqual(3,BigInteger.fromString("238").getDigitCount(),"238");
      TestCommon.DoTestDivideAndRemainder("-1327","-302660659458139668037",
                                          "0",
                                          "-1327"
                                         );
      TestCommon.DoTestPow("8029339",7,"2151585258181269805545466780648804445542777097779");
      TestCommon.DoTestShiftLeft("171060576349273",171,"512010879830487894350806359565653259261291441649471162898138005504");
      TestCommon.DoTestShiftRight("-32386",128,"-1");
      TestCommon.DoTestAdd("6705780031","-13579484428943573498","-13579484422237793467");
      TestCommon.DoTestSubtract("6127404765917960364","-6140747874","6127404772058708238");
      TestCommon.DoTestMultiply("-18","-56","1008");
      TestCommon.DoTestDivide("-509105765","-26280839059191263","0");
      TestCommon.DoTestRemainder("-113517932601874635","893588928","-820079115");
      Assert.AreEqual(20,BigInteger.fromString("50333754117099065580").getDigitCount(),"50333754117099065580");
      TestCommon.DoTestDivideAndRemainder("878293042931","-9985284671760",
                                          "0",
                                          "878293042931"
                                         );
      TestCommon.DoTestPow("-259178810160006111547970",3,"-17409988141825190999249878809839161601914679228439563802109025819573000");
      TestCommon.DoTestShiftLeft("-63615445740515664666",124,"-1352950903082075205338578437346115354894387391874367225856");
      TestCommon.DoTestShiftRight("-908947630",72,"-1");
      TestCommon.DoTestAdd("-1","-425193","-425194");
      TestCommon.DoTestSubtract("449470025824687541","-58672517155411728563638","58672966625437553251179");
      TestCommon.DoTestMultiply("-434452541","320462710859393844","-139225839028611949245557604");
      TestCommon.DoTestDivide("52399711","-2046115336456482","0");
      TestCommon.DoTestRemainder("2541136460","367533412420011159939","2541136460");
      Assert.AreEqual(30,BigInteger.fromString("-405286581494821113923671802246").getDigitCount(),"-405286581494821113923671802246");
      TestCommon.DoTestDivideAndRemainder("38544","209415200378756797",
                                          "0",
                                          "38544"
                                         );
      TestCommon.DoTestPow("0",4,"0");
      TestCommon.DoTestShiftLeft("53775475750",111,"139609116901470401834235856743719644430336000");
      TestCommon.DoTestShiftRight("-23099",137,"-1");
      TestCommon.DoTestAdd("485139","4","485143");
      TestCommon.DoTestSubtract("2731649425950","-5","2731649425955");
      TestCommon.DoTestMultiply("44623036","-86006651447197100","-3837877903767728292395600");
      TestCommon.DoTestDivide("1","-6623634196183253922","0");
      TestCommon.DoTestRemainder("3756","-3252","504");
      Assert.AreEqual(26,BigInteger.fromString("-12982729486842456009329573").getDigitCount(),"-12982729486842456009329573");
      TestCommon.DoTestDivideAndRemainder("-880778397845576190027646","-941568249569602587208",
                                          "935",
                                          "-412084497997770988166"
                                         );
      TestCommon.DoTestPow("162258078",7,"2961040115722225424935172344536037450933311685001368278912");
      TestCommon.DoTestShiftLeft("-8790314316205",89,"-5440941024966829174001645039221955624960");
      TestCommon.DoTestShiftRight("37255030879",39,"0");
      TestCommon.DoTestAdd("724","-109098905060","-109098904336");
      TestCommon.DoTestSubtract("-6182550426020541626684394","-6609","-6182550426020541626677785");
      TestCommon.DoTestMultiply("9664205","6702212688008456836939","64771557370514768605830068495");
      TestCommon.DoTestDivide("52412","45457145928171","0");
      TestCommon.DoTestRemainder("-823520","-5911873500477557","-823520");
      Assert.AreEqual(11,BigInteger.fromString("50314525256").getDigitCount(),"50314525256");
      TestCommon.DoTestDivideAndRemainder("701033662717998310096","27459387940800171",
                                          "25529",
                                          "22947977310744637"
                                         );
      TestCommon.DoTestPow("53483853200416751866871",4,"8182589277158340126678110269020031369506982814275980867189485988104172813437570201697470881");
      TestCommon.DoTestShiftLeft("6446",164,"150733432867760003371855238907026565515234258752372736");
      TestCommon.DoTestShiftRight("9683558887991333",157,"0");
      TestCommon.DoTestAdd("3383956","-4924010","-1540054");
      TestCommon.DoTestSubtract("-76691282914461469696","620524247129058961718534","-620600938411973423188230");
      TestCommon.DoTestMultiply("-1940","-1324648","2569817120");
      TestCommon.DoTestDivide("-31315411584","-6397385978","4");
      TestCommon.DoTestRemainder("-39209391","-92691796681","-39209391");
      Assert.AreEqual(24,BigInteger.fromString("827800322326974070373376").getDigitCount(),"827800322326974070373376");
      TestCommon.DoTestDivideAndRemainder("-467199","4",
                                          "-116799",
                                          "-3"
                                         );
      TestCommon.DoTestPow("-96118530196",3,"-888017170753607782458677552969536");
      TestCommon.DoTestShiftLeft("-581274931005037",11,"-1190451058698315776");
      TestCommon.DoTestShiftRight("-21900648158205032667863",105,"-1");
      TestCommon.DoTestAdd("1738","562772873","562774611");
      TestCommon.DoTestSubtract("93579761","7987047828934326163992","-7987047828934232584231");
      TestCommon.DoTestMultiply("49","-230543204","-11296616996");
      TestCommon.DoTestDivide("-38571443","55104446908512911334636","0");
      TestCommon.DoTestRemainder("-12060887857872925","-19","-1");
      Assert.AreEqual(15,BigInteger.fromString("-577765352701574").getDigitCount(),"-577765352701574");
      TestCommon.DoTestDivideAndRemainder("-2272025975312565498031539","521792650859009544",
                                          "-4354269",
                                          "-411249356869888203"
                                         );
      TestCommon.DoTestPow("196205882004563785219733",1,"196205882004563785219733");
      TestCommon.DoTestShiftLeft("812865",186,"79725567220860847798365296398370308770703768099441522098831360");
      TestCommon.DoTestShiftRight("71",117,"0");
      TestCommon.DoTestAdd("3","-755844973144306343606197","-755844973144306343606194");
      TestCommon.DoTestSubtract("2081","8621027740871","-8621027738790");
      TestCommon.DoTestMultiply("-73703717115415693","90709204690331164764","-6685605562260506524859649568734241452");
      TestCommon.DoTestDivide("-16741","874236345152100399808","0");
      TestCommon.DoTestRemainder("46163339317597340","-82972","8892");
      Assert.AreEqual(32,BigInteger.fromString("87827732489391124791173330073576").getDigitCount(),"87827732489391124791173330073576");
      TestCommon.DoTestDivideAndRemainder("-6266824","-6163212299724701",
                                          "0",
                                          "-6266824"
                                         );
      TestCommon.DoTestPow("-579232708566438",1,"-579232708566438");
      TestCommon.DoTestShiftLeft("1",85,"38685626227668133590597632");
      TestCommon.DoTestShiftRight("-908199",3,"-113525");
      TestCommon.DoTestAdd("-34","481595941336841556651960","481595941336841556651926");
      TestCommon.DoTestSubtract("230989304177905477012","-97896556739018553","231087200734644495565");
      TestCommon.DoTestMultiply("-4546225878217590696983","-8075112859865","36711287053045920021864411757287295");
      TestCommon.DoTestDivide("117133218092257","38619885696842025893327","0");
      TestCommon.DoTestRemainder("16798109","9779758916055075","16798109");
      Assert.AreEqual(38,BigInteger.fromString("54075018752706632524711127118736269660").getDigitCount(),"54075018752706632524711127118736269660");
      TestCommon.DoTestDivideAndRemainder("-227","-667",
                                          "0",
                                          "-227"
                                         );
      TestCommon.DoTestPow("60912816908152306230",7,"3111435390019359040499066178774827424967808391752143555511089226930028435333207364069427166818060891314084065720981005396591229292470000000");
      TestCommon.DoTestShiftLeft("-81364993913223272635572",35,"-2795679903172264143326987730026496");
      TestCommon.DoTestShiftRight("281914776870108",108,"0");
      TestCommon.DoTestAdd("-3312157715","47898969548","44586811833");
      TestCommon.DoTestSubtract("-69497676801529","3237804257213530","-3307301934015059");
      TestCommon.DoTestMultiply("4872436703","4719930844823664859603769","22997564283940622224904746112733607");
      TestCommon.DoTestDivide("-43277226672313128749429","1198","-36124563165536835350");
      TestCommon.DoTestRemainder("438061160699","-541374","267989");
      Assert.AreEqual(36,BigInteger.fromString("-163349886693908904901738345332203649").getDigitCount(),"-163349886693908904901738345332203649");
      TestCommon.DoTestDivideAndRemainder("56700","8673476",
                                          "0",
                                          "56700"
                                         );
      TestCommon.DoTestPow("4300440349267",2,"18493787197603676947437289");
      TestCommon.DoTestShiftLeft("266784481",8,"68296827136");
      TestCommon.DoTestShiftRight("31257688",184,"0");
      TestCommon.DoTestAdd("887519644932553218","-9693720","887519644922859498");
      TestCommon.DoTestSubtract("-5029676071468980685668808","149297053087370614284176","-5178973124556351299952984");
      TestCommon.DoTestMultiply("-832701821912154637493634","3134451537","-2610063505555253382473598919015458");
      TestCommon.DoTestDivide("-51821471313005687909","-18408235581364446554009","0");
      TestCommon.DoTestRemainder("-8304215","2988","-563");
      Assert.AreEqual(26,BigInteger.fromString("28316137611069961648583992").getDigitCount(),"28316137611069961648583992");
      TestCommon.DoTestDivideAndRemainder("-334277380481032167257","-320157506765261",
                                          "1044102",
                                          "-287352409626635"
                                         );
      TestCommon.DoTestPow("-22406669694276149",7,"-2835575300055759928426723707800860311053818452355198956637683922730817480287723870611746003164427164061876736535549");
      TestCommon.DoTestShiftLeft("-638791724794603961",23,"-5358573372945813144076288");
      TestCommon.DoTestShiftRight("-653952589830",27,"-4873");
      TestCommon.DoTestAdd("-9678877929","-37157433003","-46836310932");
      TestCommon.DoTestSubtract("3209","-6467651495","6467654704");
      TestCommon.DoTestMultiply("38485128","791916437690","30477005469803674320");
      TestCommon.DoTestDivide("83","-11927648","0");
      TestCommon.DoTestRemainder("71638","5076669367758486823","71638");
      Assert.AreEqual(16,BigInteger.fromString("1211935033300000").getDigitCount(),"1211935033300000");
      TestCommon.DoTestDivideAndRemainder("-845532391940830","31727248376855",
                                          "-26",
                                          "-20623934142600"
                                         );
      TestCommon.DoTestPow("-98287393977994",1,"-98287393977994");
      TestCommon.DoTestShiftLeft("327509181965",153,"3739493794396500943404063490715529067991675647728843489280");
      TestCommon.DoTestShiftRight("7360290536303412543068362",18,"28077280183042192623");
      TestCommon.DoTestAdd("-2324369759385439625868436","-73793728","-2324369759385439699662164");
      TestCommon.DoTestSubtract("-30652699617025101","1235445","-30652699618260546");
      TestCommon.DoTestMultiply("280053556861445","-272416899311","-76291321601211675742964395");
      TestCommon.DoTestDivide("568545506","661821880573549416946272","0");
      TestCommon.DoTestRemainder("-5476166","43750671","-5476166");
      Assert.AreEqual(23,BigInteger.fromString("-68889595024952565778590").getDigitCount(),"-68889595024952565778590");
      TestCommon.DoTestDivideAndRemainder("3812573036","-153885983986283",
                                          "0",
                                          "3812573036"
                                         );
      TestCommon.DoTestPow("569559212420011787082",2,"324397696452504109138681300055815302074724");
      TestCommon.DoTestShiftLeft("898",120,"1193646740214854453867618740131749429248");
      TestCommon.DoTestShiftRight("-99001",95,"-1");
      TestCommon.DoTestAdd("-5215950230212856654227","4301588729","-5215950230208555065498");
      TestCommon.DoTestSubtract("51","-10548748461264025","10548748461264076");
      TestCommon.DoTestMultiply("-3760380644947391","4","-15041522579789564");
      TestCommon.DoTestDivide("-14003113642005445935","340472850418814711","-41");
      TestCommon.DoTestRemainder("7839431","-44303801645","7839431");
      Assert.AreEqual(27,BigInteger.fromString("127900433076656872689415017").getDigitCount(),"127900433076656872689415017");
      TestCommon.DoTestDivideAndRemainder("-47299372711938832421183","997224111",
                                          "-47431036003038",
                                          "-269571965"
                                         );
      TestCommon.DoTestPow("-4756338793037222458113",2,"22622758714150782091988744466605974039520769");
      TestCommon.DoTestShiftLeft("-669",133,"-7284764911043450625823923595899293870850048");
      TestCommon.DoTestShiftRight("-853319021",46,"-1");
      TestCommon.DoTestAdd("1148897495380221540","928845857798","1148898424226079338");
      TestCommon.DoTestSubtract("67334241925988256924","2519019989057079937414266","-2518952654815153949157342");
      TestCommon.DoTestMultiply("-70097848246703754601683","-2029278392041","142248048775605026216580732672405003");
      TestCommon.DoTestDivide("130","876023519","0");
      TestCommon.DoTestRemainder("-616793928557","-5639376732","-2101864769");
      Assert.AreEqual(33,BigInteger.fromString("-402716253684394463870919675219228").getDigitCount(),"-402716253684394463870919675219228");
      TestCommon.DoTestDivideAndRemainder("-974","-93946656157",
                                          "0",
                                          "-974"
                                         );
      TestCommon.DoTestPow("3322992982593567466415",8,"14867412567965250052046884629301623049625128359603007400611720367509300090847310355177368536385791384867951239050988710053471811263065643061489950713462160443346918062890625");
      TestCommon.DoTestShiftLeft("43947028450632659396766",130,"59817595441292417566042068027683378131739649841457950762205184");
      TestCommon.DoTestShiftRight("850939368",35,"0");
      TestCommon.DoTestAdd("6607440817235","590009586076839379234","590009592684280196469");
      TestCommon.DoTestSubtract("-696133","51454470017183207282669","-51454470017183207978802");
      TestCommon.DoTestMultiply("-7503107616838","16169222302","-121319415012483060321076");
      TestCommon.DoTestDivide("-783238182995970526074772","-608133036116","1287938882581");
      TestCommon.DoTestRemainder("-932107320646378272022429","967544423357","-55162685694");
      Assert.AreEqual(34,BigInteger.fromString("-2596601421376973482940265153497760").getDigitCount(),"-2596601421376973482940265153497760");
      TestCommon.DoTestDivideAndRemainder("-978083320493","89",
                                          "-10989700230",
                                          "-23"
                                         );
      TestCommon.DoTestPow("-7726465846946677",7,"-1643865287006115564785641589601001694285311339996148582064968902902110772190750618673047341965776540486520318653");
      TestCommon.DoTestShiftLeft("-911567045",141,"-2541078050240312309892291433468821402762289705123840");
      TestCommon.DoTestShiftRight("-786111780559",85,"-1");
      TestCommon.DoTestAdd("-11232367613536889939865","22552453023263240","-11232345061083866676625");
      TestCommon.DoTestSubtract("36052893","-2145579202908882799","2145579202944935692");
      TestCommon.DoTestMultiply("6209388","3560177157","22106521316549916");
      TestCommon.DoTestDivide("37290061","-81050732484938031732","0");
      TestCommon.DoTestRemainder("27445656162805","-8389985446450142593","27445656162805");
      Assert.AreEqual(13,BigInteger.fromString("3948660592443").getDigitCount(),"3948660592443");
      TestCommon.DoTestDivideAndRemainder("-607986293989548","7082009853054743474987667",
                                          "0",
                                          "-607986293989548"
                                         );
      TestCommon.DoTestPow("1563731189747",2,"2445255233787568117924009");
      TestCommon.DoTestShiftLeft("1",12,"4096");
      TestCommon.DoTestShiftRight("4785814132715",38,"17");
      TestCommon.DoTestAdd("86515","3137911470794","3137911557309");
      TestCommon.DoTestSubtract("481472177","288","481471889");
      TestCommon.DoTestMultiply("-801804114066596907451698","-885409234582332276841031","709924766920670608138483926727784720075657020638");
      TestCommon.DoTestDivide("-37773","14308653199527458","0");
      TestCommon.DoTestRemainder("-24712595859481312058636","9709160129232677008081027","-24712595859481312058636");
      Assert.AreEqual(18,BigInteger.fromString("255501446306086501").getDigitCount(),"255501446306086501");
      TestCommon.DoTestDivideAndRemainder("95","413740555",
                                          "0",
                                          "95"
                                         );
      TestCommon.DoTestPow("4792",8,"278057411212737118421087420416");
      TestCommon.DoTestShiftLeft("-6",27,"-805306368");
      TestCommon.DoTestShiftRight("-7",55,"-1");
      TestCommon.DoTestAdd("111754853997270474066","5","111754853997270474071");
      TestCommon.DoTestSubtract("-96","712955583","-712955679");
      TestCommon.DoTestMultiply("4184534333947752902550","46240286951474814","193494068360042630340794207971721375700");
      TestCommon.DoTestDivide("21927812732758887951","-30263189663365113","-724");
      TestCommon.DoTestRemainder("27749627","944947472470513801920","27749627");
      Assert.AreEqual(40,BigInteger.fromString("-4393817795437420944347837538655923394784").getDigitCount(),"-4393817795437420944347837538655923394784");
      TestCommon.DoTestDivideAndRemainder("-978854","561",
                                          "-1744",
                                          "-470"
                                         );
      TestCommon.DoTestPow("6455",0,"1");
      TestCommon.DoTestShiftLeft("-9891378318877",4,"-158262053102032");
      TestCommon.DoTestShiftRight("-3563952352002790",122,"-1");
      TestCommon.DoTestAdd("-649","-698392693156898554382047","-698392693156898554382696");
      TestCommon.DoTestSubtract("-39355406152332014494","734511201","-39355406153066525695");
      TestCommon.DoTestMultiply("-675570492633123","983392294417686996","-664350816791373937008331275968508");
      TestCommon.DoTestDivide("914724289153057571","-3015873111","-303303307");
      TestCommon.DoTestRemainder("95730664483","-8417556463855131148878204","95730664483");
      Assert.AreEqual(30,BigInteger.fromString("164260968973144573925656318008").getDigitCount(),"164260968973144573925656318008");
      TestCommon.DoTestDivideAndRemainder("-789543921","-28966020148300907089",
                                          "0",
                                          "-789543921"
                                         );
      TestCommon.DoTestPow("-3760",3,"-53157376000");
      TestCommon.DoTestShiftLeft("-5459159894358181220",64,"-100703725428684641284139145827471851520");
      TestCommon.DoTestShiftRight("-95022563826437",160,"-1");
      TestCommon.DoTestAdd("-344004024191436141759","477894","-344004024191435663865");
      TestCommon.DoTestSubtract("-418108469815282981679950","-6753080","-418108469815282974926870");
      TestCommon.DoTestMultiply("-2186952388","-4","8747809552");
      TestCommon.DoTestDivide("2162101079365324564410","55","39310928715733173898");
      TestCommon.DoTestRemainder("621878000229","-78028097651","75681316672");
      Assert.AreEqual(45,BigInteger.fromString("943875269004312845000624106540561801672436520").getDigitCount(),"943875269004312845000624106540561801672436520");
      TestCommon.DoTestDivideAndRemainder("-687057619659261","-845",
                                          "813085940425",
                                          "-136"
                                         );
      TestCommon.DoTestPow("-6732230208141751550151602",6,"93100872145807526349250431887586548937218902359404559127246416802462814481525261149528087109465876776265346075784555849975771081582187411524803507264");
      TestCommon.DoTestShiftLeft("611",12,"2502656");
      TestCommon.DoTestShiftRight("-383611319453078403802",18,"-1463361051380457");
      TestCommon.DoTestAdd("-94850884634851","-3172119","-94850887806970");
      TestCommon.DoTestSubtract("178165753674585","21124252081829482210898","-21124251903663728536313");
      TestCommon.DoTestMultiply("48240392254491","-3445924368111174848","-166232743196992112613041414242368");
      TestCommon.DoTestDivide("89","0",null);
      TestCommon.DoTestRemainder("-7110215548","6440864712","-669350836");
      Assert.AreEqual(49,BigInteger.fromString("1500296060277594219277541334047112410187334281946").getDigitCount(),"1500296060277594219277541334047112410187334281946");
      TestCommon.DoTestDivideAndRemainder("129212","609636519940480793510",
                                          "0",
                                          "129212"
                                         );
      TestCommon.DoTestPow("9578818711458417003232752",8,"70875417651875509027736512155176993357398910565682429328917364133226073307456558712670381750369212181100968521104853864986973742886563071863058048388812165422142870902436654719967231427639552042336256");
      TestCommon.DoTestShiftLeft("-8105",79,"-4899171883988284730496778240");
      TestCommon.DoTestShiftRight("90546187",19,"172");
      TestCommon.DoTestAdd("-737098155123","751561840443481697","751561103345326574");
      TestCommon.DoTestSubtract("619","135017231326841133903","-135017231326841133284");
      TestCommon.DoTestMultiply("4712971","-94304000983614918","-444452021819748583701378");
      TestCommon.DoTestDivide("78373755712","-2318303153482892234160","0");
      TestCommon.DoTestRemainder("-83104012126030","-656440504","-613641142");
      Assert.AreEqual(6,BigInteger.fromString("695612").getDigitCount(),"695612");
      TestCommon.DoTestDivideAndRemainder("-960573418","985383022562705",
                                          "0",
                                          "-960573418"
                                         );
      TestCommon.DoTestPow("-64640021770973632553068",8,"304797887252184768185293130980358331186464543462048214988376502958739722667516560353345402512772318787819753332621963989065590132802254559537522632892337712904373704974145575022821376");
      TestCommon.DoTestShiftLeft("52447146006758187412854",193,"658432142430200884827162867353732142263875085884635099269146618994719168678330368");
      TestCommon.DoTestShiftRight("-5202271579444613544",65,"-1");
      TestCommon.DoTestAdd("15465661174035","-29982157363160191363","-29982141897499017328");
      TestCommon.DoTestSubtract("98209543417703","776371","98209542641332");
      TestCommon.DoTestMultiply("36756408685979386","-747445993533996888829","-27473430409033495229140522156827678994");
      TestCommon.DoTestDivide("2","-392","0");
      TestCommon.DoTestRemainder("-3831","142259861279921","-3831");
      Assert.AreEqual(23,BigInteger.fromString("-49702138341630389722585").getDigitCount(),"-49702138341630389722585");
      TestCommon.DoTestDivideAndRemainder("1539","-24348294709151798311802",
                                          "0",
                                          "1539"
                                         );
      TestCommon.DoTestPow("-27075517499134618557",3,"-19848619135582322790885662604337537924760225759979476454693");
      TestCommon.DoTestShiftLeft("-7971950808953087777485935",53,"-71804949385234100524195598145907347947520");
      TestCommon.DoTestShiftRight("73328793939806274",33,"8536595");
      TestCommon.DoTestAdd("69991944669215294143","-2","69991944669215294141");
      TestCommon.DoTestSubtract("425289","24713628195992639","-24713628195567350");
      TestCommon.DoTestMultiply("-73606848073811244697","387249241952887495","-28504196119124761562078097039156364015");
      TestCommon.DoTestDivide("-99651177093","-29225403317973323797","0");
      TestCommon.DoTestRemainder("545808578","-561292635519","545808578");
      Assert.AreEqual(16,BigInteger.fromString("1139495290222374").getDigitCount(),"1139495290222374");
      TestCommon.DoTestDivideAndRemainder("98850278485307943169","941",
                                          "105048117412654562",
                                          "327"
                                         );
      TestCommon.DoTestPow("-7425947239051372975",7,"-1245268535570331744049193481465681905578210140516008399992995168561249313914013769806723334970145729852847187793612559387445068359375");
      TestCommon.DoTestShiftLeft("-379018789634007651024",192,"-2379139502155788716329819391458873160817681276429942060030206809115258995605504");
      TestCommon.DoTestShiftRight("-73221480056324",77,"-1");
      TestCommon.DoTestAdd("96313918593732973969","418624197753272591247","514938116347005565216");
      TestCommon.DoTestSubtract("-57738384","-25846725197829214810","25846725197771476426");
      TestCommon.DoTestMultiply("41471282","594039991","24635599986038462");
      TestCommon.DoTestDivide("7517507801479108248","196597689399526052845","0");
      TestCommon.DoTestRemainder("-337457","6591605991901242773","-337457");
      Assert.AreEqual(28,BigInteger.fromString("3807038240935871802949892304").getDigitCount(),"3807038240935871802949892304");
      TestCommon.DoTestDivideAndRemainder("8593","93",
                                          "92",
                                          "37"
                                         );
      TestCommon.DoTestPow("27408293",8,"318460744973548017283554935645820162598708805066993581989601");
      TestCommon.DoTestShiftLeft("-1",157,"-182687704666362864775460604089535377456991567872");
      TestCommon.DoTestShiftRight("39067727967706954763819",10,"38152078093463823011");
      TestCommon.DoTestAdd("73388149","697554326590064194","697554326663452343");
      TestCommon.DoTestSubtract("5256976970921901100792465","-894388979760951581","5256977865310880861744046");
      TestCommon.DoTestMultiply("51335226326","49236960328617345212","2527590502073854751107292451112");
      TestCommon.DoTestDivide("383892","677861766626","0");
      TestCommon.DoTestRemainder("6085586377242877203842152","-942286790770248579","519822728482109188");
      Assert.AreEqual(32,BigInteger.fromString("-20800209367072998490338415044318").getDigitCount(),"-20800209367072998490338415044318");
      TestCommon.DoTestDivideAndRemainder("-9642608","-233925221453184663",
                                          "0",
                                          "-9642608"
                                         );
      TestCommon.DoTestPow("79972029598783970746",1,"79972029598783970746");
      TestCommon.DoTestShiftLeft("-3305",182,"-20259591050247050707497347698927087407439731195267220766720");
      TestCommon.DoTestShiftRight("602291194699922354",167,"0");
      TestCommon.DoTestAdd("4460573348102397144","58684502130696053312","63145075478798450456");
      TestCommon.DoTestSubtract("4779228611323694522356586","5","4779228611323694522356581");
      TestCommon.DoTestMultiply("-542","-7245088163","3926837784346");
      TestCommon.DoTestDivide("-62356070239984232338","-87053171867709379287","0");
      TestCommon.DoTestRemainder("-42","41657666666","-42");
      Assert.AreEqual(42,BigInteger.fromString("125128851442386493276790147190368815879176").getDigitCount(),"125128851442386493276790147190368815879176");
      TestCommon.DoTestDivideAndRemainder("-211","63758070",
                                          "0",
                                          "-211"
                                         );
      TestCommon.DoTestPow("737780670",3,"401589008189795652626763000");
      TestCommon.DoTestShiftLeft("-3390638",107,"-550162469869650340023293281647317745664");
      TestCommon.DoTestShiftRight("4180",82,"0");
      TestCommon.DoTestAdd("9271771339215811","5453255737638556147006607","5453255746910327486222418");
      TestCommon.DoTestSubtract("2499","-193310364079952628252820","193310364079952628255319");
      TestCommon.DoTestMultiply("8","-73","-584");
      TestCommon.DoTestDivide("12909626","4863803345106","0");
      TestCommon.DoTestRemainder("-3043869186","-17142242831517533608","-3043869186");
      Assert.AreEqual(34,BigInteger.fromString("-4246357881821744425201884762134280").getDigitCount(),"-4246357881821744425201884762134280");
      TestCommon.DoTestDivideAndRemainder("-9973305564823759","-944",
                                          "10564942335618",
                                          "-367"
                                         );
      TestCommon.DoTestPow("701629469",3,"345400899611882055039568709");
      TestCommon.DoTestShiftLeft("323053241067873477307011",64,"5959280460161458207480752357102531983179776");
      TestCommon.DoTestShiftRight("-955808245016071",41,"-435");
      TestCommon.DoTestAdd("388166345057402","-2428454675","388163916602727");
      TestCommon.DoTestSubtract("-6075074484429077","-4144632178408","-6070929852250669");
      TestCommon.DoTestMultiply("15223104","-33719916239","-513321791777585856");
      TestCommon.DoTestDivide("680294100013693473543114","4936","137822953811526230458");
      TestCommon.DoTestRemainder("-3423","-346644083261837","-3423");
      Assert.AreEqual(41,BigInteger.fromString("-17650291046888465379482562747165285295720").getDigitCount(),"-17650291046888465379482562747165285295720");
      TestCommon.DoTestDivideAndRemainder("54","31822",
                                          "0",
                                          "54"
                                         );
      TestCommon.DoTestPow("-61028",1,"-61028");
      TestCommon.DoTestShiftLeft("49273153018184673",184,"1208174196556329991735847802231395134576027532599072827494348472522375168");
      TestCommon.DoTestShiftRight("1550602355441321",26,"23105775");
      TestCommon.DoTestAdd("-59180382505061022232238","450458","-59180382505061021781780");
      TestCommon.DoTestSubtract("61631254125365264732","11044530181669770453","50586723943695494279");
      TestCommon.DoTestMultiply("50096290795","26855383500866433","1345355101270649962022384235");
      TestCommon.DoTestDivide("-16700504132563851626","98","-170413307475141343");
      TestCommon.DoTestRemainder("3489271168024028684647","6","1");
      Assert.AreEqual(8,BigInteger.fromString("-66563444").getDigitCount(),"-66563444");
      TestCommon.DoTestDivideAndRemainder("-1789577203139401530973676","5689351132699",
                                          "-314548559475",
                                          "-1471512200651"
                                         );
      TestCommon.DoTestPow("439",9,"605592770801153705930359");
      TestCommon.DoTestShiftLeft("20",3,"160");
      TestCommon.DoTestShiftRight("4395519681",188,"0");
      TestCommon.DoTestAdd("2555160208567370617871","310448958247349531","2555470657525617967402");
      TestCommon.DoTestSubtract("3869165878361897081","32296483627258519788494","-32292614461380157891413");
      TestCommon.DoTestMultiply("-565972984","488786920457369414817","-276640191911428012494311303928");
      TestCommon.DoTestDivide("6","624673368","0");
      TestCommon.DoTestRemainder("-46622902428010289","3551432878917860765398","-46622902428010289");
      Assert.AreEqual(28,BigInteger.fromString("-5805985610529633003771333774").getDigitCount(),"-5805985610529633003771333774");
      TestCommon.DoTestDivideAndRemainder("-1525817894908152611","321698",
                                          "-4743013307226",
                                          "-162863"
                                         );
      TestCommon.DoTestPow("358627214",7,"762961628809546595268067739052801188382025722165455107627904");
      TestCommon.DoTestShiftLeft("-719882",129,"-489926301727558045909882078294392327198736384");
      TestCommon.DoTestShiftRight("601600005901993839120",140,"0");
      TestCommon.DoTestAdd("87360138775527","-794142919235997","-706782780460470");
      TestCommon.DoTestSubtract("-40312001094279867974","-468302725776863","-40311532791554091111");
      TestCommon.DoTestMultiply("2921","-122901014546","-358993863488866");
      TestCommon.DoTestDivide("-1336867131","-83475854516","0");
      TestCommon.DoTestRemainder("-599664667699946","-37039071369","-2102235836");
      Assert.AreEqual(34,BigInteger.fromString("-3117837444476850494127454582204320").getDigitCount(),"-3117837444476850494127454582204320");
      TestCommon.DoTestDivideAndRemainder("956916506271798927810171","8",
                                          "119614563283974865976271",
                                          "3"
                                         );
      TestCommon.DoTestPow("-7728968189416696",7,"-1647595658684611636649948625417447420435027477975746761496376051495809304908763963590812115537690462810345046016");
      TestCommon.DoTestShiftLeft("387425772",111,"1005814809435515191435178382945630925357056");
      TestCommon.DoTestShiftRight("632936050049741417211788",153,"0");
      TestCommon.DoTestAdd("-1223318748923650","-468470704","-1223319217394354");
      TestCommon.DoTestSubtract("-8625554711524380","-1715427560048260","-6910127151476120");
      TestCommon.DoTestMultiply("-511762016349507","-2218157331671","1135168668636393123256336197");
      TestCommon.DoTestDivide("-190694","4200487","0");
      TestCommon.DoTestRemainder("7308692355788789","-7685366053092071322319711","7308692355788789");
      Assert.AreEqual(31,BigInteger.fromString("2520945737027238943010700244467").getDigitCount(),"2520945737027238943010700244467");
      TestCommon.DoTestDivideAndRemainder("47250","26331531220650463606314",
                                          "0",
                                          "47250"
                                         );
      TestCommon.DoTestPow("817072530934651211723974",7,"243122006723684799757872188892653769514304016498650763563481890090350946032838002275868452659694152097022086917209158682595164649300828305980180460795859661092576957824");
      TestCommon.DoTestShiftLeft("-93838055739405638",5,"-3002817783660980416");
      TestCommon.DoTestShiftRight("409115579",170,"0");
      TestCommon.DoTestAdd("6168207526427660076","-7250545","6168207526420409531");
      TestCommon.DoTestSubtract("-8182288520825331423435","-986157285691330629958893","977974997170505298535458");
      TestCommon.DoTestMultiply("32437415294577","-37675886385","-1222108373261544358634145");
      TestCommon.DoTestDivide("-74412070669141454","-7933660238045831","9");
      TestCommon.DoTestRemainder("8754","26087647818467809426","8754");
      Assert.AreEqual(26,BigInteger.fromString("-24336216322629241862461734").getDigitCount(),"-24336216322629241862461734");
      TestCommon.DoTestDivideAndRemainder("-8332179149124952889165","-42295299",
                                          "197000124035651",
                                          "-7184516"
                                         );
      TestCommon.DoTestPow("2223747457733531752784",6,"120924078781242121837597615266451902514742414565265696883253078110124109332617881234079075066296317860394398218118242587866300416");
      TestCommon.DoTestShiftLeft("7025",166,"657091136143973952024376700789240845637307271322009600");
      TestCommon.DoTestShiftRight("-4139776638",137,"-1");
      TestCommon.DoTestAdd("-381565203925781","648826339512162738465163","648826339130597534539382");
      TestCommon.DoTestSubtract("62958611","-1763417","64722028");
      TestCommon.DoTestMultiply("20480271628579883","-436","-8929398430060828988");
      TestCommon.DoTestDivide("21047627673063392542675","-236615559878571","-88952846");
      TestCommon.DoTestRemainder("4","-76","4");
      Assert.AreEqual(37,BigInteger.fromString("3047637436585553340910318390677316785").getDigitCount(),"3047637436585553340910318390677316785");
      TestCommon.DoTestDivideAndRemainder("622404","-3936129053949699121282",
                                          "0",
                                          "622404"
                                         );
      TestCommon.DoTestPow("23782587128",9,"2434063299765404076099211550110151991409064319517053858435321508540541595673463425922716663808");
      TestCommon.DoTestShiftLeft("-905158116964693521399",175,"-43348461813342421485725365010607763665885337267124171292040178668123717632");
      TestCommon.DoTestShiftRight("97789836267857803",53,"10");
      TestCommon.DoTestAdd("81049190763415277270","-29139","81049190763415248131");
      TestCommon.DoTestSubtract("136099403976550294","-20416","136099403976570710");
      TestCommon.DoTestMultiply("-930","3531","-3283830");
      TestCommon.DoTestDivide("-643","-49","13");
      TestCommon.DoTestRemainder("-5995269","-505678803005867582287","-5995269");
      Assert.AreEqual(17,BigInteger.fromString("-21867599647385180").getDigitCount(),"-21867599647385180");
      TestCommon.DoTestDivideAndRemainder("38066","-95289847728793",
                                          "0",
                                          "38066"
                                         );
      TestCommon.DoTestPow("-77987864740487135950",4,"36992026128497217783121686573641816974749193554136635336620701307718672006250000");
      TestCommon.DoTestShiftLeft("-6331057",40,"-6961070787612639232");
      TestCommon.DoTestShiftRight("-370057333295682568093",112,"-1");
      TestCommon.DoTestAdd("-862125836125830320614532","-1689","-862125836125830320616221");
      TestCommon.DoTestSubtract("15704248233159","-807131159","15705055364318");
      TestCommon.DoTestMultiply("-6976","70789896529429812","-493830318189302368512");
      TestCommon.DoTestDivide("-2358519388","-53667303073572690228","0");
      TestCommon.DoTestRemainder("327152827","3654451137503","327152827");
      Assert.AreEqual(43,BigInteger.fromString("7055286495522538800069469036313606225182200").getDigitCount(),"7055286495522538800069469036313606225182200");
      TestCommon.DoTestDivideAndRemainder("69421251121385108","-102907313115739",
                                          "-674",
                                          "61722081377022"
                                         );
      TestCommon.DoTestPow("30128314048702658157107",0,"1");
      TestCommon.DoTestShiftLeft("8",119,"5316911983139663491615228241121378304");
      TestCommon.DoTestShiftRight("6646252037208390670828",38,"24178924057");
      TestCommon.DoTestAdd("969436790973942627574","776662145677901","969437567636088305475");
      TestCommon.DoTestSubtract("-480055143722783092767076","813","-480055143722783092767889");
      TestCommon.DoTestMultiply("-6133180190818042386026744","4487693","-27523829810072793089475516861592");
      TestCommon.DoTestDivide("-928071843616","-4889413478946921","0");
      TestCommon.DoTestRemainder("-907805","-3305647284946536800","-907805");
      Assert.AreEqual(36,BigInteger.fromString("-603090534270638124779422319401462447").getDigitCount(),"-603090534270638124779422319401462447");
      TestCommon.DoTestDivideAndRemainder("30","88614024",
                                          "0",
                                          "30"
                                         );
      TestCommon.DoTestPow("43021999973154026",7,"272793595293558137475270633043247500124404918279450392959179399698673340618422559705588168392184811030388019110338176");
      TestCommon.DoTestShiftLeft("-1330288300160",46,"-93610717076498539599626240");
      TestCommon.DoTestShiftRight("1986625837105309276",147,"0");
      TestCommon.DoTestAdd("-63803547809","-6686","-63803554495");
      TestCommon.DoTestSubtract("-3350539329286610","19","-3350539329286629");
      TestCommon.DoTestMultiply("42161763962381417141024","36825774757669386152","1552639623064680389898119497907504896699648");
      TestCommon.DoTestDivide("-1618579139","-8867997327","0");
      TestCommon.DoTestRemainder("6962928284","3305633617146","6962928284");
      Assert.AreEqual(27,BigInteger.fromString("634139675055569828087852370").getDigitCount(),"634139675055569828087852370");
      TestCommon.DoTestDivideAndRemainder("7436062085140","-92099906490428021177",
                                          "0",
                                          "7436062085140"
                                         );
      TestCommon.DoTestPow("574114285033760",4,"108640914386877898149027088633569559316831219626436853760000");
      TestCommon.DoTestShiftLeft("528916982621716026",185,"25938013355392660455685868930727743725289973294765660767784653415285522432");
      TestCommon.DoTestShiftRight("543",188,"0");
      TestCommon.DoTestAdd("1919647870040435","3488","1919647870043923");
      TestCommon.DoTestSubtract("-86912313135954713","-668","-86912313135954045");
      TestCommon.DoTestMultiply("-4532013912377329785251","9174689091990366292021","-41579818606636871270240443693281113084782271");
      TestCommon.DoTestDivide("969020829102690301","-6585815118702494839578640","0");
      TestCommon.DoTestRemainder("845295","-1224020","845295");
      Assert.AreEqual(26,BigInteger.fromString("-35202791754816755798677672").getDigitCount(),"-35202791754816755798677672");
      TestCommon.DoTestDivideAndRemainder("893532517999","743343717",
                                          "1202",
                                          "33370165"
                                         );
      TestCommon.DoTestPow("9320103448529185",4,"7545411529496241029966525813180679615505488053032167780239850625");
      TestCommon.DoTestShiftLeft("-6774255114045369964636",76,"-511848244751618257353148453511796066925674496");
      TestCommon.DoTestShiftRight("811446130",35,"0");
      TestCommon.DoTestAdd("-374839315626","-659417130789857","-659791970105483");
      TestCommon.DoTestSubtract("3","9358701627104937715","-9358701627104937712");
      TestCommon.DoTestMultiply("-51308969924","151691877895055038456","-7783154000632459396463567397344");
      TestCommon.DoTestDivide("-94458924","-3908","24170");
      TestCommon.DoTestRemainder("929587846","65992908804334368381444","929587846");
      Assert.AreEqual(17,BigInteger.fromString("-35123656189591056").getDigitCount(),"-35123656189591056");
      TestCommon.DoTestDivideAndRemainder("8774697517","6160730",
                                          "1424",
                                          "1817997"
                                         );
      TestCommon.DoTestPow("-53",2,"2809");
      TestCommon.DoTestShiftLeft("-181617413915531",174,"-4348873077642901397266476662639933253014485857508196648408846434304");
      TestCommon.DoTestShiftRight("93762",140,"0");
      TestCommon.DoTestAdd("-8150","428790192307270","428790192299120");
      TestCommon.DoTestSubtract("-494","-911241043","911240549");
      TestCommon.DoTestMultiply("-212586194413","-64811666","13778065428506422058");
      TestCommon.DoTestDivide("6592219","97089168474","0");
      TestCommon.DoTestRemainder("541440913641287152914","-46","2");
      Assert.AreEqual(35,BigInteger.fromString("-11993704197587611776274350287179922").getDigitCount(),"-11993704197587611776274350287179922");
      TestCommon.DoTestDivideAndRemainder("8845646522","9",
                                          "982849613",
                                          "5"
                                         );
      TestCommon.DoTestPow("-595022",8,"15713183672420409401998116702045263579222753536");
      TestCommon.DoTestShiftLeft("7032",69,"4150960138442418142838784");
      TestCommon.DoTestShiftRight("-78875359523341123477651",167,"-1");
      TestCommon.DoTestAdd("-7996049668634448647","-1666337546199076315200731","-1666345542248744949649378");
      TestCommon.DoTestSubtract("-737559123","69","-737559192");
      TestCommon.DoTestMultiply("51138620387939732051","75048652041080","3837884527355368473205309444655080");
      TestCommon.DoTestDivide("-34","-3413904850069571433889","0");
      TestCommon.DoTestRemainder("-717309165431997681765","-6330108672565667629217","-717309165431997681765");
      Assert.AreEqual(36,BigInteger.fromString("-827900293396123664444649083471124900").getDigitCount(),"-827900293396123664444649083471124900");
      TestCommon.DoTestDivideAndRemainder("-88937554","-72127765315920630",
                                          "0",
                                          "-88937554"
                                         );
      TestCommon.DoTestPow("972364914163",0,"1");
      TestCommon.DoTestShiftLeft("720697733373920",12,"2951977915899576320");
      TestCommon.DoTestShiftRight("9974411148763695701",48,"35436");
      TestCommon.DoTestAdd("5992013","-2734227968129660370429","-2734227968129654378416");
      TestCommon.DoTestSubtract("-2887693170135897045589862","-596241467964520","-2887693169539655577625342");
      TestCommon.DoTestMultiply("3270976232281390610379","90774982","296922808607771051592122738178");
      TestCommon.DoTestDivide("-1220478792346","-4997589845657470272","0");
      TestCommon.DoTestRemainder("12535","41","30");
      Assert.AreEqual(28,BigInteger.fromString("1277092377029931636832384702").getDigitCount(),"1277092377029931636832384702");
      TestCommon.DoTestDivideAndRemainder("-395910611","-7180332060732886",
                                          "0",
                                          "-395910611"
                                         );
      TestCommon.DoTestPow("-19988151",7,"-1274701073488866347893931846749882485767854388164551");
      TestCommon.DoTestShiftLeft("-594227661",87,"-91952276750349954031105449821995008");
      TestCommon.DoTestShiftRight("27",2,"6");
      TestCommon.DoTestAdd("-75746557689662927","141913802586","-75746415775860341");
      TestCommon.DoTestSubtract("-302999","246706","-549705");
      TestCommon.DoTestMultiply("1771111","-5311727783565423916937","-9407659506478341518950207007");
      TestCommon.DoTestDivide("-63503412593188408855968","4323872549590728","-14686698");
      TestCommon.DoTestRemainder("-65577380973","-1738526077350874067197903","-65577380973");
      Assert.AreEqual(27,BigInteger.fromString("-608918591754062859216894656").getDigitCount(),"-608918591754062859216894656");
      TestCommon.DoTestDivideAndRemainder("-737008309284864442808","85151171539897393",
                                          "-8655",
                                          "-24919607052506393"
                                         );
      TestCommon.DoTestPow("-5640128769867963684",4,"1011943063746686623509388534936324318237055253871162378547911267855962644736");
      TestCommon.DoTestShiftLeft("391890116",72,"1850648748766297275674170228736");
      TestCommon.DoTestShiftRight("-16594657",67,"-1");
      TestCommon.DoTestAdd("94113","-9778","84335");
      TestCommon.DoTestSubtract("960102693845841","-6906484671709738403672","6906485631812432249513");
      TestCommon.DoTestMultiply("553775368912364942347920","543826149468580","301157526546153807444632316445468353600");
      TestCommon.DoTestDivide("61158823481869708562","40224525553228","1520436");
      TestCommon.DoTestRemainder("8517479","-2477","1553");
      Assert.AreEqual(11,BigInteger.fromString("42476283684").getDigitCount(),"42476283684");
      TestCommon.DoTestDivideAndRemainder("3","895991717804",
                                          "0",
                                          "3"
                                         );
      TestCommon.DoTestPow("-6725655721",2,"45234444877420029841");
      TestCommon.DoTestShiftLeft("9011366219195489992",34,"154814092814895187785341206528");
      TestCommon.DoTestShiftRight("96274928112089765",68,"0");
      TestCommon.DoTestAdd("27678493112249999185033","10","27678493112249999185043");
      TestCommon.DoTestSubtract("-89442008408995635008","26105870298897596894","-115547878707893231902");
      TestCommon.DoTestMultiply("71149058444745609101","-50394","-3585485651264510225035794");
      TestCommon.DoTestDivide("-8558426604031389978884122","-73","117238720603169725738138");
      TestCommon.DoTestRemainder("-929985460718","988495592800185","-929985460718");
      Assert.AreEqual(48,BigInteger.fromString("761497437194905431692759240289905054787773404449").getDigitCount(),"761497437194905431692759240289905054787773404449");
      TestCommon.DoTestDivideAndRemainder("4","-92888",
                                          "0",
                                          "4"
                                         );
      TestCommon.DoTestPow("-4",9,"-262144");
      TestCommon.DoTestShiftLeft("-79356369339397786679463",101,"-201192298450041329204350730400520455553744295140786176");
      TestCommon.DoTestShiftRight("1",48,"0");
      TestCommon.DoTestAdd("9","58255365658976","58255365658985");
      TestCommon.DoTestSubtract("-80756256980","-5322197211","-75434059769");
      TestCommon.DoTestMultiply("-87089021380381","-39979846036","3481805666213544571019716");
      TestCommon.DoTestDivide("-5179113098915146","9161763405215018","0");
      TestCommon.DoTestRemainder("710014882634702614909269","-965066078","329448981");
      Assert.AreEqual(23,BigInteger.fromString("27636117741181754145852").getDigitCount(),"27636117741181754145852");
      TestCommon.DoTestDivideAndRemainder("-3","-73318622",
                                          "0",
                                          "-3"
                                         );
      TestCommon.DoTestPow("-421558644",3,"-74915899198934325351153984");
      TestCommon.DoTestShiftLeft("918059865560116921",109,"595854919486837659970934728868128780946450312855552");
      TestCommon.DoTestShiftRight("67624",62,"0");
      TestCommon.DoTestAdd("43419","24052021","24095440");
      TestCommon.DoTestSubtract("846836429762481733311","-43288068517152045827","890124498279633779138");
      TestCommon.DoTestMultiply("94427075441700348306","-51169591223450385","-4831794850777717529247550729609797810");
      TestCommon.DoTestDivide("87406647073977931967","476621073361045416","183");
      TestCommon.DoTestRemainder("2","-1444663559123160637897","2");
      Assert.AreEqual(30,BigInteger.fromString("189977375543110541308963676631").getDigitCount(),"189977375543110541308963676631");
      TestCommon.DoTestDivideAndRemainder("7610794734224","-9",
                                          "-845643859358",
                                          "2"
                                         );
      TestCommon.DoTestPow("-884",0,"1");
      TestCommon.DoTestShiftLeft("734275061810715",120,"976018968765501920059079248220790631518598688931840");
      TestCommon.DoTestShiftRight("-3",103,"-1");
      TestCommon.DoTestAdd("-654404303555627888589242","-650102129586219665390","-655054405685214108254632");
      TestCommon.DoTestSubtract("-6792652437130226","7115","-6792652437137341");
      TestCommon.DoTestMultiply("-388939058431130666575831","-174180953719302694","67745776136221936903039192280953993588714");
      TestCommon.DoTestDivide("-893715293","197136659694403","0");
      TestCommon.DoTestRemainder("92240703","4578370438241683737238","92240703");
      Assert.AreEqual(23,BigInteger.fromString("-68664652374827165626795").getDigitCount(),"-68664652374827165626795");
      TestCommon.DoTestDivideAndRemainder("8985055624428449","-9240448270550170249090439",
                                          "0",
                                          "8985055624428449"
                                         );
      TestCommon.DoTestPow("6940832334",1,"6940832334");
      TestCommon.DoTestShiftLeft("6029172",57,"868895256721684099497984");
      TestCommon.DoTestShiftRight("226360894508545314043",79,"0");
      TestCommon.DoTestAdd("-40264","-77356","-117620");
      TestCommon.DoTestSubtract("-8318924421","1640842476593","-1649161401014");
      TestCommon.DoTestMultiply("2473667019765701","93308053503661952163","230813054630542036666576272530161263");
      TestCommon.DoTestDivide("-53930625516573108798","272684723584166667328","0");
      TestCommon.DoTestRemainder("-575094","-7798198627671134448062","-575094");
      Assert.AreEqual(25,BigInteger.fromString("-4583749475497899889096200").getDigitCount(),"-4583749475497899889096200");
      TestCommon.DoTestDivideAndRemainder("4385793826","73503067427907186016777",
                                          "0",
                                          "4385793826"
                                         );
      TestCommon.DoTestPow("-270707957218747230608757",6,"393555630339951506029350431798098085064873093960964638035405340637269768917762225303508629056376964450844408300091018301263116937204102372649");
      TestCommon.DoTestShiftLeft("9547499254627154",100,"12102893160806684585066175318853032191568379904");
      TestCommon.DoTestShiftRight("-6512274119899758222865",126,"-1");
      TestCommon.DoTestAdd("7026125","3193217643","3200243768");
      TestCommon.DoTestSubtract("-6","3359224719061368187","-3359224719061368193");
      TestCommon.DoTestMultiply("3358893677672946485","1","3358893677672946485");
      TestCommon.DoTestDivide("-11132731696439914434","-9900203098265","1124495");
      TestCommon.DoTestRemainder("-771575035988757","-265492","-58613");
      Assert.AreEqual(19,BigInteger.fromString("-5180520926005373784").getDigitCount(),"-5180520926005373784");
      TestCommon.DoTestDivideAndRemainder("6622443","-9784829",
                                          "0",
                                          "6622443"
                                         );
      TestCommon.DoTestPow("-9219360270238938372084088",1,"-9219360270238938372084088");
      TestCommon.DoTestShiftLeft("253889519",170,"379965386464927114996152203474874940752191753044606431789056");
      TestCommon.DoTestShiftRight("124322843388",139,"0");
      TestCommon.DoTestAdd("-20630262542744848986","-665748318420768109198379","-665768948683310854047365");
      TestCommon.DoTestSubtract("90351376373353740","3193338925914253388257815","-3193338835562877014904075");
      TestCommon.DoTestMultiply("-458007861","90056730479746","-41246690495681969283306");
      TestCommon.DoTestDivide("394833","6005877350961372184","0");
      TestCommon.DoTestRemainder("-5782693035104","-352830193","-159002027");
      Assert.AreEqual(23,BigInteger.fromString("16147092639442617129538").getDigitCount(),"16147092639442617129538");
      TestCommon.DoTestDivideAndRemainder("76497822472967585","-9719122132083556740588931",
                                          "0",
                                          "76497822472967585"
                                         );
      TestCommon.DoTestPow("496017616",0,"1");
      TestCommon.DoTestShiftLeft("-6749451",165,"-315658678002710401029528921531575972585592113859900997632");
      TestCommon.DoTestShiftRight("-3051142672635",126,"-1");
      TestCommon.DoTestAdd("-61068136313838","-65875111029680697","-65936179165994535");
      TestCommon.DoTestSubtract("900684116603779502857309","62100717521973582","900684054503061980883727");
      TestCommon.DoTestMultiply("1437906869470261022238416","-1145322229139737","-1646866701037020195421087047013793536592");
      TestCommon.DoTestDivide("-67855078","7794299131","0");
      TestCommon.DoTestRemainder("-5","94190546450","-5");
      Assert.AreEqual(23,BigInteger.fromString("19851568700800140266168").getDigitCount(),"19851568700800140266168");
      TestCommon.DoTestDivideAndRemainder("-1502","-3909218",
                                          "0",
                                          "-1502"
                                         );
      TestCommon.DoTestPow("38815184961546788",6,"3419872854645054102374695091684308481144048426094617867321863010439315942434190548244014356652560384");
      TestCommon.DoTestShiftLeft("-43773745458394747",149,"-31237988603295946408978982616811539849104812719243256936792064");
      TestCommon.DoTestShiftRight("-87302190299",143,"-1");
      TestCommon.DoTestAdd("7926116154247549541017","18","7926116154247549541035");
      TestCommon.DoTestSubtract("5247","1","5246");
      TestCommon.DoTestMultiply("-8700840","-679509831831150","5912306325189743166000");
      TestCommon.DoTestDivide("-413412379174843579","-5310811587766766","77");
      TestCommon.DoTestRemainder("-119204905804","3323154110886588829","-119204905804");
      Assert.AreEqual(40,BigInteger.fromString("-5215470549874141165360869863184955917490").getDigitCount(),"-5215470549874141165360869863184955917490");
      TestCommon.DoTestDivideAndRemainder("-35334770203","-1984234024123759602",
                                          "0",
                                          "-35334770203"
                                         );
      TestCommon.DoTestPow("-212161969428448979669",9,"-870979319746949255441165185875863110722932672001761589915076806789825617230734989949442347126261643546796221866674478488588348313681215411214961975889337188989604717267538096538728629");
      TestCommon.DoTestShiftLeft("696730",58,"200818749976182123397120");
      TestCommon.DoTestShiftRight("5928198975165099696395186",118,"0");
      TestCommon.DoTestAdd("-4172664185109","4","-4172664185105");
      TestCommon.DoTestSubtract("-8602540","-889","-8601651");
      TestCommon.DoTestMultiply("-12326181","981829","-12102201965049");
      TestCommon.DoTestDivide("83389160958047","-87031572720518125","0");
      TestCommon.DoTestRemainder("3973719470","-213888185","123732140");
      Assert.AreEqual(38,BigInteger.fromString("-20403919104178107534088258261127063475").getDigitCount(),"-20403919104178107534088258261127063475");
      TestCommon.DoTestDivideAndRemainder("-130718437952584","6813703455672987505",
                                          "0",
                                          "-130718437952584"
                                         );
      TestCommon.DoTestPow("-395390657516466986511",8,"597325736173256453066814012924510123952227148301838991950603412809341505462985185163174021847145402364384154570676345362997275336821204256191846774101654502238890881");
      TestCommon.DoTestShiftLeft("-767264970063317772",42,"-3374467024679289733115478540288");
      TestCommon.DoTestShiftRight("-320",156,"-1");
      TestCommon.DoTestAdd("-904183195014864922413","-7581832929918806","-904190776847794841219");
      TestCommon.DoTestSubtract("-295248","863","-296111");
      TestCommon.DoTestMultiply("51","-5372","-273972");
      TestCommon.DoTestDivide("-49891","-293638040797465389565","0");
      TestCommon.DoTestRemainder("-28187178633796509280","-5328723427987","-835923370964");
      Assert.AreEqual(33,BigInteger.fromString("202905581491606953811941574118088").getDigitCount(),"202905581491606953811941574118088");
      TestCommon.DoTestDivideAndRemainder("9068160685413784044785","480",
                                          "18892001427945383426",
                                          "305"
                                         );
      TestCommon.DoTestPow("-4925047",2,"24256087952209");
      TestCommon.DoTestShiftLeft("8748419796523461",121,"23257289024835923193215707075334463091922071896195072");
      TestCommon.DoTestShiftRight("93495242496778446557328",71,"39");
    }

    [Test]
    public void TestVarious(){
      TestCommon.DoTestAdd("86201105396009412693871","293638365840714087782","86494743761850126781653");
      TestCommon.DoTestSubtract("633490014543","-4905059771014653948","4905060404504668491");
      TestCommon.DoTestMultiply("-8170929","-9","73538361");
      TestCommon.DoTestDivide("18469086635525929113331","2202198054","8386660138028");
      TestCommon.DoTestRemainder("796476","-277351620056422114","796476");
      TestCommon.DoTestDivideAndRemainder("54589617963","-925218","-59001","830745");
      //TestCommon.DoTestPow("-4728484",1,"-4728484");
      TestCommon.DoTestAdd("3171863549743164326738","16499778873506997","3171880049522037833735");
      TestCommon.DoTestSubtract("9","-47663623025951889898","47663623025951889907");
      TestCommon.DoTestMultiply("400087712","-69477069","-27796921572676128");
      TestCommon.DoTestDivide("-203","20828630068691915781","0");
      TestCommon.DoTestRemainder("804191810067218","4953","2315");
      TestCommon.DoTestDivideAndRemainder("-7417627312879597818338","-634615947289866771207885","0","-7417627312879597818338");
      //TestCommon.DoTestPow("-762785870",27,"-668145836095971411178233587352173495811161152607565637812845740066282074598033537752036677709023998187197884229778896118244798194333723116649895091386695546140372764687237077542969949643309587463515300363131611683000000000000000000000000000");
      TestCommon.DoTestAdd("7425568685641612441874","-41451553192780","7425568644190059249094");
      TestCommon.DoTestSubtract("-5385116997","-54964981892","49579864895");
      TestCommon.DoTestMultiply("8518611018703323995534273","-4505224876691","-38378258276316276742492716511089330643");
      TestCommon.DoTestDivide("1275249064246931857","-23687885218474","-53835");
      TestCommon.DoTestRemainder("7418117587658088637","-128069610503260321582887","7418117587658088637");
      TestCommon.DoTestDivideAndRemainder("-923577901428293923","-83653","11040583140213","-55834");
      //TestCommon.DoTestPow("0",32,"0");
      TestCommon.DoTestAdd("-8400176997","-1388792508837879505","-1388792517238056502");
      TestCommon.DoTestSubtract("-876","-279","-597");
      TestCommon.DoTestMultiply("48786205908237158","-814","-39711971609305046612");
      TestCommon.DoTestDivide("-17892760686","5418918782345924357608729","0");
      TestCommon.DoTestRemainder("8275","-96648989997817","8275");
      TestCommon.DoTestDivideAndRemainder("8928247798615325696007","7105651583202819978527003","0","8928247798615325696007");
      //TestCommon.DoTestPow("101142",19,"124079263443994724525492775657356609040579988937273068935867995151547999613246382778296949014528");
      TestCommon.DoTestAdd("-224738","-945799802253772","-945799802478510");
      TestCommon.DoTestSubtract("-49","2084418711962","-2084418712011");
      TestCommon.DoTestMultiply("3390217","-622125164321","-2109139308208847657");
      TestCommon.DoTestDivide("62637","6318755849238239633193","0");
      TestCommon.DoTestRemainder("-843814011299937818640489","-15652916342","-7324837523");
      TestCommon.DoTestDivideAndRemainder("-26511973249238938","-9275847372","2858172","-6014314954");
      //TestCommon.DoTestPow("83714155",7,"28813252503693967315364406348180319571772178826696171875");
      TestCommon.DoTestAdd("1320","14","1334");
      TestCommon.DoTestSubtract("652780","2451487534936557516259697","-2451487534936557515606917");
      TestCommon.DoTestMultiply("170565716478","-81604","-13918844727470712");
      TestCommon.DoTestDivide("-171562185862396255570","-13708167631820717755","12");
      TestCommon.DoTestRemainder("906758819515630","-3","1");
      TestCommon.DoTestDivideAndRemainder("6570973982692195730405374","9211414492472812567","713351","2243072222412923357");
      //TestCommon.DoTestPow("940003789477871239533940",34,"122013124706901526083655794980660092042952800876328730145768719355950424470336456705820944921930195832492472710721328143444924990844435267592234057615073904100521914612187247025923633217390096853305534122813724559607441312424508780464531149470180833987320726204255448918807411690932804869692457422391635831835995036884077915004023273133519462041645869684423002625447180664026469829239745214152511729186197310174965401489219040204715195128762409193101021606544850086239198642987062720606287311175773594536810743740035215298015739188857371047874823259304553082881922962869616498181167048947486889759511728702653430268168384029985424299084723414781661333014164194799225655543527665897822877099262272421726999567572837137241244674165055937640701230350792700242157225991143901488962600960000000000000000000000000000000000");
      TestCommon.DoTestAdd("2054063224355823","6236411485806939","8290474710162762");
      TestCommon.DoTestSubtract("33034461486322","15906571290","33018554915032");
      TestCommon.DoTestMultiply("1208291","-897318225024815085556","-1084221535433458844541544796");
      TestCommon.DoTestDivide("23690450546280124335","2956","8014360807266618");
      TestCommon.DoTestRemainder("-243571081","-3224787618329132280","-243571081");
      TestCommon.DoTestDivideAndRemainder("6027314768072960","-3650125531127","-1651","957516182283");
      //TestCommon.DoTestPow("7455835958",52,"2343202906365160514593553466357702058459310714335566014347424647598387731421837778261199195188823873667320836235179819571452434912183689645376830998946200803599517209430127194135064991244590056458128613702844887016940697190612895655280092997574178839493355865659087158856488451326833664445632690197371340705267037528728342162233685684296857705593595652809016691685108172938852250455595154597687978868204452938464956682462942250291277588121719771316381066259306687845320374996640649657145578520896867947593110388736");
      TestCommon.DoTestAdd("604","551685","552289");
      TestCommon.DoTestSubtract("2858566","500089377848098666018696","-500089377848098663160130");
      TestCommon.DoTestMultiply("-96669892868623892","313293","-30286000746489784996356");
      TestCommon.DoTestDivide("59053883041555","18558756564036334849488","0");
      TestCommon.DoTestRemainder("9046783511352652240694","-65992","43654");
      TestCommon.DoTestDivideAndRemainder("-246404776351224299","-956661293943312823415716","0","-246404776351224299");
      //TestCommon.DoTestPow("0",24,"0");
      TestCommon.DoTestAdd("8508667274448288891974103","17176566799998790377559","8525843841248287682351662");
      TestCommon.DoTestSubtract("-6874","-3388936456652341860","3388936456652334986");
      TestCommon.DoTestMultiply("-5399341","-36698160629284292054278","198145883310280478744637430798");
      TestCommon.DoTestDivide("-65170902876431","4196763662040175373509210","0");
      TestCommon.DoTestRemainder("8237076255889386069","374","307");
      TestCommon.DoTestDivideAndRemainder("41","56096994741175151920","0","41");
      //TestCommon.DoTestPow("-94521908",36,"131573754208151259653012643156926893688174085517976908670946050063172409907827849412478109652334935198146441438440772629352794092281367143730811237052364127847728492081834846925797299881465090347390430399516274342901653335532246694665024730955857958775349732183587529264881906797621805056");
      TestCommon.DoTestAdd("-8018794","-860362114565961978","-860362114573980772");
      TestCommon.DoTestSubtract("-830","10993","-11823");
      TestCommon.DoTestMultiply("-99131021","233781834458","-23175031941074521618");
      TestCommon.DoTestDivide("4","97656283173735373573628","0");
      TestCommon.DoTestRemainder("641657040900440617","-5423859966743470687","641657040900440617");
      TestCommon.DoTestDivideAndRemainder("343845280723647","3494927073315045512","0","343845280723647");
      //TestCommon.DoTestPow("-25331228",36,"340114212644487237570898773918565856379320928735004161865122573262008731402378635387017397188469551085528531521118576872331734144798384241069794439737095710946159350659633579148713753973923089361724868501780825267636194247759701508932255755435795311981698814046109696");
      TestCommon.DoTestAdd("-8125","-88","-8213");
      TestCommon.DoTestSubtract("-5469077928","69417","-5469147345");
      TestCommon.DoTestMultiply("-7842575347970761753","5607092147529364171545791","-43974042650014229012718239560359661790931623");
      TestCommon.DoTestDivide("253866","-785767558460700376","0");
      TestCommon.DoTestRemainder("96914183558","-93756290497182","96914183558");
      TestCommon.DoTestDivideAndRemainder("-2880990141751","3853234910424527130","0","-2880990141751");
      //TestCommon.DoTestPow("-7",13,"-96889010407");
      TestCommon.DoTestAdd("640108967216614410999651","453","640108967216614411000104");
      TestCommon.DoTestSubtract("-338625336228106","408219654271023599","-408558279607251705");
      TestCommon.DoTestMultiply("80084","-63644702745135974","-5096922374641469341816");
      TestCommon.DoTestDivide("-36770950696645839911240","-880064329103361","41782116");
      TestCommon.DoTestRemainder("776022","687617","88405");
      TestCommon.DoTestDivideAndRemainder("-24106","776578186162030","0","-24106");
      TestCommon.DoTestAdd("-843589044567634","-74823047633980729967458","-74823048477569774535092");
      TestCommon.DoTestSubtract("-3","3709987","-3709990");
      TestCommon.DoTestMultiply("570007245","-6","-3420043470");
      TestCommon.DoTestDivide("392828","1","392828");
      TestCommon.DoTestRemainder("249840","8244","2520");
      TestCommon.DoTestDivideAndRemainder("91630932527","1761502223987432677","0","91630932527");
      TestCommon.DoTestAdd("792090317197404926887838","-4737773601887","792090317192667153285951");
      TestCommon.DoTestSubtract("-489247","-176347619851911341421","176347619851910852174");
      TestCommon.DoTestMultiply("-9","9972894481040","-89756050329360");
      TestCommon.DoTestDivide("56800543343683","1738945557773089194088","0");
      TestCommon.DoTestRemainder("-1","516125901603490324404753","-1");
      TestCommon.DoTestDivideAndRemainder("5355","-3683208050","0","5355");
      TestCommon.DoTestAdd("-283122","18613266011159143742253","18613266011159143459131");
      TestCommon.DoTestSubtract("-7995726367822383871958","4666637835578","-7995726372489021707536");
      TestCommon.DoTestMultiply("-43846109935","1543274461867465011","-67666581714918836272071984285");
      TestCommon.DoTestDivide("0","3933","0");
      TestCommon.DoTestRemainder("242088208684541","48115872416131108","242088208684541");
      TestCommon.DoTestDivideAndRemainder("3407472","777007571968907956","0","3407472");
      TestCommon.DoTestAdd("-796304851933444752","974352309919101748822","973556005067168304070");
      TestCommon.DoTestSubtract("5135953","-226997707","232133660");
      TestCommon.DoTestMultiply("1638","-7607790082","-12461560154316");
      TestCommon.DoTestDivide("-9236193864136527624","-49498089199887062","186");
      TestCommon.DoTestRemainder("837124378356055414564404","-3750848962877807","828875488016117");
      TestCommon.DoTestDivideAndRemainder("6875","3378064230596680242143054","0","6875");
      TestCommon.DoTestAdd("17445656434","-8632226686175234059","-8632226668729577625");
      TestCommon.DoTestSubtract("6617133036492338","49634280347190","6567498756145148");
      TestCommon.DoTestMultiply("134468963","-79081654655","-10634028093781972765");
      TestCommon.DoTestDivide("336","4151958527626097099","0");
      TestCommon.DoTestRemainder("-982341","-5704083610","-982341");
      TestCommon.DoTestDivideAndRemainder("9829816523023341805","-98494","-99801170863436","76421");
      //TestCommon.DoTestPow("234724728531",26,"43105231490912828296065130910699058291876279413145979764164012004424513949552275086146063163749688372979668737155535474178368232625243002489513924388431957529911205018795153387937453180023059977668995894914145840817478780567999215640229993643024627544810463210767661636274390231914417318003934281");
      TestCommon.DoTestAdd("151085668247","-269123140268065021013843","-269123140267913935345596");
      TestCommon.DoTestSubtract("195","78482","-78287");
      TestCommon.DoTestMultiply("-8730394006","-4","34921576024");
      TestCommon.DoTestDivide("-8718848","4","-2179712");
      TestCommon.DoTestRemainder("-35712764139104788800382","27263147612197","-5966721725590");
      TestCommon.DoTestDivideAndRemainder("-61986048387986","-831045","74588076","-768566");
      //TestCommon.DoTestPow("-32044245680647471991",51,"-62123038832444256338823447276138340798529987911020005254438548512227373256646812461714427362583994779864164650438940262043754877962082043879761012110206912043277044834639960974555000483970552494927703133648586330659536885037886224049717995647690617572240851136095171895705897198348364864983013738984754071107809368183258147268114062894080323802869200726445620605639415914772597166477102431280395155888873469790724528733111742660043658951779043861598000809644993996943410589207679396445789160359110786663162895611063761526930293398525127777402703637651400167485951949238258642944336803613149035556444785078800511005098340851472277238926110392489332413186743298263655120002687637414644754897890642872610937006054447536891598594065857200104354486214464317332591260188992738234509672883420123314305932028684269704725733519163301211922076918923060726280111351301768785703870886121885494915718658489485810324762203842023038707874329493976589524928835634755047617868849776147326250656698017203237373991");
      TestCommon.DoTestAdd("-915414875084661449700373","-1190","-915414875084661449701563");
      TestCommon.DoTestSubtract("-5368258878","766","-5368259644");
      TestCommon.DoTestMultiply("3513119","413093682411745317","1451247264460668296313723");
      TestCommon.DoTestDivide("-1196939237075","44644","-26810752");
      TestCommon.DoTestRemainder("-8792648664506","48546180207562332","-8792648664506");
      TestCommon.DoTestDivideAndRemainder("7832835826225319","-771682641","-10150333","49755866");
      //TestCommon.DoTestPow("15436927281691618",30,"453759520576784961727767430860770350113893268036393510330591914522820502160672934337921959706362957607572549092521552971820335862060677707047602428423621254355426355936222712880944209849098891210353451654480553567291151754532348610245933389427416380469383523318309597068449977538674481434018363288052955268392426065801940084900832756108179994481199668776279074764386851717817226778505844686811050258588514044332930637506621106286755548064847598577106139783470508631252647974442708762624");
      TestCommon.DoTestAdd("-642069537480660","-21628633654448962540","-21629275723986443200");
      TestCommon.DoTestSubtract("781247229288395397835","-470226384761062165155348","471007631990350560553183");
      TestCommon.DoTestMultiply("-800802401","8201316281467","-6567633769559165402267");
      TestCommon.DoTestDivide("65468509","-38869855303689","0");
      TestCommon.DoTestRemainder("60","-739704484609355","60");
      TestCommon.DoTestDivideAndRemainder("-390316283847216","-7704336","50661897","-6961824");
      //TestCommon.DoTestPow("-24517386789676",22,"3701961767271601896547233951089978326767101173300588774477409801167516768237375482451508175167719058562509098933243386468281945135918922292540427862604881202463422796435735869921358097446546955142429331207604915885882260130905838838011064989658863670356739324207853029373810439070969465956990976");
      TestCommon.DoTestAdd("432959125","-91","432959034");
      TestCommon.DoTestSubtract("39949374714136224","-7407","39949374714143631");
      TestCommon.DoTestMultiply("-80656554531288640077","70215194034641716063","-5663315626580092393695507057044836456851");
      TestCommon.DoTestDivide("30969","-113430","0");
      TestCommon.DoTestRemainder("-873850661051328276","-930262680","-227913036");
      TestCommon.DoTestDivideAndRemainder("-2529794","8339082","0","-2529794");
      //TestCommon.DoTestPow("265988854299969606",25,"4183945035118934673581168015063908815359608186434347795524532172913948852284732769426477640062783895484700912092685474557569368026114029092049278379619763019793453951156620440161510129978458990632194685567624077743348004935106704178104359925076182838969756217615236929441516428342860416566189050599863106799792639590967234639037017335154604412531518863953741833856392748660401673526122353979664958624836927717630759911487118552256741376");
      TestCommon.DoTestAdd("25531147566433059","-99921579045164","25431225987387895");
      TestCommon.DoTestSubtract("-5984401149723232541","-1","-5984401149723232540");
      TestCommon.DoTestMultiply("4172950434568074018326","128053037315","534358977711391048176381271834690");
      TestCommon.DoTestDivide("-66382","-102877752","0");
      TestCommon.DoTestRemainder("0","10079328878","0");
      TestCommon.DoTestDivideAndRemainder("-49450652619832453057","-754344008668070492","65","-418292056407871077");
      TestCommon.DoTestAdd("-5363011265949","44939","-5363011221010");
      TestCommon.DoTestSubtract("-50832393451651","-99802042960570739976","99801992128177288325");
      TestCommon.DoTestMultiply("1989117064","-9092419544799025","-18085886869606853078062600");
      TestCommon.DoTestDivide("7418664404603","-2034358995105549999626505","0");
      TestCommon.DoTestRemainder("18734953703993002982","-28729897624575329036058","18734953703993002982");
      TestCommon.DoTestDivideAndRemainder("88652971083946893699","-7758416139","-11426684196","2444254455");
      TestCommon.DoTestAdd("-3699539354899240124672","-18430600905","-3699539354917670725577");
      TestCommon.DoTestSubtract("26064692031","3561696206","22502995825");
      TestCommon.DoTestMultiply("-407986029259540554623","-685","279470430042785279916755");
      TestCommon.DoTestDivide("-65395465230411","-6328326286924","10");
      TestCommon.DoTestRemainder("161173320897816","511146346","188516134");
      TestCommon.DoTestDivideAndRemainder("-3501478810777339336","-654502378","5349833596","-291048048");
      //TestCommon.DoTestPow("-9",5,"-59049");
      TestCommon.DoTestAdd("2711789424665870030462243","706270927013265331290045","3418060351679135361752288");
      TestCommon.DoTestSubtract("-1799277","7113698191328055801250806","-7113698191328055803050083");
      TestCommon.DoTestMultiply("-72","6327528345339973","-455582040864478056");
      TestCommon.DoTestDivide("-27","198084909126124","0");
      TestCommon.DoTestRemainder("36016279857","37597730601","36016279857");
      TestCommon.DoTestDivideAndRemainder("260833415","70570798572692544","0","260833415");
      TestCommon.DoTestAdd("4303606","-722562952290952609604","-722562952290948305998");
      TestCommon.DoTestSubtract("6384506166618992","-83698290275174769282","83704674781341388274");
      TestCommon.DoTestMultiply("-7152741","4517906642258391506","-32315416074253929519017946");
      TestCommon.DoTestDivide("-815252655039053","708","-1151486800902");
      TestCommon.DoTestRemainder("-2901906574965","-92","-33");
      TestCommon.DoTestDivideAndRemainder("-64230046","-5568868706382764171146754","0","-64230046");
      TestCommon.DoTestAdd("889702770059824271552","0","889702770059824271552");
      TestCommon.DoTestSubtract("5563","132011","-126448");
      TestCommon.DoTestMultiply("713569066309","335482099668199441","239389648623619953813565733269");
      TestCommon.DoTestDivide("648064669916","-19","-34108666837");
      TestCommon.DoTestRemainder("7247","-682385","7247");
      TestCommon.DoTestDivideAndRemainder("34490294755","-334500294133643184635","0","34490294755");
      //TestCommon.DoTestPow("6512738525592",5,"11717048079977255724398394340314641216854967122547973379801055232");
      TestCommon.DoTestAdd("4049","-814754964","-814750915");
      TestCommon.DoTestSubtract("-8834583473669495968180518","21302208579223925368","-8834604775878075192105886");
      TestCommon.DoTestMultiply("-85624631072574","-76387043976110282","6540612459178929041078169605868");
      TestCommon.DoTestDivide("-2189993469","-32","68437295");
      TestCommon.DoTestRemainder("4284","-108590266451023565862","4284");
      TestCommon.DoTestDivideAndRemainder("64","1085","0","64");
      TestCommon.DoTestAdd("4163888658476","-31767077401716","-27603188743240");
      TestCommon.DoTestSubtract("-3978997625263427","-1138999788940681384","1135020791315417957");
      TestCommon.DoTestMultiply("-3515259042488985238","20","-70305180849779704760");
      TestCommon.DoTestDivide("75009780791025416280","836785","89640446220983");
      TestCommon.DoTestRemainder("-68725193912","-7474062028472365","-68725193912");
      TestCommon.DoTestDivideAndRemainder("-996016027407425402625216","238771686065683483363","-4171","-99324827459593518143");
      TestCommon.DoTestAdd("4208783813148602831682355","-53458484561751","4208783813095144347120604");
      TestCommon.DoTestSubtract("-34225017459921394020","9728932838417761","-34234746392759811781");
      TestCommon.DoTestMultiply("-926849984977363528661395","144056564693408","-133518824821975802101059772828820584160");
      TestCommon.DoTestDivide("1198124203404777545","-150891992417905439010951","0");
      TestCommon.DoTestRemainder("-56074","-74616436946","-56074");
      TestCommon.DoTestDivideAndRemainder("1162083","-53016860302649213","0","1162083");
      TestCommon.DoTestAdd("-375197498222","-8659445191","-383856943413");
      TestCommon.DoTestSubtract("76193264","-95126474319","95202667583");
      TestCommon.DoTestMultiply("4153240794297612652","72784488957499","302291508730388963797311992677348");
      TestCommon.DoTestDivide("-4224830708162","-3155204147082","1");
      TestCommon.DoTestRemainder("2755","45530464646927027839723","2755");
      TestCommon.DoTestDivideAndRemainder("61884651","-7918619555","0","61884651");
      //TestCommon.DoTestPow("99227226249148804140547",15,"890149130477142772317043657392653917578642590107119827829130179262330966473937651190655396512707497961634798561397830212577791430890392428746712578673390210429518982946420062652654603198487749265884009455811644512090719976573535557551998760037088895865421743815481466748137552866584109098621471748852606713391010626383346946947714018497670132843");
      TestCommon.DoTestAdd("-855765977263102","910410293262530544","909554527285267442");
      TestCommon.DoTestSubtract("157884561268046741251513","59","157884561268046741251454");
      TestCommon.DoTestMultiply("-3267864820155248009","-1480666860","4838619142163735782007281740");
      TestCommon.DoTestDivide("372474205773013058907730","12676","29384206829679162110");
      TestCommon.DoTestRemainder("-13251354195797883673","126642353988046","-4843904702417");
      TestCommon.DoTestDivideAndRemainder("-72913153628","-218332516833199022","0","-72913153628");
      //TestCommon.DoTestPow("-152",49,"-81345926372840839763978944122024582911519706453726608517209171876842041356696645522330139899413767139622912");
      TestCommon.DoTestAdd("836169","-1751708","-915539");
      TestCommon.DoTestSubtract("-19692720038772110760726","3670509196768655","-19692723709281307529381");
      TestCommon.DoTestMultiply("-946105901096729674444","-25990180","24589462668566201650140959920");
      TestCommon.DoTestDivide("-68610711689427729","8654314472288581037363","0");
      TestCommon.DoTestRemainder("-7","454761767243056992408770","-7");
      TestCommon.DoTestDivideAndRemainder("52297997572806285","87401079433295","598","32152071695875");
      //TestCommon.DoTestPow("61709807937865775",53,"77405589305679779549807721799490950859378298429189603430600157855962033851945995670613160749630225922221919920407449184901594107833311286830974095060127653416997855937326806662975661978913059956715311320557117322716005460231519969743211502195362888958514812220224410440820439274165624211267577749204421652400566524386853027377105095952794334726034706983983998889680480095162597103331567871209204550522646020216279742337248721559243452589239716024609215862470367857229394121822094116654174688361083035536638227379013849832827110206225129764278978266678726828197658356188978872106465908888448088729434401465328545028335800583903794732113631845924327561638669532598128451488618221851739247440264708411919812468454156592620251476353701866967858472191577169435364357769103554913470054530998707249014601328543042934686579807350008166434976826097231613287540097356753676649532280862331390380859375");
      TestCommon.DoTestAdd("8953649337358752","-6170043","8953649331188709");
      TestCommon.DoTestSubtract("-437366488","-72256518715378","72256081348890");
      TestCommon.DoTestMultiply("33","-20976513784","-692224954872");
      TestCommon.DoTestDivide("81322","27","3011");
      TestCommon.DoTestRemainder("4","8307467897","4");
      TestCommon.DoTestDivideAndRemainder("84031695171294144740","-7450193921395359414059711","0","84031695171294144740");
      //TestCommon.DoTestPow("-979440910",35,"-483324042898459094291282042012943423377676245895120284478306893542845221032588297861165216397226383417515451417091820365821130543690147562744462125809070310363947386079165644893173324441716293591337440314099778327335656003081098252063999879464376345904956203681815769553992696765100000000000000000000000000000000000");
      TestCommon.DoTestAdd("1","-66441623000","-66441622999");
      TestCommon.DoTestSubtract("-93311583813848","407554703","-93311991368551");
      TestCommon.DoTestMultiply("26807824797225","-553507728","-14838338196134070454800");
      TestCommon.DoTestDivide("-162990188352968825606","18081926301752543","-9013");
      TestCommon.DoTestRemainder("3042364416893248273","186901953476085019574","3042364416893248273");
      TestCommon.DoTestDivideAndRemainder("52680641590","-20326525058","-2","12027591474");
      //TestCommon.DoTestPow("37417400016114",50,"4504850078361435235877505070340457779756577915370522803347151845761279930388173660647841096290747743059499059974535617393647454025855118672611631555399889332931092335236466169335593715649638277736697741422945226759781181182579244365574195260345926252112451598582417451345327840794300152494352378506281623534717350162651068365446458158714721598025272027848333504282877288572719050944174829233020640054906358165657049377387409526811147034151611758338527107200022907489233235877693780825633139806429962642443922259580961800818315000720382338034894828432337610172800060787242484744556143110970786620985034736290998378891876426929198600339234042392042167882661190854696487258083557376");
      TestCommon.DoTestAdd("-9027638545333517650378021","-5151045","-9027638545333517655529066");
      TestCommon.DoTestSubtract("7748271633837327306","998427418","7748271632838899888");
      TestCommon.DoTestMultiply("148675307150709401357","-11833535254721656757","-1759354488674490532071654796510704019249");
      TestCommon.DoTestDivide("-61823996228940747629","-55282","1118338631542649");
      TestCommon.DoTestRemainder("-713860902325522","696544745677100114867","-713860902325522");
      TestCommon.DoTestDivideAndRemainder("789","7291581204455515610","0","789");
      //TestCommon.DoTestPow("29793247631",49,"1705196647346169576216620055599064986199076063773381588248493322780384825008885706364603353811921856410391379446772773036558949504924358905961331588033359920547760760093947777600656411341294765979840263793340156586262740807154191622545378231829066127269923092408241810805481103157207222650871492153774028432875765208382582704739419333201512454721331725072292700420202629087166937023511159811729096088357508467733125244734296605025028478437310371477981632161059979623052635510511498710159611855395568305343739696271");
      TestCommon.DoTestAdd("-96858341778714934262816","-43451382713344","-96858341822166316976160");
      TestCommon.DoTestSubtract("-512335976880013","-624025669422281","111689692542268");
      TestCommon.DoTestMultiply("-3525800322930278776930417","4857670425058408483732","-17127175953359801202504212478329790118240476244");
      TestCommon.DoTestDivide("4","473672568760235310729","0");
      TestCommon.DoTestRemainder("1089","801563192","1089");
      TestCommon.DoTestDivideAndRemainder("-1552","7471","0","-1552");
      //TestCommon.DoTestPow("-11073",14,"416595139667874738738192929627020110330549239049323777409");
      TestCommon.DoTestAdd("4274376131923994","39160","4274376131963154");
      TestCommon.DoTestSubtract("-2364322034534609189","6936760457678","-2364328971295066867");
      TestCommon.DoTestMultiply("71514517778267955666267","-82908592","-5929167976555164403008618866064");
      TestCommon.DoTestDivide("8552903739459014925","485577802","17613868888");
      TestCommon.DoTestRemainder("-536134615389959314","93329225007289","-51546948091298");
      TestCommon.DoTestDivideAndRemainder("-896127149993472618","87571681580019291759416","0","-896127149993472618");
      //TestCommon.DoTestPow("786454003345727100",26,"1938681718185956731202156289111530181943801369303287378030578530612816645382493398584019947796335561578126717424427731706916759713655101156565244793666560301050799312722038549245899026049817906599717832042942210352140612473547720185985330063640458669188748196910784854955519950995168733123989106835144053705476183816153641659651601889715591079699540155659225085086547710438614495716428441649829082943834664833815210000000000000000000000000000000000000000000000000000");
      TestCommon.DoTestAdd("-629413490919","938025287","-628475465632");
      TestCommon.DoTestSubtract("-8013343162057585657","9471514597739","-8013352633572183396");
      TestCommon.DoTestMultiply("20403778292","-4591760962598","-93689272650710096322616");
      TestCommon.DoTestDivide("5891147106770","-737317948722743","0");
      TestCommon.DoTestRemainder("-4721199186395","-23819559575699129281942","-4721199186395");
      TestCommon.DoTestDivideAndRemainder("-6348661","45944888317","0","-6348661");
      //TestCommon.DoTestPow("9750421048",2,"95070710613281418304");
      TestCommon.DoTestAdd("564","39723272092534","39723272093098");
      TestCommon.DoTestSubtract("-3496709","492700804","-496197513");
      TestCommon.DoTestMultiply("3375605004525821284","9981040","33692048574372403268455360");
      TestCommon.DoTestDivide("-861626954253027383","-301483281098","2857959");
      TestCommon.DoTestRemainder("-4688969135017360428","9222582939401701","-3897001801296320");
      TestCommon.DoTestDivideAndRemainder("-69928896552883235","-966141760381359557191","0","-69928896552883235");
      //TestCommon.DoTestPow("21054855009963394686025",27,"537663911599461900074421950602208793996718078754666486432919768263228859234874000223631668833289697469691701453827933861396095824241348760038903814444352602902449266025073240292839138237411617019321293459095200324008193730828563354890432723132782073769326725291070102815449120722595534886544931586597336916999729449371996594164770837781063186011724826370113493051165717011946380315542951799007287488923622174460444771548951039258106624293621170846283213872257119314740090333190266791992220165427764761737245489202716098746988524396994264940598961764273570159976238846954998962246463634073734283447265625");
      TestCommon.DoTestAdd("299470","-406979324","-406679854");
      TestCommon.DoTestSubtract("4464226475767324","10216336","4464226465550988");
      TestCommon.DoTestMultiply("-795048091","-2805","2230109895255");
      TestCommon.DoTestDivide("-25528344357733526617","-53193971868213504","479");
      TestCommon.DoTestRemainder("-1911760","345116","-186180");
      TestCommon.DoTestDivideAndRemainder("3606365553485940","1","3606365553485940","0");
      //TestCommon.DoTestPow("99444030774746",45,"778112457035924525857471829505373678824761889102749956290636755993343008119728049325807009812915673948577642649605330260873616528578512181710106078059417573151731924184280207447053243551061671559708387422723202611654172480064552153901215254861471705388046699835913047603073490081364536222323694237557277375136216936561010321683064520499393396607789363781692766571232987583177347651773135627396070627726016906893986074172585675409311051024932540567817136387156048566186450495321176871965468059532875300512145193469083214928305323079358147045864469993492326555700253849628310079832674272202482755103983807476419637089576751281995776");
      TestCommon.DoTestAdd("6943149148","5","6943149153");
      TestCommon.DoTestSubtract("9642039885376928368430991","6950938469481935353","9642032934438458886495638");
      TestCommon.DoTestMultiply("-7114339233009","881841623","-6273720455809231733607");
      TestCommon.DoTestDivide("-127360768438343","70263969","-1812604");
      TestCommon.DoTestRemainder("933024","631313875081222735848","933024");
      TestCommon.DoTestDivideAndRemainder("2","85262647118937","0","2");
      //TestCommon.DoTestPow("7390378",42,"3047890689397345224859940105121604728472486928127150160359028798030670438373988059480640581492881415276765765235618230928770106860627484969993817568605162288515268952087446269128332512897545583132454865000839903556538054856482574378097963189485565224473379940794445323103556865901759299584");
      TestCommon.DoTestAdd("2","62","64");
      TestCommon.DoTestSubtract("-173995843802505","249421832508675","-423417676311180");
      TestCommon.DoTestMultiply("-8574696279","6329696","-54275220738401184");
      TestCommon.DoTestDivide("-9934083540","-3959817","2508");
      TestCommon.DoTestRemainder("-633645543936","-90888822321719710673045","-633645543936");
      TestCommon.DoTestDivideAndRemainder("-645584413183801076746","-69061","9348031641357655","-64791");
      //TestCommon.DoTestPow("-2428929891300835545622",9,"-2942624289550787452589960403240198147506721576543910981406848917259250606193288180930602219929062645780707284730232243076233271415606827682581828596634126016418190452643008399357523099196872192");
      TestCommon.DoTestAdd("-32438681762496652508","15161117468961392862","-17277564293535259646");
      TestCommon.DoTestSubtract("-83799059491210380719601","820938341917","-83799059492031319061518");
      TestCommon.DoTestMultiply("-879805","5388671889899308279","-4740980472092860920405595");
      TestCommon.DoTestDivide("81657766308201547113552","646","126405211003407967668");
      TestCommon.DoTestRemainder("787917186809960207272224","760","144");
      TestCommon.DoTestDivideAndRemainder("-23230988154869","-522","44503808725","-419");
      //TestCommon.DoTestPow("-801091264873",1,"-801091264873");
      TestCommon.DoTestAdd("-5","673902020698","673902020693");
      TestCommon.DoTestSubtract("39723283708534312835","-1885537414490728953242","1925260698199263266077");
      TestCommon.DoTestMultiply("48117","-9","-433053");
      TestCommon.DoTestDivide("-23445242578357","-54726448362","428");
      TestCommon.DoTestRemainder("-4721887","672731049246","-4721887");
      TestCommon.DoTestDivideAndRemainder("-91444","-20615187486823694286","0","-91444");
      //TestCommon.DoTestPow("-821",48,"77351999022038966087609305359082283154396410843217063551993595731072491279520062723110289652420549919352531496197000304413205094460461034561");
      TestCommon.DoTestAdd("8212307853779450986","490133267216551","8212797987046667537");
      TestCommon.DoTestSubtract("7862514901271686770629852","-3335275228811","7862514901275022045858663");
      TestCommon.DoTestMultiply("-4938549073","746034526800084","-3684328120754548494522132");
      TestCommon.DoTestDivide("-853460341","2","-426730170");
      TestCommon.DoTestRemainder("-133648344489067","-2","-1");
      TestCommon.DoTestDivideAndRemainder("0","613518703583960916","0","0");
      //TestCommon.DoTestPow("-45382403622403",15,"-7133660064522446796135749108080042634711659311229433299499344647425889106535661713681336641782721007659583602064563366067338252531558633905936580622349250183898167966486886226136840838643114218861728332907");
      TestCommon.DoTestAdd("563368961","-2097965259425293","-2097964696056332");
      TestCommon.DoTestSubtract("52207183052232374918","-3948760","52207183052236323678");
      TestCommon.DoTestMultiply("-63206676979","9442920790296","-596855644130522669795784");
      TestCommon.DoTestDivide("543","1752105776546","0");
      TestCommon.DoTestRemainder("6009630818251926313","118620012108128901813466","6009630818251926313");
      TestCommon.DoTestDivideAndRemainder("121860006771388","-379139988534073237252923","0","121860006771388");
      //TestCommon.DoTestPow("45705418921",7,"416652370737952684762081490942697730854804720611246465182470513507650106841");
      TestCommon.DoTestAdd("-4373937675902120522","-20950790134204851","-4394888466036325373");
      TestCommon.DoTestSubtract("-245551792377","883013470911095700130329","-883013470911341251922706");
      TestCommon.DoTestMultiply("-3501202932675","93637472219704150623","-327843792343902014082117528306525");
      TestCommon.DoTestDivide("7249014392723974757722677","-77","-94143044061350321528865");
      TestCommon.DoTestRemainder("-61200","76719998180857","-61200");
      TestCommon.DoTestDivideAndRemainder("-226281012307212","1283434010712","-176","-396626421900");
      //TestCommon.DoTestPow("16938989294",44,"1177740786341916774660696779027870280909413560135837689760453963576612987991560749241173959389813906671899794505458714251972056709655483884746117101576478031252814676970901584582708832496235871741096963497151026511197635992870452773615079358329322592283922377045372786796882165161440306139469554366203720224713266664653143842282938207640944828081006375412944743199978014516482966868115108949381629123702569474009809582211124112758616831922926618935296");
      TestCommon.DoTestAdd("605647414394939422279359","8992984","605647414394939431272343");
      TestCommon.DoTestSubtract("-1233892","95760466181990","-95760467415882");
      TestCommon.DoTestMultiply("567785052491278847","67603058227993563054957","38384005964552305554746579883825072594579");
      TestCommon.DoTestDivide("-2017690","-43213060","0");
      TestCommon.DoTestRemainder("107283680","802157033","107283680");
      TestCommon.DoTestDivideAndRemainder("-950126295","921407995322776565261430","0","-950126295");
      //TestCommon.DoTestPow("1704",3,"4947761664");
      TestCommon.DoTestAdd("946040851693754","-7873908558740304","-6927867707046550");
      TestCommon.DoTestSubtract("-8971108982415789749","-532966989101016","-8970576015426688733");
      TestCommon.DoTestMultiply("-670028813496142428","-3361682167480","2252423914027764753977829841440");
      TestCommon.DoTestDivide("-2397965913931894","-3390566587927939317742157","0");
      TestCommon.DoTestRemainder("-10391251976082456210579","-21390524616618833","-13194149043184008");
      TestCommon.DoTestDivideAndRemainder("-84","9580881961","0","-84");
      //TestCommon.DoTestPow("5719",6,"34988117736893908981681");
      TestCommon.DoTestAdd("1090130242115932975","-65523","1090130242115867452");
      TestCommon.DoTestSubtract("6691182","-8","6691190");
      TestCommon.DoTestMultiply("39545407174","4672562295845","184778378535070773392030");
      TestCommon.DoTestDivide("-97233184740944607","-44847","2168109009319");
      TestCommon.DoTestRemainder("17580251","35917743445100787770038","17580251");
      TestCommon.DoTestDivideAndRemainder("-92893555366","7234","-12841243","-3504");
      //TestCommon.DoTestPow("2766784295260392875",13,"556773971692470859066733654388541146045201363620852878424013780067964086988714404161198924341995502238387661099279884965394345100637554350602085578961929526694330576068897962391796975303137688046456127240136712394814821891486644744873046875");
      TestCommon.DoTestAdd("-2676212717882","-1949579","-2676214667461");
      TestCommon.DoTestSubtract("-36515031480291","228","-36515031480519");
      TestCommon.DoTestMultiply("4","2563588262847713","10254353051390852");
      TestCommon.DoTestDivide("-262356549254","-56350290","4655");
      TestCommon.DoTestRemainder("-12028163801011","-21960000390","-16043587681");
      TestCommon.DoTestDivideAndRemainder("-4660858","7242172057564030","0","-4660858");
      //TestCommon.DoTestPow("-316749573063895474",31,"-332810625777476977202254830628400267896724232975277383973486732168858847303976545914425898925874041378103742118111769789193417499865782122690386831490568049985724012727376817801386823337250767537181491567601990206939594127378708791025408609666858708670463395124680263391501625283255006197771389829851374097975685992121630770081853265155842543837211245093514297632660343973056068861727660577799865790681496910801846229540583383767790400690678348440761616026972711131577260635656898918173355728943889524018467456353997752109755719533462997172224");
      TestCommon.DoTestAdd("-46211183508357","-269520980232220825854","-269521026443404334211");
      TestCommon.DoTestSubtract("851867045","-87392302660627","87393154527672");
      TestCommon.DoTestMultiply("53046701682216670","1294449584437406637","68666280948320448066125916330038790");
      TestCommon.DoTestDivide("-78999","55411946690","0");
      TestCommon.DoTestRemainder("-756414247388563109523","940456703056017295","-287058131525204343");
      TestCommon.DoTestDivideAndRemainder("97697065698465254271880","-2898832","-33702217202813151","2132248");
      //TestCommon.DoTestPow("-75800888878571480",12,"35982520455623624843065251555828220666608022549050686752200173849237482018910646560123528534064265022646774105145946573464995091490104638262983713026702831422411771328533494372125882445725696000000000000");
      TestCommon.DoTestAdd("-3768322966078","-828259101087","-4596582067165");
      TestCommon.DoTestSubtract("-9952138063859991","-368008394829307702618","367998442691243842627");
      TestCommon.DoTestMultiply("-229","-6318","1446822");
      TestCommon.DoTestDivide("-686278490861297","-97671772558","7026");
      TestCommon.DoTestRemainder("69","2067","69");
      TestCommon.DoTestDivideAndRemainder("-51755580077562071973","-638957420037603","81000","-29054516228973");
      //TestCommon.DoTestPow("-8",41,"-10633823966279326983230456482242756608");
      TestCommon.DoTestAdd("461135114901871549","92308619","461135114994180168");
      TestCommon.DoTestSubtract("19703482495125578582","35531683204380","19703446963442374202");
      TestCommon.DoTestMultiply("504047847832770054","11","5544526326160470594");
      TestCommon.DoTestDivide("542417265076956199627","-31641183","-17142761858080");
      TestCommon.DoTestRemainder("4645016490239783648952","-73599653918329066","68731800117964626");
      TestCommon.DoTestDivideAndRemainder("26995142702754576532779","90444","298473560465642569","22143");
      //TestCommon.DoTestPow("-87391",28,"2296507404849803036069084386595182779016210745672556521774894692170177741315887518284402832166403801474396611012009432911302230843334414721");
      TestCommon.DoTestAdd("7349","818787947","818795296");
      TestCommon.DoTestSubtract("-516604197790653447","-703695","-516604197789949752");
      TestCommon.DoTestMultiply("-1035015013639","457307546169736397040","-473320176136087339191390319228560");
      TestCommon.DoTestDivide("507258678947","-1905746","-266173");
      TestCommon.DoTestRemainder("-9","12209943995","-9");
      TestCommon.DoTestDivideAndRemainder("-258","1728923474067","0","-258");
      //TestCommon.DoTestPow("-633354",41,"-7370674395650980315140777056404214245614564234468148864055534759195774975686948047412025171238211733186706989835446399117899531005316998195425679098025494565927674190051667288944877581048239482038476358522693012496744499073895546490978304");
      TestCommon.DoTestAdd("263823143692782","-645","263823143692137");
      TestCommon.DoTestSubtract("917472193","-7473145977742373567788","7473145977743291039981");
      TestCommon.DoTestMultiply("-929974358854148","839647811013","-780850934710103503135131924");
      TestCommon.DoTestDivide("-7188096633536409879","8293331291239089785","0");
      TestCommon.DoTestRemainder("9802","8289830783750","9802");
      TestCommon.DoTestDivideAndRemainder("-66642183347","4953895652195","0","-66642183347");
      //TestCommon.DoTestPow("-65923253",8,"356704868392274973417716258221112943921492007212960062617438561");
      TestCommon.DoTestAdd("-42564","94940488","94897924");
      TestCommon.DoTestSubtract("-443168370","-47189512003198817281","47189512002755648911");
      TestCommon.DoTestMultiply("91901562920222881","8","735212503361783048");
      TestCommon.DoTestDivide("789869","0",null);
      TestCommon.DoTestRemainder("587900840","-32299258843570031960502","587900840");
      TestCommon.DoTestDivideAndRemainder("-623623063","1282989458679399843929","0","-623623063");
      //TestCommon.DoTestPow("350463",25,"4130992020992191652088359452367586130959611641995851474887588261256147329059160365309303246082916223685197567690894099153767634098280050943");
      TestCommon.DoTestAdd("-5847726676325666","1054700795","-5847725621624871");
      TestCommon.DoTestSubtract("975945634606256819","1007327329287877254675181","-1007326353342242648418362");
      TestCommon.DoTestMultiply("-583164476719386855606","-240369769599544095379808","140175110907677714956014469887031829424003648");
      TestCommon.DoTestDivide("508826","-1","-508826");
      TestCommon.DoTestRemainder("533","64250370938972036771","533");
      TestCommon.DoTestDivideAndRemainder("-158230190929977366747339","-618265880461616060","255925","-495472838276591839");
      //TestCommon.DoTestPow("983772388380550",38,"537026729712928094937569378021427461834514821129769236502783290452196264138790740559456342981753955480986730368120715974387372592112767949622995499540309649562528051312326716142897556135522937051661250700523642201136277208067911236715713254580213209557821318608581850658779699912162330108420157668287007262834698073610244358183413452455432786666852336419927223540803901237226960023859103447721272261222650473632716948284754273064132930269834917484026307387727513587873441409898398818104711081846466027545138786081224679946899414062500000000000000000000000000000000000000");
      TestCommon.DoTestAdd("3739518945130970127651","170894490781322067952","3910413435912292195603");
      TestCommon.DoTestSubtract("-5850909119939743127370667","-90951614568722387825587","-5759957505371020739545080");
      TestCommon.DoTestMultiply("7800","-92971230079723","-725175594621839400");
      TestCommon.DoTestDivide("810219038653","-97060949403440","0");
      TestCommon.DoTestRemainder("-4","8001","-4");
      TestCommon.DoTestDivideAndRemainder("547170914521","456424731389","1","90746183132");
      //TestCommon.DoTestPow("-20020096941550593807",11,"-207075127310623551737767494004238908252439934395996323915911686250443517965750902800888299773965735890495844405775658739185209667202387618257012145938343537477100669973309147924530326999121959144668574244658144943");
      TestCommon.DoTestAdd("-273514","-4148216949995027486900685","-4148216949995027487174199");
      TestCommon.DoTestSubtract("-882194","71936","-954130");
      TestCommon.DoTestMultiply("-94524464553949467404060","85279428980","-8060992361801060983993359733658800");
      TestCommon.DoTestDivide("-971043823918934376224982","-84165373438457662772343","11");
      TestCommon.DoTestRemainder("15532664269965877744","-888784814596070965357695","15532664269965877744");
      TestCommon.DoTestDivideAndRemainder("-645325047571873678960","7089251132083756778788","0","-645325047571873678960");
      //TestCommon.DoTestPow("-435179190869999741",4,"35865135953117033769624721414874400157778044871169496759750517579860561");
      TestCommon.DoTestAdd("55099807","-38944856193","-38889756386");
      TestCommon.DoTestSubtract("156149063","-4395","156153458");
      TestCommon.DoTestMultiply("262135072320792170511420","10253718","2687859109487008453032016459560");
      TestCommon.DoTestDivide("-92325599270656912","446872322020","-206603");
      TestCommon.DoTestRemainder("9748389518","95064042683891","9748389518");
      TestCommon.DoTestDivideAndRemainder("-3998340027143897889462745","-38008369385621277879","105196","-11601254081941703461");
      //TestCommon.DoTestPow("558425307",6,"30324283614875273349918923217044437397610264885570249");
      TestCommon.DoTestAdd("-9","1215449712876518393450","1215449712876518393441");
      TestCommon.DoTestSubtract("7887269989216","284051632","7886985937584");
      TestCommon.DoTestMultiply("-466736731609","89474843964052535987085","-41761196233007142132979905535269765");
      TestCommon.DoTestDivide("738117254","-864447820614681622","0");
      TestCommon.DoTestRemainder("-2763037509835936033356616","-7844783505582977018","-2776984038948915782");
      TestCommon.DoTestDivideAndRemainder("51975944198107811558","-248004492369014591501","0","51975944198107811558");
      //TestCommon.DoTestPow("-585743924",22,"7754814801227723842140990154859321557041226172073840021528577173046636807172494225862695554688778471641789557931352859784728716587965247399130475028024190109632933459824209280030591337183051776");
      TestCommon.DoTestAdd("24","-44097114","-44097090");
      TestCommon.DoTestSubtract("-33502612","593468042","-626970654");
      TestCommon.DoTestMultiply("269877","941509903330846","254091868181218725942");
      TestCommon.DoTestDivide("65494751597888","-49927","-1311810274");
      TestCommon.DoTestRemainder("88167423384901684262286","-3516741261","3431342124");
      TestCommon.DoTestDivideAndRemainder("-53104431","285351953940673385560","0","-53104431");
      //TestCommon.DoTestPow("9395",29,"16368419567122195959788203898128222832984822734394579195440311321936591125642104781944103020451776683330535888671875");
      TestCommon.DoTestAdd("-3721134918545259738","6821","-3721134918545252917");
      TestCommon.DoTestSubtract("8887476010333","-573834","8887476584167");
      TestCommon.DoTestMultiply("5223805253368100","-995","-5197686227101259500");
      TestCommon.DoTestDivide("6304187","-780538725037943871377856","0");
      TestCommon.DoTestRemainder("34321233809113","-70012131030767263553473","34321233809113");
      TestCommon.DoTestDivideAndRemainder("422389443157190494207597","-715409677118204","-590416172","181304497012509");
      //TestCommon.DoTestPow("-97202281114131463911",28,"45179434878398684748699855527747634968860073970867747602365763381397717078235138042327981700352842542677260827041775991538077670072429969790244125045955788349442434444367475220203694816690434709691771172551595012089673535224027445447231616143207218311193333748168239560435830523846423616260878288019566721369333600203693504305002410425381218467857756041727725296710321771439190778757348969149961157629377612367078317255167506980273802807687498577265118939965745045253837704197687728781333505309295980001807020629485155043680190962941633884834617247169441237281");
      TestCommon.DoTestAdd("-150384610241829","216107330405001","65722720163172");
      TestCommon.DoTestSubtract("92","-17845176302855510281008","17845176302855510281100");
      TestCommon.DoTestMultiply("-3238","-6","19428");
      TestCommon.DoTestDivide("-3680","-9969","0");
      TestCommon.DoTestRemainder("-258466820672488558468","74","-30");
      TestCommon.DoTestDivideAndRemainder("-4","7502655219344694096801","0","-4");
      //TestCommon.DoTestPow("-196521140338170846591",31,"-124648639029240228795113697808119758347679604382475677477516862164413730595782447232147861325665479416825134650835578676322976749934993802873239810968214739414242576121684708847999793913267507048503298431973138716274521483743787217987167402962966105810130682046023803266706804680848689744333613193193947915071819579406942654761592828695331647957896007082285162079939611095424439030625589376623830359931479884221903787180697627822885499851357020961453663937855228432448077680739419458236936017326310372340786968805756970191534951778288573606032677028429370188685612146560220005244443701261337089797241870422622765937880046076465791");
      TestCommon.DoTestAdd("-3208608533193027","458527002","-3208608074666025");
      TestCommon.DoTestSubtract("-351039517714469766","-927","-351039517714468839");
      TestCommon.DoTestMultiply("-642472321","-88318589260329211811433","56742249029529381936591973845993");
      TestCommon.DoTestDivide("-2","92452","0");
      TestCommon.DoTestRemainder("111581","9701","4870");
      TestCommon.DoTestDivideAndRemainder("-69488765","73136075030228073652385","0","-69488765");
      //TestCommon.DoTestPow("712407576",47,"119740447048398887733449018022986571135553069306346274938863672118747964805380893542604178119819268665301821863985777720212536071908440503922388450650957842370951201127766849018572687212213610036773579562500452869296259901303092024237799545696573853480914850917313283899399437268933933303596837804858903945878012850582725807624127638331907429233111634570345194412303576448194696256213703534104376997362366635652939776");
      TestCommon.DoTestAdd("-34816","-718699665505230203594499","-718699665505230203629315");
      TestCommon.DoTestSubtract("-31940818572890","94469713047305652","-94501653865878542");
      TestCommon.DoTestMultiply("-81324555","-6950469299345854678","565243822810463422783018290");
      TestCommon.DoTestDivide("25145","41944618886551348","0");
      TestCommon.DoTestRemainder("-458369815829950","23883281","-98751");
      TestCommon.DoTestDivideAndRemainder("8","-83757509875987139512272","0","8");
      //TestCommon.DoTestPow("9696085381575579824",36,"329208864674981171324559365634433506931129505386423894672921491509708870570338707112118530310191276340902716958673852402587700671747164361884738591461285931966380523332261018281903635991216401587119392133785749308616694373675593147749390862021564977705308880858175550752822297982000750055182026297688499536838590886776720083653010687908918837280831496336209434839012702249434247960122774740700787661499933555964034557576940415382530707042208909060068774335132810494170400034725664007012135593227380918200811427559474604850871349363747309319835684685769572243608926099498307262437908966234958575129185628528924482038981509002229081938515314552894224495311019329316965244243006168498176");
      TestCommon.DoTestAdd("-7058005698562562435562390","-96986508878991004","-7058005795549071314553394");
      TestCommon.DoTestSubtract("-2097","7047749580528906266039","-7047749580528906268136");
      TestCommon.DoTestMultiply("740","77969306","57697286440");
      TestCommon.DoTestDivide("6581544488502623555","-9592610252974943014190","0");
      TestCommon.DoTestRemainder("71300214577","265958065552722","71300214577");
      TestCommon.DoTestDivideAndRemainder("-85839467957873108864612","9","-9537718661985900984956","-8");
      //TestCommon.DoTestPow("516207885623238",15,"49245836460318140065138092022141369866716416300945017734484082302768250759765754306125022756054665323717334690122801954376221394821781546797056669817279468326974444355223781929190091586870554370848516024771896051377733632");
      TestCommon.DoTestAdd("2694694475046930","99039557986673188","101734252461720118");
      TestCommon.DoTestSubtract("-98090","513355405744","-513355503834");
      TestCommon.DoTestMultiply("-3873342423","3930572608668642944363","-15224453631838032266240836611549");
      TestCommon.DoTestDivide("44598677815232","-55539428040","-803");
      TestCommon.DoTestRemainder("673004214","32200","24214");
      TestCommon.DoTestDivideAndRemainder("819800707","-794604","-1031","563983");
      //TestCommon.DoTestPow("21499917391980",10,"21104152308623394734369522786887380444062645593583164551954065251529225478831645884781265754923456920069506284655703080970240000000000");
      TestCommon.DoTestAdd("9973146","7789","9980935");
      TestCommon.DoTestSubtract("46402034","792533964389019795","-792533964342617761");
      TestCommon.DoTestMultiply("883226389","9010821570227","7958595397394903120303");
      TestCommon.DoTestDivide("5703","-758595867","0");
      TestCommon.DoTestRemainder("-8539589478290665470","5232668935949","-4591545296195");
      TestCommon.DoTestDivideAndRemainder("362220700196991236950","-407809","-888211638774502","350832");
      //TestCommon.DoTestPow("-196",1,"-196");
      TestCommon.DoTestAdd("4695282637056162099","-4374","4695282637056157725");
      TestCommon.DoTestSubtract("-663661756513810924","7112055","-663661756520922979");
      TestCommon.DoTestMultiply("483556282","610803881950228","295358054187019160732296");
      TestCommon.DoTestDivide("112641498707","-106476","-1057905");
      TestCommon.DoTestRemainder("368","1305203717","368");
      TestCommon.DoTestDivideAndRemainder("29309937678874476139","2761769810919757331947249","0","29309937678874476139");
      //TestCommon.DoTestPow("8115758275593",42,"155532924322434336825726382897033577702544968217310977333926401233275219513623299311985973127352139142480006917683539865331406803482758523898252353938316231732980436243540366410218894575184836881564130706178488040497988896077363256807424441907289348501714319216232753050212007685348592177482544407996823731149650464743396498955441314989301434076947573664996617972910698709632373929924757821108660601235616614980749601370410060221394443381290705895920047141582555760847158722280928522461305908300980128584608096044128806190216509547393340309649");
      TestCommon.DoTestAdd("-178524836263","728710147770973075435011","728710147770794550598748");
      TestCommon.DoTestSubtract("49301173","-97589","49398762");
      TestCommon.DoTestMultiply("8746760162642644519","64183992431392","561401988078256554749075552340448");
      TestCommon.DoTestDivide("-8410106857698","-7897143","1064955");
      TestCommon.DoTestRemainder("-569364","-843783536360659905","-569364");
      TestCommon.DoTestDivideAndRemainder("7290744504","91972486761","0","7290744504");
      //TestCommon.DoTestPow("-68713688807671350997335",38,"6421611404863870292824574792498896802683043897691090271966446324508033275794080970574793760321130668600248952867492785254440365449267110027587886354439416123037392976279496318707685322079317738013930217552628322125054366649777809697676400997515022601190806369756308577741778685612969270642871964871169191501695836786779287350947349343248024529272039340743600794380376809291800842385830139026809193404497251216284438371184338701442177414262902149689241463713832765325751001708021975087173303123370849294819257028241857683418833335855082704918006120567344682280574727378328431112368779634818557258712856189518690570816332128005617567347746534813929550407864539183892937019666862309760797664017911677630318300020082869296165234076924559037344003803824701130201388406866187527476430778811725879175808540411708898927765461048768962737958935661884970613755285739898681640625");
      TestCommon.DoTestAdd("-737857449910","7287262782190900391635174","7287262782190162534185264");
      TestCommon.DoTestSubtract("4515912","597897044068074","-597897039552162");
      TestCommon.DoTestMultiply("-4386802363052089939323","-3089224476729829271103863","13551817234516771074612977059024218540900904749");
      TestCommon.DoTestDivide("-3050989069016751872","-21785841","140044585334");
      TestCommon.DoTestRemainder("258415","3362863745007592267876303","258415");
      TestCommon.DoTestDivideAndRemainder("-27772458316389","2917748882109156829611","0","-27772458316389");
      //TestCommon.DoTestPow("3374052169",4,"129600648046995755099966821936720002721");
      TestCommon.DoTestAdd("-12316110","336174574513259","336174562197149");
      TestCommon.DoTestSubtract("1272","-3413027818571","3413027819843");
      TestCommon.DoTestMultiply("-364713473391076270","315454","-115050324035108573676580");
      TestCommon.DoTestDivide("-254959969896","-65","3922461075");
      TestCommon.DoTestRemainder("-9833700","-510195594637732275","-9833700");
      TestCommon.DoTestDivideAndRemainder("-3662778163291149780","-319991684529","11446479","-66155326389");
      //TestCommon.DoTestPow("-148216027136344715634",34,"64630231667659722594827027173976281011962218806099289936869431434716049825493683724088384333401698813948650469289980018388420363715111558094089320351272712786200172870487745039654326377198147411049334249674184766685326565501147164061766295923244231940488816981547922578241806051937611511399179790526602575108644715225982757570811702732304216289070789504264766223985700255370796603626278426120931364024164571920517669941165980751513399366546219123542663744543922258294792967343286245333147182959935989339268872927046755937328519772708437488385937821063671635149336968948005653102011921635171133601333784855851406878327385959529608776779234799465772977257239097106582102904424261155291136");
      TestCommon.DoTestAdd("-7365572261595796580","-45697","-7365572261595842277");
      TestCommon.DoTestSubtract("43312844991585","776905390099023334810629","-776905390055710489819044");
      TestCommon.DoTestMultiply("7007603844675448008087","-3156478366936087435","-22119349939776205837342787079208019086845");
      TestCommon.DoTestDivide("-2823460990427735985899","-97994300288570812","28812");
      TestCommon.DoTestRemainder("610803916114750","7496449699260284","610803916114750");
      TestCommon.DoTestDivideAndRemainder("-6593205108210","-14013453982747","0","-6593205108210");
      //TestCommon.DoTestPow("-980273899",2,"960936917060662201");
      TestCommon.DoTestAdd("-4861105861830001","-26268173962109939","-31129279823939940");
      TestCommon.DoTestSubtract("-35617804","-43426077672350874702151","43426077672350839084347");
      TestCommon.DoTestMultiply("-9","-481708555","4335376995");
      TestCommon.DoTestDivide("-1","0",null);
      TestCommon.DoTestRemainder("40618389222105633724973","180106790435021909","165522828187741566");
      TestCommon.DoTestDivideAndRemainder("393604","-1624092152268","0","393604");
      //TestCommon.DoTestPow("542957",4,"86908398354678120214801");
      TestCommon.DoTestAdd("3567221742973347317581895","932582","3567221742973347318514477");
      TestCommon.DoTestSubtract("-609262343903123576230","97113853455958","-609262441016977032188");
      TestCommon.DoTestMultiply("-21169","6037093","-127799221717");
      TestCommon.DoTestDivide("-8","8511","0");
      TestCommon.DoTestRemainder("70118","-72839969535227920","70118");
      TestCommon.DoTestDivideAndRemainder("17174422298360381707","-2257543984638934960704","0","17174422298360381707");
      //TestCommon.DoTestPow("3641609230",23,"8123568487403536018237590290311330835540860356331472138772702965573114861467031320478857313043771784560361650525959558108262675665088144539251894590679380139034707642908361933279716845138480353086700000000000000000000000");
      TestCommon.DoTestAdd("-1254096393","440967234247","439713137854");
      TestCommon.DoTestSubtract("3271","-4087","7358");
      TestCommon.DoTestMultiply("-19140107211551416306132","62","-1186686647116187810980184");
      TestCommon.DoTestDivide("9017500707831080459798846","-759312","-11875883309931991671");
      TestCommon.DoTestRemainder("-3870","3768671209","-3870");
      TestCommon.DoTestDivideAndRemainder("-185732918567584229474","7392508053856121","-25124","-3546222503045470");
      //TestCommon.DoTestPow("-9107775127078",48,"11266534841246471800325807713705028177700144124740302737044687470643889821522669872940150946168987119399978569243091383932291042743887857771197689063091680457776963929401473396564747094311059483422513295177123387395405367813754895522557631244618856803548822300941113657773105047135242956052250757237555975016436094875319058538807147539047999162135404028483471363128035428827988151346439969717130947864283583917086720955294924007000062090564101903790700486136272698326408051926947995414176720606893519061386008063651882666644986543366811245831467658573309381754202095596414572569805029416394801341402024759776596812613287936");
      TestCommon.DoTestAdd("-5174858158898844400486","-9257533951328302898","-5184115692850172703384");
      TestCommon.DoTestSubtract("6563892945","-11549","6563904494");
      TestCommon.DoTestMultiply("-2871708995267210","8","-22973671962137680");
      TestCommon.DoTestDivide("65125958","-7828915279304","0");
      TestCommon.DoTestRemainder("-58106985838795211265","-729351585849045292","-488210556720633197");
      TestCommon.DoTestDivideAndRemainder("-459343801120430415","-32353012967","14197867","-25965689026");
      //TestCommon.DoTestPow("-65406105289",32,"12583030595507574656807117664875334356177459037287331994028242170465458836955722110011000731321620241868594416401376030656001890920839189730181965093484169056684669562079862465045009139021246516705587255260427893194567175697641283485390278142172321374351850906583139345157798416434622763472588136013941922101830758935254700063217951821724460504321");
      TestCommon.DoTestAdd("8389","54661","63050");
      TestCommon.DoTestSubtract("6357432972253767","668260785445","6356764711468322");
      TestCommon.DoTestMultiply("89948518227355","778872127155936193","70058393726264487932449847159515");
      TestCommon.DoTestDivide("-583116338436036981171839","-183519076182256780375404","3");
      TestCommon.DoTestRemainder("-62545050173338","4865967","-2721148");
      TestCommon.DoTestDivideAndRemainder("1","-56562533049004799672","0","1");
      //TestCommon.DoTestPow("-3293",54,"8911554315466336073294870527573666856387844063577522172720784968624009273936196357625241573465076228206522498990638412949335920964371062877966258289890963187984101887078756368889774287711449");
      TestCommon.DoTestAdd("-725887345782076681163","-291467525395748679","-726178813307472429842");
      TestCommon.DoTestSubtract("-76490566852","58412866","-76548979718");
      TestCommon.DoTestMultiply("-695462245","-789583064865680817853171","549125210905467005037602384028895");
      TestCommon.DoTestDivide("476342032503765305362","110407973838289","4314380");
      TestCommon.DoTestRemainder("568040","-6001067509068578770235","568040");
      TestCommon.DoTestDivideAndRemainder("-37842179715640396","-79899829885994878051","0","-37842179715640396");
      //TestCommon.DoTestPow("-8557909342",43,"-12354076999120033454681258096826358929186943220679837789294071517655077307649855461564060532492205910067421998976211710889515833874457912398907310344955058431965944985165742570412108826851908133837343112683945331605299456390329820080565240346446100206996024861386593523219797636380802447551358762300453836478885455723991300742044202895391355782302524198062344452729031956586684151004056880359524024777486429284983440868573708288");
      TestCommon.DoTestAdd("-57517772553237650","145945328836474679","88427556283237029");
      TestCommon.DoTestSubtract("17331890810","-936918431633892958","936918448965783768");
      TestCommon.DoTestMultiply("-801415","-762217712006015162","610852707667300641054230");
      TestCommon.DoTestDivide("446863244718","486563","918407");
      TestCommon.DoTestRemainder("-365574713401610476145","-116184732543","-33705451304");
      TestCommon.DoTestDivideAndRemainder("-71982011701","-8","8997751462","-5");
      //TestCommon.DoTestPow("357718222602387",4,"16374357075414958497722041171875945457641157254547082777361");
      TestCommon.DoTestAdd("-220","-37","-257");
      TestCommon.DoTestSubtract("48846877790328519","4575718255253319487046132","-4575718206406441696717613");
      TestCommon.DoTestMultiply("965119320630527","255831446060652547","246907871417982299107193108502269");
      TestCommon.DoTestDivide("52369690711465500645080","877796312264","59660413218");
      TestCommon.DoTestRemainder("-607684434186683","-67476792802239284510","-607684434186683");
      TestCommon.DoTestDivideAndRemainder("979348","-805568","-1","173780");
      //TestCommon.DoTestPow("7137409",46,"1831752829604574944559989809152029051491666267092602541488231421820799840213662722591753958729364988738405191424863785910561493420527760017381483177566256359730401337888395851100303758911810856487625834925147844754207285225095909284318236113023040357014921521279066036201652537994083941696526506102576632580065232641");
      TestCommon.DoTestAdd("780","-646536358","-646535578");
      TestCommon.DoTestSubtract("-71318297862570213","-191486189","-71318297671084024");
      TestCommon.DoTestMultiply("-936","241","-225576");
      TestCommon.DoTestDivide("-86377144","37371977111628688","0");
      TestCommon.DoTestRemainder("-2441020382709726980458","333449408780434555","-170710436946037858");
      TestCommon.DoTestDivideAndRemainder("4094715093","-83204523126323245120","0","4094715093");
      //TestCommon.DoTestPow("-56498488655329888469",53,"-721027812979458213057798937319920009061227396703465232543023534527306146594199397237677503820102690787302481551121108648077054493574645409265043226060151431179646194678537548337741569792802952490855787029571097101887067295137609011930625895339460543186864829927907692145095076168241564628312748637290081621860260257254571700829714135771611628352785278924378931475523475349128676885139004078935066947064493878122317283711944750766637219498967617079911264088475198091366827862732287407850813536623944331446357806358419856215183695737029455857758179972270518742279234827326150684086779454756246056043178902598831639437549330351693941484930126636891818201797893852278598509268621312363612753883055879657484623474602207720115092757844334550804702343089113713502157277263436110186850102722904156178147421671154397748110205151749134470801981248199405725673217235517944417768833311188055752817818327492156459102041033423736190618625765059760007398885537465986412232515279845337732226449845759965670279587809015971419333193769239044647958363798539949976709");
      TestCommon.DoTestAdd("4946734588514788","83323222247","4946817911737035");
      TestCommon.DoTestSubtract("642181024505405832972386","-83747909722","642181024505489580882108");
      TestCommon.DoTestMultiply("9835975320","-684380470887","-6731549421134510508840");
      TestCommon.DoTestDivide("15308","11","1391");
      TestCommon.DoTestRemainder("-58","4","-2");
      TestCommon.DoTestDivideAndRemainder("6977948749073918209","-2","-3488974374536959104","1");
      //TestCommon.DoTestPow("45283920",30,"47678264055540770168897693505633524578169497414766563275460383603720556880615648990168429299158444407799015216628449311773353143261348392412902249229483438838514020128571467609819190498955621746868224000000000000000000000000000000");
      TestCommon.DoTestAdd("80941469669695885385126","756484325382240","80941470426180210767366");
      TestCommon.DoTestSubtract("-843","45641821084499","-45641821085342");
      TestCommon.DoTestMultiply("-2891620661777743","856636312763565209912","-2477067261616226064800014688884588616");
      TestCommon.DoTestDivide("5053146506","-504","-10026084");
      TestCommon.DoTestRemainder("-15329379638","-514499342","-408898720");
      TestCommon.DoTestDivideAndRemainder("-79246390743","-74331044214796","0","-79246390743");
      //TestCommon.DoTestPow("6860842693607",28,"262161511590585836478759077296544532716287967818650312783161675716645888226441735800689873862158144367385031115069169716288835940174064735062886527278734038281359413129140679556533126450909441296001152680540290331683140526842170629204148979097379796331503645016886223016894203427665495528932042699091998997403640136327462532850193195391170566064462644826791201");
      TestCommon.DoTestAdd("-379872536753529530181895","5192162071455518672798","-374680374682074011509097");
      TestCommon.DoTestSubtract("-74843984849","-55091485980426","55016641995577");
      TestCommon.DoTestMultiply("-162842203","-5944954261","968089448595476983");
      TestCommon.DoTestDivide("578073546125014","-82","-7049677391768");
      TestCommon.DoTestRemainder("234323565159808990","-3414947331122775306291017","234323565159808990");
      TestCommon.DoTestDivideAndRemainder("7359930367","61316900446","0","7359930367");
      //TestCommon.DoTestPow("-27",52,"269721605590607563262106870407286853611938890184108047911269431464974473521");
      TestCommon.DoTestAdd("-9774806","-283782759483315540020475","-283782759483315549795281");
      TestCommon.DoTestSubtract("5234282923778569484425746","40029291642407","5234282923738540192783339");
      TestCommon.DoTestMultiply("-8","154364021588247769","-1234912172705982152");
      TestCommon.DoTestDivide("18629010852458279701","-23752794365016","-784287");
      TestCommon.DoTestRemainder("2578062893716252458363849","-32815921","26907026");
      TestCommon.DoTestDivideAndRemainder("766","94530845678867381424","0","766");
      //TestCommon.DoTestPow("-774646117801772052",17,"-13024376085918071504476437214331855809085300136008854724938705844781196661858424278963582196112391801107829138407240116631913062590254332953353002296409231735554181951672331775233129468237212692200159788297708851909383659547258402470739140049829737610711990055143922620146710642912473569189341123861020672");
      TestCommon.DoTestAdd("-694231139","-373901041810","-374595272949");
      TestCommon.DoTestSubtract("75","39708327","-39708252");
      TestCommon.DoTestMultiply("61","-77802","-4745922");
      TestCommon.DoTestDivide("-649303","2238789237824","0");
      TestCommon.DoTestRemainder("234858992176267064388369","8184701573831596945458","5687348108982349915545");
      TestCommon.DoTestDivideAndRemainder("9774032","8042375082323240782455586","0","9774032");
      //TestCommon.DoTestPow("-662557072",1,"-662557072");
      TestCommon.DoTestAdd("10","-93371","-93361");
      TestCommon.DoTestSubtract("-7097","-52","-7045");
      TestCommon.DoTestMultiply("-3240699584624781276","681821832528823","-2209579729464263878641648340718148");
      TestCommon.DoTestDivide("1","2771483954","0");
      TestCommon.DoTestRemainder("-44","-1664493","-44");
      TestCommon.DoTestDivideAndRemainder("-244918414929031355069953","44507085206460788285963","-5","-22382988896727413640138");
      //TestCommon.DoTestPow("-982661",21,"-692593036948373413578773683627369592963236178671298967827177317094181463161664075777748870340415320917361281069681488296191861");
      TestCommon.DoTestAdd("-3324450","-787813789693163460","-787813789696487910");
      TestCommon.DoTestSubtract("1610835081024195781782","1","1610835081024195781781");
      TestCommon.DoTestMultiply("-701937135287","699181","-490781108187099947");
      TestCommon.DoTestDivide("57924390498457547109","93101758185946550453973","0");
      TestCommon.DoTestRemainder("6","6","0");
      TestCommon.DoTestDivideAndRemainder("98161858169192740","-7617499979509180443419","0","98161858169192740");
      //TestCommon.DoTestPow("-893983071",37,"-15819177826700451174613843631474126280871396661413403960982028515997877816224700582433490542214943843404336005306121688997389655005713134316957932231149795792491561044615815960950536227787335550173091246339587078257366151987573076815753445121597729315954114035294778183860131373493155375373239212111311935699217101782363429746016991");
      TestCommon.DoTestAdd("18","-7174581705417769020861017","-7174581705417769020860999");
      TestCommon.DoTestSubtract("-13414491780270","36010","-13414491816280");
      TestCommon.DoTestMultiply("-33837","1515","-51263055");
      TestCommon.DoTestDivide("-1092432361623","563503695330","-1");
      TestCommon.DoTestRemainder("99369190053795","-1564","283");
      TestCommon.DoTestDivideAndRemainder("1851158062886007","563689391124273636604482","0","1851158062886007");
      //TestCommon.DoTestPow("-6796301628736966569339",31,"-63161436770475562869074286030578916896590564401601436486742463304166994108175954874440278245409251408370604105689197309332595474716304601059003421591553815537581230406148242831220047909013072693003901684459538776337717433469245013788040936339983698206777980774278532911022242802949044357441766231886744979887036396671824070456977486373404063653853842658560386405641087295149608622008978770265467803450662539871640026031209254752494001231685553180647032811523490324405373188829654468831032158473358363674730836972602995455910013402595043051774180837034317508245803208305184414393550625969781360232561443341001508698343699783524071694315962128266042022580478593871442791200575539");
      TestCommon.DoTestAdd("368608189175038204107","-37338","368608189175038166769");
      TestCommon.DoTestSubtract("74020046585375","74974272184","73945072313191");
      TestCommon.DoTestMultiply("90335676156835","50586","4569720514069655310");
      TestCommon.DoTestDivide("-76778166931092203571","9","-8530907436788022619");
      TestCommon.DoTestRemainder("-2626621729093897","-4531719","-948709");
      TestCommon.DoTestDivideAndRemainder("350890520","-1549105741991","0","350890520");
      //TestCommon.DoTestPow("3828026956293997016783",16,"2126178868273533274101706699371662341196664810625013751648186914599590038485296835202794262199588676744878718446656128638202333453232563063905134354593004621019395004540059601524943681271530588063975780568766201150782931257487548977503469459284162058516604565768353053811516741964343529806104551253378340477783552137540044573227163958812320910081");
      TestCommon.DoTestAdd("-3432564043530732165829","-55121334706673","-3432564098652066872502");
      TestCommon.DoTestSubtract("1736200","904538719899622145207","-904538719899620409007");
      TestCommon.DoTestMultiply("14361","8122313147","116644539104067");
      TestCommon.DoTestDivide("2245251825497639067491715","-2304298931654912214","-974375");
      TestCommon.DoTestRemainder("-65508009851304047808934","747740994945","-203599116664");
      TestCommon.DoTestDivideAndRemainder("89187176","-636744850183127","0","89187176");
      //TestCommon.DoTestPow("97310601915512162668613",24,"519809022624586938978593752043647400291813104946523184011236184003423109278752564194781443406038680426883731249443502458229896857136157201100942533552041031476999902718608460941201400457796487918219529503092387058935863965226911048746157341244171215357282396258719947409955068429103582846215917015794375660449869356178890758321401597963686488248840865875361188964490689252346919446669085399713197444331384020148194719627326534834838099710187421180594798417082919902627339474857822787774793914154145938779298034227703723255628654508937397447753646816161");
      TestCommon.DoTestAdd("254104324642645232104","-679391635330","254104323963253596774");
      TestCommon.DoTestSubtract("-52370449376417","-8","-52370449376409");
      TestCommon.DoTestMultiply("-130993806149","-356510636556767005","46700685215173729887129313745");
      TestCommon.DoTestDivide("13536566337","-64","-211508849");
      TestCommon.DoTestRemainder("-63219291041","13945847932538287991","-63219291041");
      TestCommon.DoTestDivideAndRemainder("-8483172213175615","789386825206377349851184","0","-8483172213175615");
      //TestCommon.DoTestPow("610675",5,"84927962560946474129951171875");
      TestCommon.DoTestAdd("1502491788748197841326523","7872806375829","1502491788756070647702352");
      TestCommon.DoTestSubtract("-1024337910","714928","-1025052838");
      TestCommon.DoTestMultiply("31696866959300697294912","1055","33440194642062235646132160");
      TestCommon.DoTestDivide("-35391924","474952525009065789","0");
      TestCommon.DoTestRemainder("-58235645393451368","-1","0");
      TestCommon.DoTestDivideAndRemainder("-3013047531125885","778523466","-3870207","-563348423");
      //TestCommon.DoTestPow("-580294009194",9,"-7461614082122302722413492716814593547299616165757612732119772480948061982267962096758451795186791160687104");
      TestCommon.DoTestAdd("1800886","9383991804827861","9383991806628747");
      TestCommon.DoTestSubtract("-985488252671415359573","74170703373","-985488252745586062946");
      TestCommon.DoTestMultiply("85845073755","-1","-85845073755");
      TestCommon.DoTestDivide("20229501416589386904","439084705688040","46071");
      TestCommon.DoTestRemainder("58061930455","-240577898166337478991","58061930455");
      TestCommon.DoTestDivideAndRemainder("6118920143036021077587","798505614928807413078389","0","6118920143036021077587");
      //TestCommon.DoTestPow("-13633816528508805",20,"49243499347149147296070611685145457545871494064469700753823455844820748259961775286131719483851422260421776730693707112805806549724256628435202811106662780482743861993728281157222766163131182370174636528747557638530394260077240105273320320142433534517391051959482204794503271842190294371907777192206926805420017242431640625");
      TestCommon.DoTestAdd("-641649713108822","673410279812834051","672768630099725229");
      TestCommon.DoTestSubtract("3482209792048809122723","1781","3482209792048809120942");
      TestCommon.DoTestMultiply("717199600","-92210138072028845768587","-66133074141203859373692288965200");
      TestCommon.DoTestDivide("-24","-8804161367024456594954783","0");
      TestCommon.DoTestRemainder("92843261697","-90860010","75191487");
      TestCommon.DoTestDivideAndRemainder("-3077096663932704326909","885986556","-3473073765165","-213205169");
      //TestCommon.DoTestPow("50558245677013837",43,"18325499666232185474499578443268343486121423553982365958270350453710617085914208813950632156294245543045531944900841481639462433234205937512503841269123666341021640804334616534257041888233042836183742822465902342039420144626765500265143681663434693981819118870053710212895008122679537837280106202220865498821037762212391278117299869880521875325312532794320074200265428770795338825573653004844866408903392184031311291171336773978849943819403839068474183578376421397284777269830927210909686290033471228526692778528416571843077659082763955029443272028644847665293784074753138099210671832410583773896770576068023170636144531268631350854213254902089458826540371288439155741423694448137156265253939018199374458811693721096053");
      TestCommon.DoTestAdd("2350390627887911998","-66093904303","2350390561794007695");
      TestCommon.DoTestSubtract("10582403320878714619","380672448753604","10582022648429961015");
      TestCommon.DoTestMultiply("25633445245140426005707","9313171316","238728666987298403868370884700412");
      TestCommon.DoTestDivide("82849925521160","821912365","100801");
      TestCommon.DoTestRemainder("75473","78844399257495120","75473");
      TestCommon.DoTestDivideAndRemainder("-456498858871851323281","-1288943723278309364","354","-212780831329808425");
      //TestCommon.DoTestPow("-45118",38,"733320652933198396988999998065850508927620206252422516226504491637494301792808371820649896474330118786837483371209081826193461349204347003160686091730902477321647871591735885824");
    }

    [Test]
    public void TestBitLength(){
      Assert.AreEqual(0,BigInteger.valueOf(0).bitLength());
      Assert.AreEqual(1,BigInteger.valueOf(1).bitLength());
      Assert.AreEqual(2,BigInteger.valueOf(2).bitLength());
      Assert.AreEqual(2,BigInteger.valueOf(2).bitLength());
      Assert.AreEqual(31,BigInteger.valueOf(Int32.MaxValue).bitLength());
      Assert.AreEqual(31,BigInteger.valueOf(Int32.MinValue).bitLength());
      Assert.AreEqual(16,BigInteger.valueOf(65535).bitLength());
      Assert.AreEqual(16,BigInteger.valueOf(-65535).bitLength());
      Assert.AreEqual(17,BigInteger.valueOf(65536).bitLength());
      Assert.AreEqual(16,BigInteger.valueOf(-65536).bitLength());
      Assert.AreEqual(0,BigInteger.valueOf(-1).bitLength());
      Assert.AreEqual(1,BigInteger.valueOf(-2).bitLength());
    }

    [Test]
    public void TestAdd(){
      TestCommon.DoTestAdd("335104030856920274353771469482036822016",
                           "11220305413346585490818414845644062848",
                           "346324336270266859844589884327680884864");
    }

    [Test]
    public void TestSquaring(){
      TestCommon.DoTestMultiply("390625","390625","152587890625");
      TestCommon.DoTestPow("5",68,"338813178901720135627329000271856784820556640625");
    }

    [Test]
    public void TestDivide(){
      TestCommon.DoTestDivide("43569", // 43569
                              "334558199138390434829164799015810366752", // 334558199138390434829164799015810366752
                              "0");
      TestCommon.DoTestDivide("833272832730475642197827", // 833272832730475642197827
                              "576734746886592117601685404914135826", // 576734746886592117601685404914135826
                              "0");
      TestCommon.DoTestDivide("1176845874825103014377456884685643370208171580545915667079", // 1176845874825103014377456884685643370208171580545915667079
                              "72", // 72
                              "16345081594793097421909123398411713475113494174248828709");
      TestCommon.DoTestDivide("9126440073362022353", // 9126440073362022353
                              "82743614979513280142683241749715085686833736691479460036660", // 82743614979513280142683241749715085686833736691479460036660
                              "0");
      TestCommon.DoTestDivide("1508557146551837567", // 1508557146551837567
                              "12460369537138174699059543147", // 12460369537138174699059543147
                              "0");
      TestCommon.DoTestDivide("55411734099", // 55411734099
                              "51660934724301252611081245143385753310", // 51660934724301252611081245143385753310
                              "0");
      TestCommon.DoTestDivide("426475990353422835626019301115321", // 426475990353422835626019301115321
                              "7461578", // 7461578
                              "57156273157423648942089635");
      TestCommon.DoTestDivide("927075005348451446758598274071516665265273802100", // 927075005348451446758598274071516665265273802100
                              "743699551102358520373659", // 743699551102358520373659
                              "1246571957686786590019715");
      TestCommon.DoTestDivide("22209706229752449", // 22209706229752449
                              "4031915733837283707093248746004561", // 4031915733837283707093248746004561
                              "0");
      TestCommon.DoTestDivide("45101438808264724967839658787", // 45101438808264724967839658787
                              "751005672976810082803331", // 751005672976810082803331
                              "60054");
      TestCommon.DoTestDivide("1447731260503552142386826104874341753981079717", // 1447731260503552142386826104874341753981079717
                              "2280721331466043815180200117394260396236820992973622875", // 2280721331466043815180200117394260396236820992973622875
                              "0");
      TestCommon.DoTestDivide("1994458623057324", // 1994458623057324
                              "9095236316543887", // 9095236316543887
                              "0");
      TestCommon.DoTestDivide("11062449725548093142869805683376852459253788", // 11062449725548093142869805683376852459253788
                              "4222307502652794452555", // 4222307502652794452555
                              "2620000963595799008232");
      TestCommon.DoTestDivide("134893350935955217906329622488647617783", // 134893350935955217906329622488647617783
                              "3641987330450989028074697710", // 3641987330450989028074697710
                              "37038391047");
      TestCommon.DoTestDivide("389427829745286709131546623179879443091344728899803558106616", // 389427829745286709131546623179879443091344728899803558106616
                              "535243612076408164134228808274615134805585696382", // 535243612076408164134228808274615134805585696382
                              "727571186201");
      TestCommon.DoTestDivide("712902792505088904593802362030688604408488667556548312", // 712902792505088904593802362030688604408488667556548312
                              "1506182499829057076819874890076967", // 1506182499829057076819874890076967
                              "473317670724496673424");
      TestCommon.DoTestDivide("42457337294559", // 42457337294559
                              "951402653467437296624727967896776742329851313437", // 951402653467437296624727967896776742329851313437
                              "0");
      TestCommon.DoTestDivide("461561672668649645167943", // 461561672668649645167943
                              "3283018649879244544638794960459737344724698", // 3283018649879244544638794960459737344724698
                              "0");
      TestCommon.DoTestDivide("17360503477631601292", // 17360503477631601292
                              "5087852475367423879552745752203219643439566038", // 5087852475367423879552745752203219643439566038
                              "0");
      TestCommon.DoTestDivide("551354247", // 551354247
                              "52601521242333166883560311", // 52601521242333166883560311
                              "0");
      TestCommon.DoTestDivide("3085309280766013540267687953187221", // 3085309280766013540267687953187221
                              "241900694612150", // 241900694612150
                              "12754445727048553190");
      TestCommon.DoTestDivide("1030168054235155257478", // 1030168054235155257478
                              "323724078793634014542078208861775769573195498341293", // 323724078793634014542078208861775769573195498341293
                              "0");
      TestCommon.DoTestDivide("215001220943843805640182638357432174855", // 215001220943843805640182638357432174855
                              "15786219895", // 15786219895
                              "13619550619077690583517786374");
      TestCommon.DoTestDivide("37680874693269194465745530841", // 37680874693269194465745530841
                              "29", // 29
                              "1299340506664454981577432097");
      TestCommon.DoTestDivide("261190815634209", // 261190815634209
                              "239269669930690808850213593178087921011070358568518", // 239269669930690808850213593178087921011070358568518
                              "0");
      TestCommon.DoTestDivide("978848711624273461886647116874158848497250392799", // 978848711624273461886647116874158848497250392799
                              "1816171221773737533500669024346849505775", // 1816171221773737533500669024346849505775
                              "538962791");
      TestCommon.DoTestDivide("156175649383412914610076880662303575090", // 156175649383412914610076880662303575090
                              "5813451160379989834200479000583145941020914934614180377989", // 5813451160379989834200479000583145941020914934614180377989
                              "0");
      TestCommon.DoTestDivide("14686084", // 14686084
                              "1228405624538168865421882832308474860455018596162949329830615", // 1228405624538168865421882832308474860455018596162949329830615
                              "0");
      TestCommon.DoTestDivide("9915659164094622381435883945311578487047519", // 9915659164094622381435883945311578487047519
                              "59571692356734", // 59571692356734
                              "166449176980176115873790145581");
      TestCommon.DoTestDivide("193345531773344434111188590", // 193345531773344434111188590
                              "11739902957235250871", // 11739902957235250871
                              "16469091");
      TestCommon.DoTestDivide("3774693997569948457253691274157534133761957978311441823088", // 3774693997569948457253691274157534133761957978311441823088
                              "369265857706694931615959087594345322766328605698872364", // 369265857706694931615959087594345322766328605698872364
                              "10222");
      TestCommon.DoTestDivide("497468732175912549895020364347825757", // 497468732175912549895020364347825757
                              "42042981068065582", // 42042981068065582
                              "11832384848508586694");
      TestCommon.DoTestDivide("3087638940847340406151759432782", // 3087638940847340406151759432782
                              "3258034339959761534361672910565006966610935551", // 3258034339959761534361672910565006966610935551
                              "0");
      TestCommon.DoTestDivide("753314029370096628636417344074504184857992143392166965400", // 753314029370096628636417344074504184857992143392166965400
                              "3248111591", // 3248111591
                              "231923691124839998958156897902743325070075199701");
      TestCommon.DoTestDivide("6822", // 6822
                              "12565746161612442501726391026818240297965019", // 12565746161612442501726391026818240297965019
                              "0");
      TestCommon.DoTestDivide("163", // 163
                              "127501572222728754465800", // 127501572222728754465800
                              "0");
      TestCommon.DoTestDivide("241443437116248", // 241443437116248
                              "401665352926891225014588960020379851469622592", // 401665352926891225014588960020379851469622592
                              "0");
      TestCommon.DoTestDivide("14882", // 14882
                              "41249221776448348010525489145897401633477", // 41249221776448348010525489145897401633477
                              "0");
      TestCommon.DoTestDivide("775575082", // 775575082
                              "28820679948498772645638136104", // 28820679948498772645638136104
                              "0");
      TestCommon.DoTestDivide("17879", // 17879
                              "2737780178086134179354178704171278939886681536804092871263", // 2737780178086134179354178704171278939886681536804092871263
                              "0");
      TestCommon.DoTestDivide("622769029589945873005232371262384412181909916422262001473567", // 622769029589945873005232371262384412181909916422262001473567
                              "1507420124985305512788541855896162414171635237", // 1507420124985305512788541855896162414171635237
                              "413135674167821");
      TestCommon.DoTestDivide("60954953801178458", // 60954953801178458
                              "570057564875168993466939571121810933961859657635716594799098", // 570057564875168993466939571121810933961859657635716594799098
                              "0");
      TestCommon.DoTestDivide("359374484509787454982044", // 359374484509787454982044
                              "1390587253187522242260769234049077005190564409594", // 1390587253187522242260769234049077005190564409594
                              "0");
      TestCommon.DoTestDivide("2044004063509533758174", // 2044004063509533758174
                              "70743282149493", // 70743282149493
                              "28893260");
      TestCommon.DoTestDivide("19653107961266251", // 19653107961266251
                              "21584511176251635456695969423077777024359545038118842027", // 21584511176251635456695969423077777024359545038118842027
                              "0");
      TestCommon.DoTestDivide("521290529635535707669271060498360669", // 521290529635535707669271060498360669
                              "70873877258950305038572247219735913955849035213971110", // 70873877258950305038572247219735913955849035213971110
                              "0");
      TestCommon.DoTestDivide("15529844", // 15529844
                              "318796289371873006872619780872414830136604243577224", // 318796289371873006872619780872414830136604243577224
                              "0");
      TestCommon.DoTestDivide("997781860468116100945213", // 997781860468116100945213
                              "85", // 85
                              "11738610123154307069943");
      TestCommon.DoTestDivide("10390997", // 10390997
                              "7263052", // 7263052
                              "1");
      TestCommon.DoTestDivide("1834254468402623386855", // 1834254468402623386855
                              "138", // 138
                              "13291699046395821643");
      TestCommon.DoTestDivide("345565926475240587412182", // 345565926475240587412182
                              "60357704310609", // 60357704310609
                              "5725299370");
      TestCommon.DoTestDivide("178", // 178
                              "30351782716070217", // 30351782716070217
                              "0");
      TestCommon.DoTestDivide("16084698", // 16084698
                              "1595076187715652132522052636134821", // 1595076187715652132522052636134821
                              "0");
      TestCommon.DoTestDivide("88025501099452005497977014958359573304170962029050046", // 88025501099452005497977014958359573304170962029050046
                              "9079171", // 9079171
                              "9695323625852184687123638816623188758551960529");
      TestCommon.DoTestDivide("102838175554476020997972509524075585154", // 102838175554476020997972509524075585154
                              "3539440503", // 3539440503
                              "29054924208306722029386379976");
      TestCommon.DoTestDivide("7172775267603108383759259253720536430069363", // 7172775267603108383759259253720536430069363
                              "2006683711", // 2006683711
                              "3574442363928227642726531931130294");
      TestCommon.DoTestDivide("348146096843", // 348146096843
                              "34141776210740590819535", // 34141776210740590819535
                              "0");
      TestCommon.DoTestDivide("35720159738216576890622638403883597421589", // 35720159738216576890622638403883597421589
                              "170", // 170
                              "210118586695391628768368461199315278950");
      TestCommon.DoTestDivide("2513923076639033", // 2513923076639033
                              "1955690563", // 1955690563
                              "1285440");
      TestCommon.DoTestDivide("3578520592566537249776965361795865564238916319845858867699", // 3578520592566537249776965361795865564238916319845858867699
                              "13173248606424076349132503925896171058622528734535197129", // 13173248606424076349132503925896171058622528734535197129
                              "271");
      TestCommon.DoTestDivide("5136970352171473683753084927236395", // 5136970352171473683753084927236395
                              "506635944976550336765", // 506635944976550336765
                              "10139372073983");
      TestCommon.DoTestDivide("314363964550693882421739145311637117", // 314363964550693882421739145311637117
                              "53520902645022897371325941384061191668439", // 53520902645022897371325941384061191668439
                              "0");
      TestCommon.DoTestDivide("558364300078", // 558364300078
                              "645312994147058817207", // 645312994147058817207
                              "0");
      TestCommon.DoTestDivide("4183967", // 4183967
                              "30750349838172048367781373742606065696571515993211231", // 30750349838172048367781373742606065696571515993211231
                              "0");
      TestCommon.DoTestDivide("10711829", // 10711829
                              "157296205791620", // 157296205791620
                              "0");
      TestCommon.DoTestDivide("18650251349785", // 18650251349785
                              "230838811645452070702773453610596949434455611743619", // 230838811645452070702773453610596949434455611743619
                              "0");
      TestCommon.DoTestDivide("129103875613919811226822695741276808532638636902179", // 129103875613919811226822695741276808532638636902179
                              "51232", // 51232
                              "2519985079909427920573522324743847761801972144");
      TestCommon.DoTestDivide("16059203431301460374027561609511986029792326", // 16059203431301460374027561609511986029792326
                              "10989787", // 10989787
                              "1461284320733555652536992901637855768");
      TestCommon.DoTestDivide("119961701848064028633484088", // 119961701848064028633484088
                              "640199495007253894108689273313779145999560979996112143700338", // 640199495007253894108689273313779145999560979996112143700338
                              "0");
      TestCommon.DoTestDivide("5488900000996014474645395720994990969476858214", // 5488900000996014474645395720994990969476858214
                              "49", // 49
                              "112018367367265601523375422877448795295446086");
      TestCommon.DoTestDivide("1304815226239894396196262835990495078020481696818019151169614", // 1304815226239894396196262835990495078020481696818019151169614
                              "1055170227260", // 1055170227260
                              "1236592155967247961067402602246632951515563497247");
      TestCommon.DoTestDivide("61216201864408719", // 61216201864408719
                              "21507266951945751040373985337995713196826292490829762649", // 21507266951945751040373985337995713196826292490829762649
                              "0");
      TestCommon.DoTestDivide("245600940369791811419244279", // 245600940369791811419244279
                              "32694176830338537", // 32694176830338537
                              "7512069860");
      TestCommon.DoTestDivide("277175140041014789865126596", // 277175140041014789865126596
                              "14022737", // 14022737
                              "19766122693523724353");
      TestCommon.DoTestDivide("3053619256", // 3053619256
                              "3889937837521292260495617573973091367792092965", // 3889937837521292260495617573973091367792092965
                              "0");
      TestCommon.DoTestDivide("204208703282090486218346087629203383460720141481594", // 204208703282090486218346087629203383460720141481594
                              "23766596356185345390900268107922609137739394746791391142", // 23766596356185345390900268107922609137739394746791391142
                              "0");
      TestCommon.DoTestDivide("16685925610033084101986098879899357728643187583642954", // 16685925610033084101986098879899357728643187583642954
                              "572832119344782814944783483460695124143379694852174349596468", // 572832119344782814944783483460695124143379694852174349596468
                              "0");
      TestCommon.DoTestDivide("164556782107600230073627401458173173045524157651023449", // 164556782107600230073627401458173173045524157651023449
                              "3085342947", // 3085342947
                              "53335005195323665934640555683475913138262926");
      TestCommon.DoTestDivide("16928071245381519977998069199125", // 16928071245381519977998069199125
                              "63421", // 63421
                              "266915867699681808517652972");
      TestCommon.DoTestDivide("962269509357", // 962269509357
                              "231617485933624285531731923182575435174444133368453", // 231617485933624285531731923182575435174444133368453
                              "0");
      TestCommon.DoTestDivide("44116086910255644561326428360", // 44116086910255644561326428360
                              "48728168862620742", // 48728168862620742
                              "905350805088");
      TestCommon.DoTestDivide("1890403843", // 1890403843
                              "81674362710853403360654722184059339226719868040380993", // 81674362710853403360654722184059339226719868040380993
                              "0");
      TestCommon.DoTestDivide("166", // 166
                              "11581", // 11581
                              "0");
      TestCommon.DoTestDivide("138220911734520", // 138220911734520
                              "191522227", // 191522227
                              "721696");
      TestCommon.DoTestDivide("299967455184638524372719051017954490944810391485145", // 299967455184638524372719051017954490944810391485145
                              "12605309", // 12605309
                              "23796914076809900048679413651656971752521924");
      TestCommon.DoTestDivide("177896759897476506724905", // 177896759897476506724905
                              "9049743888490732773", // 9049743888490732773
                              "19657");
      TestCommon.DoTestDivide("16204662743622038244358501267218982906826037", // 16204662743622038244358501267218982906826037
                              "256294070126835228616661750", // 256294070126835228616661750
                              "63226834454666267");
      TestCommon.DoTestDivide("1087129444057850022784241", // 1087129444057850022784241
                              "11519845158815553519", // 11519845158815553519
                              "94370");
      TestCommon.DoTestDivide("64019781034868016204309836127", // 64019781034868016204309836127
                              "54353577181107177214940273061", // 54353577181107177214940273061
                              "1");
      TestCommon.DoTestDivide("14964044", // 14964044
                              "3896729121495131637250", // 3896729121495131637250
                              "0");
      TestCommon.DoTestDivide("1382034461798072633537316701284782772479605295272", // 1382034461798072633537316701284782772479605295272
                              "707825827247031335380266816652476171", // 707825827247031335380266816652476171
                              "1952506405669");
      TestCommon.DoTestDivide("39392221555260244470260674", // 39392221555260244470260674
                              "1011731241080562815110667730899171921332181099138", // 1011731241080562815110667730899171921332181099138
                              "0");
      TestCommon.DoTestDivide("61003", // 61003
                              "2264144983434777263", // 2264144983434777263
                              "0");
      TestCommon.DoTestDivide("1464185236", // 1464185236
                              "10784287213235167088639372857684", // 10784287213235167088639372857684
                              "0");
      TestCommon.DoTestDivide("58", // 58
                              "515463019908", // 515463019908
                              "0");
      TestCommon.DoTestDivide("4730074784891683701656684568121518524575642706850663820", // 4730074784891683701656684568121518524575642706850663820
                              "22365555837090168774503502486953791428232710104102600", // 22365555837090168774503502486953791428232710104102600
                              "211");
      TestCommon.DoTestDivide("18512334611210780936480117", // 18512334611210780936480117
                              "116693703803", // 116693703803
                              "158640389394640");
      TestCommon.DoTestDivide("524011356", // 524011356
                              "38849854152087", // 38849854152087
                              "0");
      TestCommon.DoTestDivide("159593870660698583247765875927126222169773997800593", // 159593870660698583247765875927126222169773997800593
                              "3008411173", // 3008411173
                              "53049221493733158412174889209243813086241");
      TestCommon.DoTestDivide("5066419054698449551449048540017723", // 5066419054698449551449048540017723
                              "1567838722043577844434294594060549027726032709", // 1567838722043577844434294594060549027726032709
                              "0");
      TestCommon.DoTestDivide("357884610330882921418370231003354527575307580505849", // 357884610330882921418370231003354527575307580505849
                              "1147048213197651214579552861732507623", // 1147048213197651214579552861732507623
                              "312004854035908");
      TestCommon.DoTestDivide("5004574530168275847144582210218869834404142093598213810365", // 5004574530168275847144582210218869834404142093598213810365
                              "1110072785772751806957833482770401788000297432978", // 1110072785772751806957833482770401788000297432978
                              "4508330079");
      TestCommon.DoTestDivide("3245070931454459206394365754201511347771752005", // 3245070931454459206394365754201511347771752005
                              "63080670652168107293266796512", // 63080670652168107293266796512
                              "51443190091431357");
      TestCommon.DoTestDivide("175567438667021553427570459394505474824505333562065", // 175567438667021553427570459394505474824505333562065
                              "32842706947203557", // 32842706947203557
                              "5345705484911940673967925214174173");
      TestCommon.DoTestDivide("229951605017765730803083676441251598183482458154477", // 229951605017765730803083676441251598183482458154477
                              "539719716586322", // 539719716586322
                              "426057447877184601217786616277765390");
      TestCommon.DoTestDivide("343403752808197049773777654876884775507365208468026", // 343403752808197049773777654876884775507365208468026
                              "332893212130196614984733757882935847890", // 332893212130196614984733757882935847890
                              "1031573310283");
      TestCommon.DoTestDivide("5511494026677341415634985968446724133322443473571925388", // 5511494026677341415634985968446724133322443473571925388
                              "41497884604263396463662", // 41497884604263396463662
                              "132813854952767960998764675332056");
      TestCommon.DoTestDivide("2043040269366376689500009731196494770319189271", // 2043040269366376689500009731196494770319189271
                              "43282360303688011726841411029", // 43282360303688011726841411029
                              "47202607598834967");
      TestCommon.DoTestDivide("195", // 195
                              "31516526691046280511984344266011567050887", // 31516526691046280511984344266011567050887
                              "0");
      TestCommon.DoTestDivide("5309143939874190283091201386056576438813819857262420461530", // 5309143939874190283091201386056576438813819857262420461530
                              "22378", // 22378
                              "237248366246947461037233058631538852391358470697221398");
      TestCommon.DoTestDivide("22880124487350329541929923819902361028492776441100538645", // 22880124487350329541929923819902361028492776441100538645
                              "796265645840592396307440", // 796265645840592396307440
                              "28734285607909791896892206783750");
      TestCommon.DoTestDivide("74511762285418805611812941383187385949926", // 74511762285418805611812941383187385949926
                              "15552892279479949242399895651963109320094753", // 15552892279479949242399895651963109320094753
                              "0");
      TestCommon.DoTestDivide("182403467740597149874815199886118601806979205515092110443678", // 182403467740597149874815199886118601806979205515092110443678
                              "17315110863173076661706887244311", // 17315110863173076661706887244311
                              "10534351710594294417108711424");
      TestCommon.DoTestDivide("37406241181912205961321377044663404419984814022404509968885", // 37406241181912205961321377044663404419984814022404509968885
                              "13951977907188403732006102860528140701458742", // 13951977907188403732006102860528140701458742
                              "2681070843915226");
      TestCommon.DoTestDivide("289142254712860864259668184", // 289142254712860864259668184
                              "4783780951830151831891580563028784451761448015", // 4783780951830151831891580563028784451761448015
                              "0");
      TestCommon.DoTestDivide("1093658236800674608065052369573393794957622009577005825367", // 1093658236800674608065052369573393794957622009577005825367
                              "106909378721172", // 106909378721172
                              "10229768892895922713510820298901827848610184");
      TestCommon.DoTestDivide("6082932288596298831298695362885685314725466", // 6082932288596298831298695362885685314725466
                              "86327628482281986370455058", // 86327628482281986370455058
                              "70463331329028331");
      TestCommon.DoTestDivide("322823922108126801243893093437388113759", // 322823922108126801243893093437388113759
                              "19262954220460056", // 19262954220460056
                              "16758796102273912611949");
      TestCommon.DoTestDivide("1205732917158739278012416038290776464600373972154271452345327", // 1205732917158739278012416038290776464600373972154271452345327
                              "9974728006095282298469743581658345978707", // 9974728006095282298469743581658345978707
                              "120878776486130650523");
      TestCommon.DoTestDivide("19920076596243651490964612415048286847313610", // 19920076596243651490964612415048286847313610
                              "65543416411", // 65543416411
                              "303921853437296733637374879729906");
      TestCommon.DoTestDivide("250247722208725936472648447", // 250247722208725936472648447
                              "20339869879647380228156694837669635607549643", // 20339869879647380228156694837669635607549643
                              "0");
      TestCommon.DoTestDivide("3504829794151936084604053621170767976515713781", // 3504829794151936084604053621170767976515713781
                              "1218027401962696150364744594516557507438851625534496964616608", // 1218027401962696150364744594516557507438851625534496964616608
                              "0");
      TestCommon.DoTestDivide("3637971326", // 3637971326
                              "68947129038936047967537874710427858", // 68947129038936047967537874710427858
                              "0");
      TestCommon.DoTestDivide("3688941916124160617360001783931021726112105163027619731837", // 3688941916124160617360001783931021726112105163027619731837
                              "1279772507360093850535833781219320344226875643393650386", // 1279772507360093850535833781219320344226875643393650386
                              "2882");
      TestCommon.DoTestDivide("21071068983823519598981663736065226380734163755889602678", // 21071068983823519598981663736065226380734163755889602678
                              "1506189038594464147908", // 1506189038594464147908
                              "13989657635197295662000068985290550");
      TestCommon.DoTestDivide("5607809409844058771", // 5607809409844058771
                              "24957117297546576112138778022", // 24957117297546576112138778022
                              "0");
      TestCommon.DoTestDivide("166065118902182782817106713027003", // 166065118902182782817106713027003
                              "13796818277980056243307326715243", // 13796818277980056243307326715243
                              "12");
      TestCommon.DoTestDivide("2762481558528298370484839373507590", // 2762481558528298370484839373507590
                              "4200867735839020355580492231888845", // 4200867735839020355580492231888845
                              "0");
      TestCommon.DoTestDivide("5816814194974102202", // 5816814194974102202
                              "17932729764782702990538972279008", // 17932729764782702990538972279008
                              "0");
      TestCommon.DoTestDivide("6548364492226305374889935536268724842275", // 6548364492226305374889935536268724842275
                              "4568966009106089672830", // 4568966009106089672830
                              "1433226791176649966");
      TestCommon.DoTestDivide("544621867926128389441117335320905186334540182959", // 544621867926128389441117335320905186334540182959
                              "186331248793243961871657", // 186331248793243961871657
                              "2922869199092038743392689");
      TestCommon.DoTestDivide("16443434728263632712", // 16443434728263632712
                              "10497904745276107233552891021171", // 10497904745276107233552891021171
                              "0");
      TestCommon.DoTestDivide("61594581859832105420181386676151336975", // 61594581859832105420181386676151336975
                              "89606722227973444108100730547875835926716315685712037", // 89606722227973444108100730547875835926716315685712037
                              "0");
      TestCommon.DoTestDivide("1290968390359226535245364905020604257442226391644642402087438", // 1290968390359226535245364905020604257442226391644642402087438
                              "53963239231565447688137107884253754424", // 53963239231565447688137107884253754424
                              "23923107818258673524373");
      TestCommon.DoTestDivide("262951782155265278979813121426890806419", // 262951782155265278979813121426890806419
                              "7725527324865430563281640998578094709677", // 7725527324865430563281640998578094709677
                              "0");
      TestCommon.DoTestDivide("124270127530164010733372152835112608197", // 124270127530164010733372152835112608197
                              "59501056289953530800540363762104909363197", // 59501056289953530800540363762104909363197
                              "0");
      TestCommon.DoTestDivide("18213405451697318796263796268568426895806475740132546070", // 18213405451697318796263796268568426895806475740132546070
                              "6838816734857859461", // 6838816734857859461
                              "2663239293847793548890486685569655570");
      TestCommon.DoTestDivide("230041198043007648336262204592890887355", // 230041198043007648336262204592890887355
                              "257769977626148", // 257769977626148
                              "892428203476215981452473");
      TestCommon.DoTestDivide("780272345154781542054511498768842320", // 780272345154781542054511498768842320
                              "106621312834085217926594755732736396099784943795660", // 106621312834085217926594755732736396099784943795660
                              "0");
      TestCommon.DoTestDivide("73094734063383887877752215", // 73094734063383887877752215
                              "3759503583968112544189435528821", // 3759503583968112544189435528821
                              "0");
      TestCommon.DoTestDivide("21515", // 21515
                              "2416815728450294363064932650738980251904021802956550126568", // 2416815728450294363064932650738980251904021802956550126568
                              "0");
      TestCommon.DoTestDivide("53482427370820035611948294701976605402522", // 53482427370820035611948294701976605402522
                              "218278579009809230184466935104817148465", // 218278579009809230184466935104817148465
                              "245");
      TestCommon.DoTestDivide("60706075568942735064459", // 60706075568942735064459
                              "444714749921098463700783752758073350914167908", // 444714749921098463700783752758073350914167908
                              "0");
      TestCommon.DoTestDivide("12384484807864121163", // 12384484807864121163
                              "14871094", // 14871094
                              "832789087868");
      TestCommon.DoTestDivide("158266131267146125739561", // 158266131267146125739561
                              "693762235698915116045349", // 693762235698915116045349
                              "0");
      TestCommon.DoTestDivide("262735215813", // 262735215813
                              "36665857999579023660483633480301806204327", // 36665857999579023660483633480301806204327
                              "0");
      TestCommon.DoTestDivide("1039512372418259111966894", // 1039512372418259111966894
                              "1233064771694900261855686169087799917", // 1233064771694900261855686169087799917
                              "0");
      TestCommon.DoTestDivide("74181116339121465310060830453692695155403", // 74181116339121465310060830453692695155403
                              "3000881334467585104903507074872625", // 3000881334467585104903507074872625
                              "24719776");
      TestCommon.DoTestDivide("2217994439722542513680067301273611", // 2217994439722542513680067301273611
                              "74539166234094356577201652510639248985898432445751618", // 74539166234094356577201652510639248985898432445751618
                              "0");
      TestCommon.DoTestDivide("3699701275589519267662661039312150", // 3699701275589519267662661039312150
                              "13162", // 13162
                              "281089596990542415108848278324");
      TestCommon.DoTestDivide("193207227672154269464941975408616993011037777096092899986917", // 193207227672154269464941975408616993011037777096092899986917
                              "238303933570081987821640", // 238303933570081987821640
                              "810759708317339283282832614851242275");
      TestCommon.DoTestDivide("38103327437663520383734285166", // 38103327437663520383734285166
                              "584631583415", // 584631583415
                              "65174938403243809");
      TestCommon.DoTestDivide("7108458778420752410513684518295357106611824125925455634", // 7108458778420752410513684518295357106611824125925455634
                              "4669131397851771878584", // 4669131397851771878584
                              "1522437081486139919311054854998998");
      TestCommon.DoTestDivide("150", // 150
                              "19820224147804791149933840147198291114725321897995997472", // 19820224147804791149933840147198291114725321897995997472
                              "0");
      TestCommon.DoTestDivide("1584059330689528374960896061303142347450970572031188533468", // 1584059330689528374960896061303142347450970572031188533468
                              "316240774568376979362217713374489266768294026479801", // 316240774568376979362217713374489266768294026479801
                              "5009029");
      TestCommon.DoTestDivide("16", // 16
                              "1242131776085428008401940568162215196", // 1242131776085428008401940568162215196
                              "0");
      TestCommon.DoTestDivide("165", // 165
                              "354557728201927727667615636827799653172394364815856133381903", // 354557728201927727667615636827799653172394364815856133381903
                              "0");
      TestCommon.DoTestDivide("62701", // 62701
                              "136422999051250510942512797", // 136422999051250510942512797
                              "0");
      TestCommon.DoTestDivide("4247278008", // 4247278008
                              "36176725731646", // 36176725731646
                              "0");
      TestCommon.DoTestDivide("23188108553628903734067831385859722107404378591291698", // 23188108553628903734067831385859722107404378591291698
                              "4962785891194059333454994503525053856989264654", // 4962785891194059333454994503525053856989264654
                              "4672397");
      TestCommon.DoTestDivide("54236425410213064", // 54236425410213064
                              "202", // 202
                              "268497155496104");
      TestCommon.DoTestDivide("50717103400241528726396964552806993945224758583903431", // 50717103400241528726396964552806993945224758583903431
                              "13311828259023861054348234231469552707507025315180560251", // 13311828259023861054348234231469552707507025315180560251
                              "0");
      TestCommon.DoTestDivide("147", // 147
                              "37390292104984063426177718588945870166243", // 37390292104984063426177718588945870166243
                              "0");
      TestCommon.DoTestDivide("18198638075943402532436393", // 18198638075943402532436393
                              "2556057938873536746209061636977502418568", // 2556057938873536746209061636977502418568
                              "0");
      TestCommon.DoTestDivide("50381284620998611669193791272627528684700", // 50381284620998611669193791272627528684700
                              "72176499123087641196043377127102097127014971787572647", // 72176499123087641196043377127102097127014971787572647
                              "0");
      TestCommon.DoTestDivide("736624634066", // 736624634066
                              "141648605084997733904060156069071834786989639657089", // 141648605084997733904060156069071834786989639657089
                              "0");
      TestCommon.DoTestDivide("5455079434895491712317329176457250389288017010", // 5455079434895491712317329176457250389288017010
                              "1369318065037287030552532646487548157153622511627696756255809", // 1369318065037287030552532646487548157153622511627696756255809
                              "0");
      TestCommon.DoTestDivide("939747741807419414225277232907066", // 939747741807419414225277232907066
                              "148274948217320103555377396", // 148274948217320103555377396
                              "6337872");
      TestCommon.DoTestDivide("1216924945010075477328011172699448176", // 1216924945010075477328011172699448176
                              "706277040130", // 706277040130
                              "1723013599289711738923792");
      TestCommon.DoTestDivide("21079793429780053792015827524420051258191034", // 21079793429780053792015827524420051258191034
                              "174642561428062", // 174642561428062
                              "120702498047494282180214536053");
      TestCommon.DoTestDivide("433510731176239", // 433510731176239
                              "5243016", // 5243016
                              "82683465");
      TestCommon.DoTestDivide("8332990974204162410857915312967116178201633", // 8332990974204162410857915312967116178201633
                              "758395858352018337836968", // 758395858352018337836968
                              "10987653588076831055");
      TestCommon.DoTestDivide("1335849467255659017211763554025702249129245733402", // 1335849467255659017211763554025702249129245733402
                              "2082102965", // 2082102965
                              "641586650473675790194056783366475946173");
      TestCommon.DoTestDivide("263097897148", // 263097897148
                              "3017342185612940114", // 3017342185612940114
                              "0");
      TestCommon.DoTestDivide("318515663736576193890042035244882992876", // 318515663736576193890042035244882992876
                              "24027000686358893516553461445", // 24027000686358893516553461445
                              "13256571966");
      TestCommon.DoTestDivide("47535134382470652672115527243133682864", // 47535134382470652672115527243133682864
                              "258729474066895878965497049610982623676", // 258729474066895878965497049610982623676
                              "0");
      TestCommon.DoTestDivide("4997468921208199435803128002541820691138220997990751697326", // 4997468921208199435803128002541820691138220997990751697326
                              "860974446312167882416810563290472989", // 860974446312167882416810563290472989
                              "5804433502775809121531");
      TestCommon.DoTestDivide("815387634192348456579590", // 815387634192348456579590
                              "2656571903444917194357263381440033554899180975998999727897", // 2656571903444917194357263381440033554899180975998999727897
                              "0");
      TestCommon.DoTestDivide("42821561037937620075061165631280989283305099039555520", // 42821561037937620075061165631280989283305099039555520
                              "41232206278118970747040089028818600464741357352005969", // 41232206278118970747040089028818600464741357352005969
                              "1");
      TestCommon.DoTestDivide("2772805862265801115465", // 2772805862265801115465
                              "249", // 249
                              "11135766515123699258");
      TestCommon.DoTestDivide("57815042337381104468285030899567347211993584760717", // 57815042337381104468285030899567347211993584760717
                              "5450934179240667661951986212037231785231487441285446882745", // 5450934179240667661951986212037231785231487441285446882745
                              "0");
      TestCommon.DoTestDivide("962533147027", // 962533147027
                              "745224029413", // 745224029413
                              "1");
      TestCommon.DoTestDivide("253582124947043772567698873286238362251", // 253582124947043772567698873286238362251
                              "67667115039229212560051051679318354628324703869359214", // 67667115039229212560051051679318354628324703869359214
                              "0");
      TestCommon.DoTestDivide("4086906440985531841632425776556359881457485072", // 4086906440985531841632425776556359881457485072
                              "2569391220", // 2569391220
                              "1590612752613645127047809315918951369");
      TestCommon.DoTestDivide("25782", // 25782
                              "47918", // 47918
                              "0");
      TestCommon.DoTestDivide("3842178352791645158093493624923294190726187909", // 3842178352791645158093493624923294190726187909
                              "12561717627938022517577847992896370970305685715305408784", // 12561717627938022517577847992896370970305685715305408784
                              "0");
      TestCommon.DoTestDivide("3963142360949086042919654355783935651034728518349421792688", // 3963142360949086042919654355783935651034728518349421792688
                              "12233485007024570625426476997451214533282843739492109697", // 12233485007024570625426476997451214533282843739492109697
                              "323");
      TestCommon.DoTestDivide("1195512227779186966", // 1195512227779186966
                              "14383756459207206", // 14383756459207206
                              "83");
      TestCommon.DoTestDivide("224431084455069600136186869141845889069424051468", // 224431084455069600136186869141845889069424051468
                              "63940683948719852546922096882335314796", // 63940683948719852546922096882335314796
                              "3509988798");
      TestCommon.DoTestDivide("8837078107083731577", // 8837078107083731577
                              "1719579539876606440390191501585", // 1719579539876606440390191501585
                              "0");
      TestCommon.DoTestDivide("2254206", // 2254206
                              "1827195323043701861", // 1827195323043701861
                              "0");
      TestCommon.DoTestDivide("161", // 161
                              "459637651387259174325713495091156981933296496959", // 459637651387259174325713495091156981933296496959
                              "0");
      TestCommon.DoTestDivide("27508829714570642", // 27508829714570642
                              "3482771809", // 3482771809
                              "7898544");
      TestCommon.DoTestDivide("249297765221448246579842718", // 249297765221448246579842718
                              "38645", // 38645
                              "6450970765207614091857");
      TestCommon.DoTestDivide("195324370181522", // 195324370181522
                              "21229302527845005014112453746787451082638333", // 21229302527845005014112453746787451082638333
                              "0");
      TestCommon.DoTestDivide("81745922896545", // 81745922896545
                              "22300084332340929930207968256768974504695278", // 22300084332340929930207968256768974504695278
                              "0");
      TestCommon.DoTestDivide("29002903688520124466719374346172465914", // 29002903688520124466719374346172465914
                              "146104173348329689911175914", // 146104173348329689911175914
                              "198508386337");
      TestCommon.DoTestDivide("416098167006230804796416973822128811395785", // 416098167006230804796416973822128811395785
                              "303578832470555812257370066425577916588233886696314151577789", // 303578832470555812257370066425577916588233886696314151577789
                              "0");
      TestCommon.DoTestDivide("14339555", // 14339555
                              "140783451070746485187740502", // 140783451070746485187740502
                              "0");
      TestCommon.DoTestDivide("20269435548453025769754906130865", // 20269435548453025769754906130865
                              "181800878", // 181800878
                              "111492506369815363431605");
    }

  }
}

