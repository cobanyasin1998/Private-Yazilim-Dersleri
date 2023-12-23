ˆ
•D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Presentation\ETicaretAPI.API\Configurations\Log\ColumnWriters\UsernameColumnWriter.cs
	namespace 	
ETicaretAPI
 
. 
API 
. 
Configurations (
.( )
Log) ,
., -
ColumnWriters- :
{ 
public 

class  
UsernameColumnWriter %
:& '
ColumnWriterBase( 8
{ 
public		  
UsernameColumnWriter		 #
(		# $
)		$ %
:		& '
base		( ,
(		, -
NpgsqlDbType		- 9
.		9 :
Varchar		: A
)		A B
{

 	
} 	
public 
override 
object 
GetValue '
(' (
LogEvent( 0
logEvent1 9
,9 :
IFormatProvider; J
formatProviderK Y
=Z [
null\ `
)` a
{ 	
var 
( 
username 
, 
value  
)  !
=" #
logEvent$ ,
., -

Properties- 7
.7 8
FirstOrDefault8 F
(F G
xG H
=>H J
xJ K
.K L
KeyL O
==P R
$strS ^
)^ _
;_ `
return 
value 
? 
. 
ToString "
(" #
)# $
??% '
string( .
.. /
Empty/ 4
;4 5
} 	
} 
} ¥D
çD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Presentation\ETicaretAPI.API\Controllers\ProductController.cs
	namespace 	
ETicaretAPI
 
. 
API 
. 
Controllers %
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class 
ProductController "
:# $
ControllerBase% 3
{ 
private 
readonly 
	IMediator "
	_mediator# ,
;, -
public 
ProductController  
(  !
	IMediator 
mediator 
) 
{ 	
	_mediator 
= 
mediator  
;  !
} 	
[   	
HttpGet  	 
]   
public!! 
async!! 
Task!! 
<!! 
ActionResult!! &
>!!& '
Get!!( +
(!!+ ,
[!!, -
	FromQuery!!- 6
]!!6 7%
GetAllProductQueryRequest!!8 Q%
getAllProductQueryRequest!!R k
)!!k l
{"" 	&
GetAllProductQueryResponse$$ &
response$$' /
=$$0 1
await$$2 7
	_mediator$$8 A
.$$A B
Send$$B F
($$F G%
getAllProductQueryRequest$$G `
)$$` a
;$$a b
return%% 
Ok%% 
(%% 
response%% 
)%% 
;%%  
}'' 	
[)) 	
HttpGet))	 
()) 
$str)) 
))) 
])) 
public** 
async** 
Task** 
<** 
ActionResult** &
>**& '
Get**( +
(**+ ,&
GetByIdProductQueryRequest**, F&
getByIdProductQueryRequest**G a
)**a b
{++ 	'
GetByIdProductQueryResponse,, '
response,,( 0
=,,1 2
await,,3 8
	_mediator,,9 B
.,,B C
Send,,C G
(,,G H&
getByIdProductQueryRequest,,H b
),,b c
;,,c d
return-- 
Ok-- 
(-- 
response-- 
)-- 
;--  
}// 	
[11 	
HttpPost11	 
]11 
[22 	
	Authorize22	 
(22 !
AuthenticationSchemes22 (
=22) *
$str22+ 2
)222 3
]223 4
public33 
async33 
Task33 
<33 
IActionResult33 '
>33' (
Post33) -
(33- .'
CreateProductCommandRequest33. I'
createProductCommandRequest33J e
)33e f
{44 	(
CreateProductCommandResponse55 ((
createProductCommandResponse55) E
=55F G
await55H M
	_mediator55N W
.55W X
Send55X \
(55\ ]'
createProductCommandRequest55] x
)55x y
;55y z
return66 

StatusCode66 
(66 
(66 
int66 "
)66" #
HttpStatusCode66# 1
.661 2
Created662 9
)669 :
;66: ;
}77 	
[99 	
HttpPut99	 
]99 
[:: 	
	Authorize::	 
(:: !
AuthenticationSchemes:: (
=::) *
$str::+ 2
)::2 3
]::3 4
public<< 
async<< 
Task<< 
<<< 
IActionResult<< '
><<' (
Put<<) ,
(<<, -
[<<- .
FromBody<<. 6
]<<6 7'
UpdateProductCommandRequest<<8 S'
updateProductCommandRequest<<T o
)<<o p
{== 	(
UpdateProductCommandResponse>> ((
updateProductCommandResponse>>) E
=>>F G
await>>H M
	_mediator>>N W
.>>W X
Send>>X \
(>>\ ]'
updateProductCommandRequest>>] x
)>>x y
;>>y z
return@@ 

StatusCode@@ 
(@@ 
(@@ 
int@@ "
)@@" #
HttpStatusCode@@# 1
.@@1 2
OK@@2 4
)@@4 5
;@@5 6
}AA 	
[CC 	

HttpDeleteCC	 
(CC 
$strCC 
)CC 
]CC 
[DD 	
	AuthorizeDD	 
(DD !
AuthenticationSchemesDD (
=DD) *
$strDD+ 2
)DD2 3
]DD3 4
publicFF 
asyncFF 
TaskFF 
<FF 
IActionResultFF '
>FF' (
DeleteFF) /
(FF/ 0
[FF0 1
	FromRouteFF1 :
]FF: ;'
RemoveProductCommandRequestFF< W'
removeProductCommandRequestFFX s
)FFs t
{GG 	(
RemoveProductCommandResponseHH ((
removeProductCommandResponseHH) E
=HHF G
awaitHHH M
	_mediatorHHN W
.HHW X
SendHHX \
(HH\ ]'
removeProductCommandRequestHH] x
)HHx y
;HHy z
returnII 
OkII 
(II 
)II 
;II 
}JJ 	
[LL 	
HttpPostLL	 
(LL 
$strLL 
)LL 
]LL 
[MM 	
	AuthorizeMM	 
(MM !
AuthenticationSchemesMM (
=MM) *
$strMM+ 2
)MM2 3
]MM3 4
[OO 	
RequestFormLimitsOO	 
(OO 
ValueLengthLimitOO +
=OO, -
intOO. 1
.OO1 2
MaxValueOO2 :
,OO: ;$
MultipartBodyLengthLimitOO< T
=OOU V
intOOW Z
.OOZ [
MaxValueOO[ c
)OOc d
]OOd e
publicPP 
asyncPP 
TaskPP 
<PP 
IActionResultPP '
>PP' (
UploadPP) /
(PP/ 0
[PP0 1
	FromQueryPP1 :
,PP: ;
FromFormPP< D
]PPD E%
UploadProductImageRequestPPF _%
uploadProductImageRequestPP` y
)PPy z
{QQ 	%
uploadProductImageRequestRR %
.RR% &
FilesRR& +
=RR, -
RequestRR. 5
.RR5 6
FormRR6 :
.RR: ;
FilesRR; @
;RR@ A&
UploadProductImageResponseTT &(
removeProductCommandResponseTT' C
=TTD E
awaitTTF K
	_mediatorTTL U
.TTU V
SendTTV Z
(TTZ [%
uploadProductImageRequestTT[ t
)TTt u
;TTu v
returnVV 
OkVV 
(VV 
)VV 
;VV 
}XX 	
[[[ 	
HttpGet[[	 
([[ 
$str[[  
)[[  !
][[! "
[\\ 	
	Authorize\\	 
(\\ !
AuthenticationSchemes\\ (
=\\) *
$str\\+ 2
)\\2 3
]\\3 4
public^^ 
async^^ 
Task^^ 
<^^ 
IActionResult^^ '
>^^' (
GetProductImages^^) 9
(^^9 :#
GetProductImagesRequest^^: Q#
getProductImagesRequest^^R i
)^^i j
{__ 	
List`` 
<`` $
GetProductImagesResponse`` )
>``) *(
removeProductCommandResponse``+ G
=``H I
await``J O
	_mediator``P Y
.``Y Z
Send``Z ^
(``^ _#
getProductImagesRequest``_ v
)``v w
;``w x
returnaa 
Okaa 
(aa (
removeProductCommandResponseaa 2
)aa2 3
;aa3 4
}cc 	
[ee 	

HttpDeleteee	 
(ee 
$stree #
)ee# $
]ee$ %
[ff 	
	Authorizeff	 
(ff !
AuthenticationSchemesff (
=ff) *
$strff+ 2
)ff2 3
]ff3 4
publichh 
asynchh 
Taskhh 
<hh 
IActionResulthh '
>hh' (
DeleteProductImagehh) ;
(hh; <
[hh< =
	FromRoutehh= F
]hhF G%
RemoveProductImageRequesthhH a%
removeProductImageRequesthhb {
,hh{ |
[hh} ~
	FromQuery	hh~ á
]
hhá à
string
hhâ è
imageId
hhê ó
)
hhó ò
{ii 	%
removeProductImageRequestjj %
.jj% &
ImageIdjj& -
=jj. /
imageIdjj0 7
;jj7 8&
RemoveProductImageResponsekk &&
removeProductImageResponsekk' A
=kkB C
awaitkkD I
	_mediatorkkJ S
.kkS T
SendkkT X
(kkX Y%
removeProductImageRequestkkY r
)kkr s
;kks t
returnll 
Okll 
(ll 
)ll 
;ll 
}mm 	
}nn 
}oo «$
ãD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Presentation\ETicaretAPI.API\Controllers\UsersController.cs
	namespace

 	
ETicaretAPI


 
.

 
API

 
.

 
Controllers

 %
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class 
UsersController  
:! "
ControllerBase# 1
{ 
private 
readonly 
	IMediator "
	_mediator# ,
;, -
public 
UsersController 
( 
	IMediator 
mediator 
) 
{ 	
	_mediator 
= 
mediator  
;  !
} 	
[ 	
HttpPost	 
] 
public 
async 
Task 
< 
IActionResult '
>' (

CreateUser) 3
(3 4$
CreateUserCommandRequest4 L$
createUserCommandRequestM e
)e f
{ 	%
CreateUserCommandResponse %%
createUserCommandResponse& ?
=@ A
awaitB G
	_mediatorH Q
.Q R
SendR V
(V W$
createUserCommandRequestW o
)o p
;p q
return 
Ok 
( %
createUserCommandResponse /
)/ 0
;0 1
} 	
[   	
HttpPost  	 
(   
$str   
)   
]   
public!! 
async!! 
Task!! 
<!! 
IActionResult!! '
>!!' (
Login!!) .
(!!. /#
LoginUserCommandRequest!!/ F#
loginUserCommandRequest!!G ^
)!!^ _
{"" 	$
LoginUserCommandResponse## $$
loginUserCommandResponse##% =
=##> ?
await##@ E
	_mediator##F O
.##O P
Send##P T
(##T U#
loginUserCommandRequest##U l
)##l m
;##m n
return$$ 
Ok$$ 
($$ $
loginUserCommandResponse$$ .
)$$. /
;$$/ 0
}%% 	
[&& 	
HttpPost&&	 
(&& 
$str&&  
)&&  !
]&&! "
public'' 
async'' 
Task'' 
<'' 
IActionResult'' '
>''' (
GoogleLogin'') 4
(''4 5%
GoogleLoginCommandRequest''5 N%
googleLoginCommandRequest''O h
)''h i
{(( 	&
GoogleLoginCommandResponse)) &&
googleLoginCommandResponse))' A
=))B C
await))D I
	_mediator))J S
.))S T
Send))T X
())X Y%
googleLoginCommandRequest))Y r
)))r s
;))s t
return** 
Ok** 
(** &
googleLoginCommandResponse** 0
)**0 1
;**1 2
}++ 	
[-- 	
HttpPost--	 
(-- 
$str-- "
)--" #
]--# $
public.. 
async.. 
Task.. 
<.. 
IActionResult.. '
>..' (
FacebookLogin..) 6
(..6 7'
FacebookLoginCommandRequest..7 R'
facebookLoginCommandRequest..S n
)..n o
{// 	(
FacebookLoginCommandResponse00 ((
facebookLoginCommandResponse00) E
=00F G
await00H M
	_mediator00N W
.00W X
Send00X \
(00\ ]'
facebookLoginCommandRequest00] x
)00x y
;00y z
return11 
Ok11 
(11 (
facebookLoginCommandResponse11 2
)112 3
;113 4
}22 	
[55 	
HttpPost55	 
(55 
$str55 
)55 
]55 
public66 
async66 
Task66 
<66 
IActionResult66 '
>66' (
RefreshTokenLogin66) :
(66: ;
[66; <
FromBody66< D
]66D E&
RefreshTokenCommandRequest66F `&
refreshTokenCommandRequest66a {
)66{ |
{77 	'
RefreshTokenCommandResponse88 ''
refreshTokenCommandResponse88( C
=88D E
await88F K
	_mediator88L U
.88U V
Send88V Z
(88Z [&
refreshTokenCommandRequest88[ u
)88u v
;88v w
return99 
Ok99 
(99 '
refreshTokenCommandResponse99 1
)991 2
;992 3
}:: 	
};; 
}<< Ö
ùD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Presentation\ETicaretAPI.API\Extensions\ConfigureExceptionHandlerExtension.cs
	namespace 	
ETicaretAPI
 
. 
API 
. 

Extensions $
{ 
public 

static 
class .
"ConfigureExceptionHandlerExtension :
{		 
public

 
static

 
void

 %
ConfigureExceptionHandler

 4
<

4 5
T

5 6
>

6 7
(

7 8
this

8 <
WebApplication

= K
application

L W
,

W X
ILogger

Y `
<

` a
T

a b
>

b c
logger

d j
)

j k
{ 	
application 
. 
UseExceptionHandler +
(+ ,
builder, 3
=>4 6
{ 
builder 
. 
Run 
( 
async !
(" #
context# *
)* +
=>, .
{ 
context 
. 
Response $
.$ %

StatusCode% /
=0 1
(2 3
int3 6
)6 7
HttpStatusCode7 E
.E F
InternalServerErrorF Y
;Y Z
context 
. 
Response $
.$ %
ContentType% 0
=1 2
MediaTypeNames3 A
.A B
ApplicationB M
.M N
JsonN R
;R S
var 
contextFeature &
=' (
context) 0
.0 1
Features1 9
.9 :
Get: =
<= >$
IExceptionHandlerFeature> V
>V W
(W X
)X Y
;Y Z
if 
( 
contextFeature &
!=' )
null* .
). /
{ 
logger 
. 
LogError '
(' (
contextFeature( 6
.6 7
Error7 <
.< =
Message= D
)D E
;E F
} 
await 
context !
.! "
Response" *
.* +

WriteAsync+ 5
(5 6
JsonSerializer6 D
.D E
	SerializeE N
(N O
newO R
{ 

StatusCode "
=# $
context% ,
., -
Response- 5
.5 6

StatusCode6 @
,@ A
Message 
=  !
contextFeature" 0
.0 1
Error1 6
.6 7
Message7 >
,> ?
Title 
= 
$str  -
} 
) 
) 
; 
}   
)   
;   
}!! 
)!! 
;!! 
}"" 	
}## 
}$$ ◊^
wD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Presentation\ETicaretAPI.API\Program.cs
var 
builder 
= 
WebApplication 
. 
CreateBuilder *
(* +
args+ /
)/ 0
;0 1
builder 
. 
Services 
. 
AddControllers 
(  
opt  #
=>$ &
{ 
opt 
. 
Filters 
. 
Add 
< 
ValidationFilter $
>$ %
(% &
)& '
;' (
} 
) 
. 
AddFluentValidation 
( 
conf 
=>  
{ 
conf 
. 4
(RegisterValidatorsFromAssemblyContaining 5
<5 6"
CreateProductValidator6 L
>L M
(M N
)N O
;O P
} 
) 
.   '
ConfigureApiBehaviorOptions    
(    !
conf  ! %
=>  & (
{!! 
conf"" 
."" +
SuppressModelStateInvalidFilter"" ,
=""- .
true""/ 3
;""3 4
}## 
)## 
;## 
builder%% 
.%% 
Services%% 
.%% 
AddCors%% 
(%% 
opt%% 
=>%% 
{&& 
opt'' 
.'' 
AddDefaultPolicy'' 
('' 
policy'' 
=>''  "
{(( 
policy)) 
.)) 
WithOrigins)) 
()) 
$str)) 2
,))2 3
$str))4 L
)))L M
.))M N
AllowAnyHeader))N \
())\ ]
)))] ^
.))^ _
AllowAnyMethod))_ m
())m n
)))n o
.))o p
AllowCredentials	))p Ä
(
))Ä Å
)
))Å Ç
;
))Ç É
}++ 
)++ 
;++ 
},, 
),, 
;,, 
Logger.. 
log.. 

=.. 
new.. 
LoggerConfiguration.. $
(..$ %
)..% &
.// 
WriteTo// 
.// 
Console// 
(// 
)// 
.00 
WriteTo00 
.00 
File00 
(00 
$str00  
)00  !
.11 
WriteTo11 
.11 

PostgreSQL11 
(11 
builder11 
.11  
Configuration11  -
.11- .
GetConnectionString11. A
(11A B
$str11B N
)11N O
,11O P
$str11Q W
,11W X
needAutoCreateTable11Y l
:11l m
true11n r
,11r s%
restrictedToMinimumLevel	11t å
:
11å ç
Serilog
11é ï
.
11ï ñ
Events
11ñ ú
.
11ú ù
LogEventLevel
11ù ™
.
11™ ´
Verbose
11´ ≤
,
11≤ ≥
columnOptions22 
:22 
new22 

Dictionary22 %
<22% &
string22& ,
,22, -
ColumnWriterBase22. >
>22> ?
{33 	
{44 
$str44 
,44 
new44 '
RenderedMessageColumnWriter44 7
(447 8
)448 9
}44: ;
,44; <
{55 
$str55  
,55  !
new55! $'
MessageTemplateColumnWriter55% @
(55@ A
)55A B
}55C D
,55D E
{66 
$str66 
,66 
new66 
LevelColumnWriter66 +
(66+ ,
)66, -
}66. /
,66/ 0
{77 
$str77 
,77 
new77 !
TimestampColumnWriter77 4
(774 5
)775 6
}777 8
,778 9
{88 
$str88 
,88 
new88 !
ExceptionColumnWriter88 3
(883 4
)884 5
}886 7
,887 8
{99 
$str99 
,99 
new99 *
LogEventSerializedColumnWriter99 <
(99< =
)99= >
}99? @
,99@ A
{:: 
$str:: 
,:: 
new::  
UsernameColumnWriter:: 3
(::3 4
)::4 5
}::5 6
};; 	
,;;	 


schemaName<< 
:<< 
$str<< 
)<< 
.== 
WriteTo== 
.== 
Seq== 
(== 
builder== 
.== 
Configuration== &
[==& '
$str==' 6
]==6 7
)==7 8
.>> 
MinimumLevel>> 
.>> 
Information>> 
(>> 
)>> 
.?? 
Enrich?? 
.?? 
FromLogContext?? 
(?? 
)?? 
.@@ 
CreateLogger@@ 
(@@ 
)@@ 
;@@ 
builderBB 
.BB 
HostBB 
.BB 

UseSerilogBB 
(BB 
logBB 
)BB 
;BB 
builderDD 
.DD 
ServicesDD 
.DD 
AddHttpLoggingDD 
(DD  
loggingDD  '
=>DD( *
{EE 
loggingFF 
.FF 
LoggingFieldsFF 
=FF 
HttpLoggingFieldsFF -
.FF- .
AllFF. 1
;FF1 2
loggingGG 
.GG 
RequestHeadersGG 
.GG 
AddGG 
(GG 
$strGG *
)GG* +
;GG+ ,
loggingHH 
.HH 
MediaTypeOptionsHH 
.HH 
AddTextHH $
(HH$ %
$strHH% =
)HH= >
;HH> ?
loggingII 
.II 
RequestBodyLogLimitII 
=II  !
$numII" &
;II& '
loggingJJ 
.JJ  
ResponseBodyLogLimitJJ  
=JJ! "
$numJJ# '
;JJ' (
}LL 
)LL 
;LL 
builderRR 
.RR 
ServicesRR 
.RR #
AddEndpointsApiExplorerRR (
(RR( )
)RR) *
;RR* +
builderSS 
.SS 
ServicesSS 
.SS 
AddSwaggerGenSS 
(SS 
)SS  
;SS  !
builderVV 
.VV 
ServicesVV 
.VV "
AddPersistenceServicesVV '
(VV' (
)VV( )
;VV) *
builderWW 
.WW 
ServicesWW 
.WW %
AddInfrastructureServicesWW *
(WW* +
)WW+ ,
;WW, -
builderXX 
.XX 
ServicesXX 
.XX "
AddApplicationServicesXX '
(XX' (
)XX( )
;XX) *
builderYY 
.YY 
ServicesYY 
.YY 
AddSignalRServicesYY #
(YY# $
)YY$ %
;YY% &
builder[[ 
.[[ 
Services[[ 
.[[ 

AddStorage[[ 
<[[ 
LocalStorage[[ (
>[[( )
([[) *
)[[* +
;[[+ ,
builder]] 
.]] 
Services]] 
.]] 
AddAuthentication]] "
(]]" #
JwtBearerDefaults]]# 4
.]]4 5 
AuthenticationScheme]]5 I
)]]I J
.]]J K
AddJwtBearer]]K W
(]]W X
$str]]X _
,]]_ `
opt]]a d
=>]]e g
{^^ 
opt__ 
.__ %
TokenValidationParameters__ !
=__" #
new__$ '
(__' (
)__( )
{`` 
ValidateIssueraa 
=aa 
trueaa 
,aa 
ValidateAudiencebb 
=bb 
truebb 
,bb  
ValidateLifetimecc 
=cc 
truecc 
,cc  $
ValidateIssuerSigningKeydd  
=dd! "
truedd# '
,dd' (
ValidAudienceee 
=ee 
builderee 
.ee  
Configurationee  -
[ee- .
$stree. >
]ee> ?
,ee? @
LifetimeValidatorff 
=ff 
(ff 
	notBeforeff &
,ff& '
expiresff( /
,ff/ 0
securityTokenff1 >
,ff> ? 
validationParametersff@ T
)ffT U
=>ffV X
expiresffY `
!=ffa c
nullffd h
?ffi j
expiresffk r
>ffs t
DateTimeffu }
.ff} ~
UtcNow	ff~ Ñ
:
ffÖ Ü
false
ffá å
,
ffå ç
ValidIssuergg 
=gg 
buildergg 
.gg 
Configurationgg +
[gg+ ,
$strgg, :
]gg: ;
,gg; <
IssuerSigningKeyhh 
=hh 
newhh  
SymmetricSecurityKeyhh 3
(hh3 4
Encodinghh4 <
.hh< =
UTF8hh= A
.hhA B
GetByteshhB J
(hhJ K
builderhhK R
.hhR S
ConfigurationhhS `
[hh` a
$strhha t
]hht u
)hhu v
)hhv w
,hhw x
NameClaimTypeii 
=ii 

ClaimTypesii "
.ii" #
Nameii# '
}jj 
;jj 
}kk 
)kk 
;kk 
varmm 
appmm 
=mm 	
buildermm
 
.mm 
Buildmm 
(mm 
)mm 
;mm 
ifoo 
(oo 
appoo 
.oo 
Environmentoo 
.oo 
IsDevelopmentoo !
(oo! "
)oo" #
)oo# $
{pp 
appqq 
.qq 

UseSwaggerqq 
(qq 
)qq 
;qq 
apprr 
.rr 
UseSwaggerUIrr 
(rr 
)rr 
;rr 
}ss 
apptt 
.tt %
ConfigureExceptionHandlertt 
<tt 
Programtt %
>tt% &
(tt& '
apptt' *
.tt* +
Servicestt+ 3
.tt3 4
GetRequiredServicett4 F
<ttF G
ILoggerttG N
<ttN O
ProgramttO V
>ttV W
>ttW X
(ttX Y
)ttY Z
)ttZ [
;tt[ \
appuu 
.uu 
UseStaticFilesuu 
(uu 
)uu 
;uu 
appvv 
.vv $
UseSerilogRequestLoggingvv 
(vv 
)vv 
;vv 
appww 
.ww 
UseCorsww 
(ww 
)ww 
;ww 
appxx 
.xx 
UseHttpsRedirectionxx 
(xx 
)xx 
;xx 
appyy 
.yy 
UseAuthenticationyy 
(yy 
)yy 
;yy 
appzz 
.zz 
UseAuthorizationzz 
(zz 
)zz 
;zz 
app|| 
.|| 
Use|| 
(|| 
async|| 
(|| 
context|| 
,|| 
next|| 
)|| 
=>||  
{}} 
var~~ 
username~~ 
=~~ 
context~~ 
.~~ 
User~~ 
?~~  
.~~  !
Identity~~! )
?~~) *
.~~* +
IsAuthenticated~~+ :
!=~~; =
null~~> B
?~~C D
context~~E L
.~~L M
User~~M Q
.~~Q R
Identity~~R Z
.~~Z [
Name~~[ _
:~~` a
null~~b f
;~~f g

LogContext 
. 
PushProperty 
( 
$str '
,' (
username) 1
)1 2
;2 3
await
ÄÄ 	
next
ÄÄ
 
(
ÄÄ 
)
ÄÄ 
;
ÄÄ 
}ÅÅ 
)
ÅÅ 
;
ÅÅ 
appÉÉ 
.
ÉÉ 
MapControllers
ÉÉ 
(
ÉÉ 
)
ÉÉ 
;
ÉÉ 
appÖÖ 
.
ÖÖ 
MapHubs
ÖÖ 
(
ÖÖ 
)
ÖÖ 
;
ÖÖ 
appÜÜ 
.
ÜÜ 
Run
ÜÜ 
(
ÜÜ 
)
ÜÜ 	
;
ÜÜ	 
