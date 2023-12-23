»
îD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Abstractions\Hubs\IProductHubService.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Abstractions" .
.. /
Hubs/ 3
{ 
public		 

	interface		 
IProductHubService		 '
{

 
Task $
ProductAddedMessageAsync %
(% &
string& ,
message- 4
)4 5
;5 6
} 
} ∂
íD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Abstractions\Services\IAuthService.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Abstractions" .
.. /
Services/ 7
{ 
public		 

	interface		 
IAuthService		 !
{

 
} 
} æ
íD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Abstractions\Services\IUserService.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Abstractions" .
.. /
Services/ 7
{		 
public

 

	interface

 
IUserService

 !
{ 
Task 
< 
CreateUserResponse 
>  
CreateAsync! ,
(, -

CreateUser- 7
user8 <
)< =
;= >
Task 
UpdateRefreshToken 
(  
string  &
refreshToken' 3
,3 4
string4 :
userId; A
,A B
DateTimeB J
accessTokenDateK Z
,Z [
int\ _ 
refreshTokenLifeTime` t
)t u
;u v
} 
} É
òD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Abstractions\Storage\Azure\IAzureStorage.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Abstractions" .
.. /
Storage/ 6
.6 7
Azure7 <
{ 
public		 

	interface		 
IAzureStorage		 "
:		" #
IStorage		# +
{

 
} 
} ä
çD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Abstractions\Storage\IStorage.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Abstractions" .
.. /
Storage/ 6
{		 
public

 

	interface

 
IStorage

 
{ 
Task 
< 
List 
< 
( 
string 
fileName "
," #
string$ *
path+ /
)/ 0
>0 1
>1 2
UploadAsync3 >
(> ?
string? E
pathOrContainerNameF Y
,Y Z
IFormFileCollection[ n
fileso t
)t u
;u v
Task 

DeleteAsyc 
( 
string 
pathOrContainerName 2
,2 3
string4 :
fileName; C
)C D
;D E
List 
< 
string 
> 
GetFiles 
( 
string $
pathOrContainerName% 8
)8 9
;9 :
bool 
HasFile 
( 
string 
pathOrContainerName /
,/ 0
string1 7
fileName8 @
)@ A
;A B
} 
} ﬁ
îD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Abstractions\Storage\IStorageService.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Abstractions" .
.. /
Storage/ 6
{ 
public		 

	interface		 
IStorageService		 $
:		% &
IStorage		& .
{

 
public 
string 
StorageName !
{" #
get$ '
;' (
}) *
} 
} É
òD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Abstractions\Storage\Local\ILocalStorage.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Abstractions" .
.. /
Storage/ 6
.6 7
Local7 <
{ 
public		 

	interface		 
ILocalStorage		 "
:		# $
IStorage		% -
{

 
} 
} Ó
êD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Abstractions\Token\ITokenHandler.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Abstractions" .
.. /
Token/ 4
{		 
public

 

	interface

 
ITokenHandler

 "
{ 
DTOs 
. 
Token 
CreateAccessToken $
($ %
int% (
minute) /
,/ 0
AppUser0 7
user8 <
)< =
;= >
string 
CreateRefreshToken !
(! "
)" #
;# $
} 
} ⁄
úD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\DTOs\Facebook\FacebookAccessTokenResponseDTO.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
DTOs" &
.& '
Facebook' /
{		 
public

 

class

 *
FacebookAccessTokenResponseDTO

 /
{ 
[ 	
JsonPropertyName	 
( 
$str (
)( )
]) *
public 
string 
AccessToken !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
JsonPropertyName	 
( 
$str &
)& '
]' (
public 
string 
	TokenType 
{  !
get" %
;% &
set' *
;* +
}, -
} 
} Ë

ûD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\DTOs\Facebook\FacebookAccessTokenValidationDTO.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
DTOs" &
.& '
Facebook' /
{		 
public

 

class

 ,
 FacebookAccessTokenValidationDTO

 1
{ 
[ 	
JsonPropertyName	 
( 
$str  
)  !
]! "
public -
!FacebookAccessTokenValidationData 0
Data1 5
{6 7
get8 ;
;; <
set= @
;@ A
}B C
} 
public 

class -
!FacebookAccessTokenValidationData 2
{ 
[ 	
JsonPropertyName	 
( 
$str $
)$ %
]% &
public 
bool 
IsValid 
{ 
get !
;! "
set# &
;& '
}( )
[ 	
JsonPropertyName	 
( 
$str #
)# $
]$ %
public 
string 
UserId 
{ 
get "
;" #
set$ '
;' (
}) *
} 
} ≈	
ñD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\DTOs\Facebook\FacebookUserInfoResponse.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
DTOs" &
.& '
Facebook' /
{		 
public

 

class

 $
FacebookUserInfoResponse

 )
{ 
[ 	
JsonPropertyName	 
( 
$str 
) 
]  
public 
string 
Id 
{ 
get 
; 
set  #
;# $
}% &
[ 	
JsonPropertyName	 
( 
$str !
)! "
]" #
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
[ 	
JsonPropertyName	 
( 
$str  
)  !
]! "
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
} 
} ƒ
zD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\DTOs\Token.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
DTOs" &
{ 
public		 

class		 
Token		 
{

 
public 
string 
AccessToken !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
DateTime 

Expiration "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
RefreshToken "
{# $
get% (
;( )
set* -
;- .
}/ 0
} 
} §	
ÑD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\DTOs\User\CreateUser.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
DTOs" &
.& '
User' +
{ 
public 

class 

CreateUser 
{ 
public 
string 
NameSurname !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
Username 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
Password 
{  
get! $
;$ %
set& )
;) *
}+ ,
public		 
string		 

Repassword		  
{		! "
get		# &
;		& '
set		( +
;		+ ,
}		- .
}

 
} ⁄
åD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\DTOs\User\CreateUserResponse.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
DTOs" &
.& '
User' +
{ 
public		 

class		 
CreateUserResponse		 #
{

 
public 
bool 
Success 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
Message 
{ 
get  #
;# $
set% (
;( )
}* +
} 
} ˆ	
êD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Exceptions\NotFoundUserException.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "

Exceptions" ,
{		 
public

 

class

 !
NotFoundUserException

 &
:

' (
	Exception

) 2
{ 
public !
NotFoundUserException $
($ %
)% &
:' (
base( ,
(, -
$str- N
)N O
{ 	
} 	
public !
NotFoundUserException $
($ %
string% +
?+ ,
message- 4
)4 5
:6 7
base8 <
(< =
message= D
)D E
{ 	
} 	
public !
NotFoundUserException $
($ %
string% +
?+ ,
message- 4
,4 5
	Exception6 ?
?? @
innerExceptionA O
)O P
:Q R
baseS W
(W X
messageX _
,_ `
innerExceptiona o
)o p
{ 	
} 	
} 
} ä

îD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Exceptions\UserCreateFailedException.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "

Exceptions" ,
{ 
public		 

class		 %
UserCreateFailedException		 *
:		+ ,
	Exception		- 6
{

 
public %
UserCreateFailedException (
(( )
)) *
:+ ,
base- 1
(2 3
$str3 r
)r s
{ 	
} 	
public %
UserCreateFailedException (
(( )
string) /
?/ 0
message1 8
)8 9
:: ;
base< @
(@ A
messageA H
)H I
{ 	
} 	
public %
UserCreateFailedException (
(( )
string) /
?/ 0
message1 8
,8 9
	Exception: C
?C D
innerExceptionE S
)S T
:U V
baseW [
([ \
message\ c
,c d
innerExceptione s
)s t
{ 	
} 	
} 
} ì
îD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\ExtensionMethod\PaginationExtensions.cs
	namespace		 	
ETicaretAPI		
 
.		 
Application		 !
.		! "
ExtensionMethod		" 1
{

 
public 

static 
class  
PaginationExtensions ,
{ 
public 
static 

IQueryable  
<  !
T! "
>" #
Paginate$ ,
<, -
T- .
,. /
TKey0 4
>4 5
(5 6
this 

IQueryable 
< 
T 
> 
query  
,  !
int 
page 
= 
$num 
, 
int 
pageSize 
= 
$num 
, 

Expression 
< 
Func 
< 
T 
, 
TKey 
>  
>  !
orderBy" )
=* +
null, 0
,0 1
bool 

descending 
= 
true 
) 
where  %
T& '
:( )

BaseEntity* 4
{ 	
query 
= 

descending 
?  
query! &
.& '
OrderByDescending' 8
(8 9
orderBy9 @
)@ A
:B C
queryD I
.I J
OrderByJ Q
(Q R
orderByR Y
)Y Z
;Z [
return 
query 
. 
Skip 
( 
page 
* 
pageSize %
)% &
. 
Take 
( 
pageSize 
) 
;  
} 	
} 
} ◊
≠D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\AppUser\CreateUser\CreateUserCommandHandler.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
AppUser4 ;
.; <

CreateUser< F
{ 
public 

class $
CreateUserCommandHandler )
:* +
IRequestHandler, ;
<; <$
CreateUserCommandRequest< T
,T U%
CreateUserCommandResponseV o
>o p
{ 
private		 
readonly		 
IUserService		 %
_userService		& 2
;		2 3
public $
CreateUserCommandHandler '
(' (
IUserService( 4
userService5 @
)@ A
{ 	
_userService 
= 
userService &
;& '
} 	
public 
async 
Task 
< %
CreateUserCommandResponse 3
>3 4
Handle5 ;
(; <$
CreateUserCommandRequest< T
requestU \
,\ ]
CancellationToken^ o
cancellationToken	p Å
)
Å Ç
{ 	
var 
data 
= 
await 
_userService )
.) *
CreateAsync* 5
(5 6
new6 9
DTOs: >
.> ?
User? C
.C D

CreateUserD N
(N O
)O P
{ 
Email 
= 
request 
.  
Email  %
,% &
NameSurname 
= 
request %
.% &
NameSurname& 1
,1 2
Password 
= 
request "
." #
Password# +
,+ ,

Repassword 
= 
request $
.$ %

Repassword% /
,/ 0
Username 
= 
request "
." #
Username# +
} 
) 
; 
return 
new %
CreateUserCommandResponse 0
(0 1
)1 2
{3 4
Message5 <
== >
data? C
.C D
MessageD K
,K L
SuccessM T
=U V
dataW [
.[ \
Success\ c
}d e
;e f
} 	
} 
} ò
≠D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\AppUser\CreateUser\CreateUserCommandRequest.cs
	namespace		 	
ETicaretAPI		
 
.		 
Application		 !
.		! "
Features		" *
.		* +
Commands		+ 3
.		3 4
AppUser		4 ;
.		; <

CreateUser		< F
{

 
public 

class $
CreateUserCommandRequest )
:* +
IRequest, 4
<4 5%
CreateUserCommandResponse5 N
>N O
{ 
public 
string 
NameSurname !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
Username 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
Password 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 

Repassword  
{! "
get# &
;& '
set( +
;+ ,
}- .
} 
} ÷
ÆD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\AppUser\CreateUser\CreateUserCommandResponse.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
AppUser4 ;
.; <

CreateUser< F
{ 
public		 

class		 %
CreateUserCommandResponse		 *
{

 
public 
bool 
Success 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
Message 
{ 
get  #
;# $
set% (
;( )
}* +
} 
} µA
≥D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\AppUser\FacebookLogin\FacebookLoginCommandHandler.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
AppUser4 ;
.; <
FacebookLogin< I
{ 
public 

class '
FacebookLoginCommandHandler ,
:- .
IRequestHandler/ >
<> ?'
FacebookLoginCommandRequest? Z
,Z [(
FacebookLoginCommandResponse\ x
>x y
{ 
private 
readonly 
UserManager $
<$ %
ETicaretAPI% 0
.0 1
Domain1 7
.7 8
Entities8 @
.@ A
IdentityA I
.I J
AppUserJ Q
>Q R
_userManagerS _
;_ `
private 
readonly 
ITokenHandler &
_tokenHandler' 4
;4 5
private 
readonly 

HttpClient #
_httpClient$ /
;/ 0
private 
readonly 
IUserService %
_userService& 2
;2 3
public '
FacebookLoginCommandHandler *
(* +
UserManager 
< 
Domain 
. 
Entities '
.' (
Identity( 0
.0 1
AppUser1 8
>8 9
userManager: E
,E F
ITokenHandler 
tokenHandler &
,& '
IHttpClientFactory 
httpClientFactory 0
,0 1
IUserService 
service  
)  !
{ 	
_userManager 
= 
userManager &
;& '
_tokenHandler 
= 
tokenHandler (
;( )
_httpClient 
= 
httpClientFactory +
.+ ,
CreateClient, 8
(8 9
)9 :
;: ;
_userService   
=   
service   "
;  " #
}!! 	
public## 
async## 
Task## 
<## (
FacebookLoginCommandResponse## 6
>##6 7
Handle##8 >
(##> ?'
FacebookLoginCommandRequest##? Z
request##[ b
,##b c
CancellationToken##d u
cancellationToken	##v á
)
##á à
{$$ 	
string%% 
accessTokenResponse%% &
=%%' (
await%%) .
_httpClient%%/ :
.%%: ;
GetStringAsync%%; I
(%%I J
$"%%J L
$str	%%L ‡
"
%%‡ ·
)
%%· ‚
;
%%‚ „*
FacebookAccessTokenResponseDTO'' **
facebookAccessTokenResponseDTO''+ I
=''J K
JsonSerializer''L Z
.''Z [
Deserialize''[ f
<''f g+
FacebookAccessTokenResponseDTO	''g Ö
>
''Ö Ü
(
''Ü á!
accessTokenResponse
''á ö
)
''ö õ
;
''õ ú
string)) %
userAccessTokenValidation)) ,
=))- .
await))/ 4
_httpClient))5 @
.))@ A
GetStringAsync))A O
())O P
$"))P R
$str	))R Ö
{
))Ö Ü
request
))Ü ç
.
))ç é
	AuthToken
))é ó
}
))ó ò
$str
))ò ¶
{
))¶ ß,
facebookAccessTokenResponseDTO
))ß ≈
.
))≈ ∆
AccessToken
))∆ —
}
))— “
"
))“ ”
)
))” ‘
;
))‘ ’,
 FacebookAccessTokenValidationDTO++ ,,
 facebookAccessTokenValidationDTO++- M
=++N O
JsonSerializer++P ^
.++^ _
Deserialize++_ j
<++j k-
 FacebookAccessTokenValidationDTO	++k ã
>
++ã å
(
++å ç'
userAccessTokenValidation
++ç ¶
)
++¶ ß
;
++ß ®
if-- 
(-- ,
 facebookAccessTokenValidationDTO-- 0
.--0 1
Data--1 5
.--5 6
IsValid--6 =
)--= >
{.. 
string// 
userInfoResponse// '
=//( )
await//* /
_httpClient//0 ;
.//; <
GetStringAsync//< J
(//J K
$"//K M
$str	//M ä
{
//ä ã
request
//ã í
.
//í ì
	AuthToken
//ì ú
}
//ú ù
"
//ù û
)
//û ü
;
//ü †$
FacebookUserInfoResponse00 ($
facebookUserInfoResponse00) A
=00B C
JsonSerializer00D R
.00R S
Deserialize00S ^
<00^ _$
FacebookUserInfoResponse00_ w
>00w x
(00x y
userInfoResponse	00y â
)
00â ä
;
00ä ã
UserLoginInfo33 
userLoginInfo33 +
=33, -
new33. 1
(331 2
$str332 <
,33< =,
 facebookAccessTokenValidationDTO33> ^
.33^ _
Data33_ c
.33c d
UserId33d j
,33j k
$str33l v
)33v w
;33w x
Domain44 
.44 
Entities44 
.44  
Identity44  (
.44( )
AppUser44) 0
user441 5
=446 7
await448 =
_userManager44> J
.44J K
FindByLoginAsync44K [
(44[ \
userLoginInfo44\ i
.44i j
LoginProvider44j w
,44w x
userLoginInfo	44y Ü
.
44Ü á
ProviderKey
44á í
)
44í ì
;
44ì î
bool55 
result55 
=55 
user55 "
!=55# %
null55& *
;55* +
if66 
(66 
user66 
==66 
null66  
)66  !
{77 
if99 
(99 
user99 
==99 
null99  $
)99$ %
{:: 
user;; 
=;; 
new;; "
(;;" #
);;# $
{<< 
Id== 
===  
Guid==! %
.==% &
NewGuid==& -
(==- .
)==. /
.==/ 0
ToString==0 8
(==8 9
)==9 :
,==: ;
Email>> !
=>>" #$
facebookUserInfoResponse>>$ <
.>>< =
Email>>= B
,>>B C
UserName?? $
=??% &$
facebookUserInfoResponse??' ?
.??? @
Email??@ E
,??E F
NameSurname@@ '
=@@( )$
facebookUserInfoResponse@@* B
.@@B C
Name@@C G
}BB 
;BB 
IdentityResultCC &
createResultCC' 3
=CC4 5
awaitCC6 ;
_userManagerCC< H
.CCH I
CreateAsyncCCI T
(CCT U
userCCU Y
)CCY Z
;CCZ [
resultDD 
=DD  
createResultDD! -
.DD- .
	SucceededDD. 7
;DD7 8
}EE 
}FF 
ifHH 
(HH 
resultHH 
)HH 
awaitII 
_userManagerII &
.II& '
AddLoginAsyncII' 4
(II4 5
userII5 9
,II9 :
userLoginInfoII; H
)IIH I
;III J
elseJJ 
throwKK 
newKK 
	ExceptionKK '
(KK' (
$strKK( J
)KKJ K
;KKK L
varMM 
tokenMM 
=MM 
_tokenHandlerMM )
.MM) *
CreateAccessTokenMM* ;
(MM; <
$numMM< =
,MM= >
userMM> B
)MMB C
;MMC D
awaitNN 
_userServiceNN !
.NN! "
UpdateRefreshTokenNN" 4
(NN4 5
tokenNN5 :
.NN: ;
RefreshTokenNN; G
,NNG H
userNNH L
.NNL M
IdNNM O
,NNO P
tokenNNP U
.NNU V

ExpirationNNV `
,NN` a
$numNNa b
)NNb c
;NNc d
returnPP 
newPP (
FacebookLoginCommandResponsePP 7
(PP7 8
)PP8 9
{QQ 
TokenRR 
=RR 
tokenRR !
}SS 
;SS 
}TT 
returnVV 
newVV 
(VV 
)VV 
;VV 
}WW 	
}XX 
}YY ∂
≥D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\AppUser\FacebookLogin\FacebookLoginCommandRequest.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
AppUser4 ;
.; <
FacebookLogin< I
{ 
public 

class '
FacebookLoginCommandRequest ,
:, -
IRequest- 5
<5 6(
FacebookLoginCommandResponse6 R
>R S
{ 
public 
string 
	AuthToken 
{  !
get" %
;% &
set' *
;* +
}, -
} 
}		 ∆
¥D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\AppUser\FacebookLogin\FacebookLoginCommandResponse.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
AppUser4 ;
.; <
FacebookLogin< I
{		 
public

 

class

 (
FacebookLoginCommandResponse

 -
{ 
public 
Token 
Token 
{ 
get  
;  !
set" %
;% &
}' (
} 
} ®1
ØD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\AppUser\GoogleLogin\GoogleLoginCommandHandler.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
AppUser4 ;
.; <
GoogleLogin< G
{		 
public 

class %
GoogleLoginCommandHandler *
:+ ,
IRequestHandler- <
<< =%
GoogleLoginCommandRequest= V
,V W&
GoogleLoginCommandResponseX r
>r s
{ 
private 
readonly 
UserManager $
<$ %
ETicaretAPI% 0
.0 1
Domain1 7
.7 8
Entities8 @
.@ A
IdentityA I
.I J
AppUserJ Q
>Q R
_userManagerS _
;_ `
private 
readonly 
ITokenHandler &
_tokenHandler' 4
;4 5
private 
readonly 
IUserService %
_userService& 2
;2 3
public %
GoogleLoginCommandHandler (
(( )
UserManager) 4
<4 5
Domain5 ;
.; <
Entities< D
.D E
IdentityE M
.M N
AppUserN U
>U V
userManagerW b
,b c
ITokenHandlerd q
tokenHandlerr ~
,~ 
IUserService
Ä å
userService
ç ò
)
ò ô
{ 	
_userManager 
= 
userManager &
;& '
_tokenHandler 
= 
tokenHandler (
;( )
_userService 
= 
userService &
;& '
} 	
public 
async 
Task 
< &
GoogleLoginCommandResponse 4
>4 5
Handle6 <
(< =%
GoogleLoginCommandRequest= V
requestW ^
,^ _
CancellationToken` q
cancellationToken	r É
)
É Ñ
{ 	
var 
settings 
= 
new "
GoogleJsonWebSignature 5
.5 6
ValidationSettings6 H
(H I
)I J
{ 
Audience 
= 
new 
List #
<# $
string$ *
>* +
{, -
$str. y
}z {
} 
; 
var   
payload   
=   
await   "
GoogleJsonWebSignature    6
.  6 7
ValidateAsync  7 D
(  D E
request  E L
.  L M
IdToken  M T
,  T U
settings  V ^
)  ^ _
;  _ `
UserLoginInfo!! 
userLoginInfo!! '
=!!( )
new!!* -
(!!- .
request!!. 5
.!!5 6
Provider!!6 >
,!!> ?
payload!!@ G
.!!G H
Subject!!H O
,!!O P
request!!Q X
.!!X Y
Provider!!Y a
)!!a b
;!!b c
Domain"" 
."" 
Entities"" 
."" 
Identity"" $
.""$ %
AppUser""% ,
user""- 1
=""2 3
await""4 9
_userManager"": F
.""F G
FindByLoginAsync""G W
(""W X
userLoginInfo""X e
.""e f
LoginProvider""f s
,""s t
userLoginInfo	""u Ç
.
""Ç É
ProviderKey
""É é
)
""é è
;
""è ê
bool## 
result## 
=## 
user## 
!=## !
null##" &
;##& '
if$$ 
($$ 
user$$ 
==$$ 
null$$ 
)$$ 
{%% 
if'' 
('' 
user'' 
=='' 
null''  
)''  !
{(( 
user)) 
=)) 
new)) 
()) 
)))  
{))! "
Id** 
=** 
Guid** !
.**! "
NewGuid**" )
(**) *
)*** +
.**+ ,
ToString**, 4
(**4 5
)**5 6
,**6 7
Email++ 
=++ 
payload++  '
.++' (
Email++( -
,++- .
UserName,,  
=,,! "
payload,,# *
.,,* +
Email,,+ 0
,,,0 1
NameSurname-- #
=--$ %
payload--& -
.--- .
Name--. 2
}// 
;// 
IdentityResult00 "
createResult00# /
=000 1
await002 7
_userManager008 D
.00D E
CreateAsync00E P
(00P Q
user00Q U
)00U V
;00V W
result11 
=11 
createResult11 )
.11) *
	Succeeded11* 3
;113 4
}22 
}33 
if55 
(55 
result55 
)55 
await66 
_userManager66 "
.66" #
AddLoginAsync66# 0
(660 1
user661 5
,665 6
userLoginInfo667 D
)66D E
;66E F
else77 
throw88 
new88 
	Exception88 #
(88# $
$str88$ F
)88F G
;88G H
var;; 
token;; 
=;; 
_tokenHandler;; %
.;;% &
CreateAccessToken;;& 7
(;;7 8
$num;;8 9
,;;9 :
user;;; ?
);;? @
;;;@ A
await<< 
_userService<< 
.<< 
UpdateRefreshToken<< 1
(<<1 2
token<<2 7
.<<7 8
RefreshToken<<8 D
,<<D E
user<<F J
.<<J K
Id<<K M
,<<M N
token<<O T
.<<T U

Expiration<<U _
,<<_ `
$num<<a b
)<<b c
;<<c d
return>> 
new>> &
GoogleLoginCommandResponse>> 1
(>>1 2
)>>2 3
{?? 
Token@@ 
=@@ 
token@@ 
}AA 
;AA 
}EE 	
}FF 
}II ‚
ØD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\AppUser\GoogleLogin\GoogleLoginCommandRequest.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
AppUser4 ;
.; <
GoogleLogin< G
{		 
public

 

class

 %
GoogleLoginCommandRequest

 *
:

+ ,
IRequest

- 5
<

5 6&
GoogleLoginCommandResponse

6 P
>

P Q
{ 
public 
string 
Id 
{ 
get 
; 
set  #
;# $
}% &
public 
string 
IdToken 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
	FirstName 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 
LastName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
PhotoUrl 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Provider 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
} æ
∞D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\AppUser\GoogleLogin\GoogleLoginCommandResponse.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
AppUser4 ;
.; <
GoogleLogin< G
{		 
public

 

class

 &
GoogleLoginCommandResponse

 +
{ 
public 
Token 
Token 
{ 
get  
;  !
set" %
;% &
}' (
} 
} Ú'
´D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\AppUser\LoginUser\LoginUserCommandHandler.cs
	namespace		 	
ETicaretAPI		
 
.		 
Application		 !
.		! "
Features		" *
.		* +
Commands		+ 3
.		3 4
AppUser		4 ;
.		; <
	LoginUser		< E
{

 
public 

class #
LoginUserCommandHandler (
:) *
IRequestHandler+ :
<: ;#
LoginUserCommandRequest; R
,R S$
LoginUserCommandResponseT l
>l m
{ 
private 
readonly 
UserManager $
<$ %
Domain% +
.+ ,
Entities, 4
.4 5
Identity5 =
.= >
AppUser> E
>E F
_userManagerG S
;S T
private 
readonly 
SignInManager &
<& '
Domain' -
.- .
Entities. 6
.6 7
Identity7 ?
.? @
AppUser@ G
>G H
_signInManagerI W
;W X
private 
readonly 
ITokenHandler &
_tokenHandler' 4
;4 5
private 
readonly 
IUserService $
_userService% 1
;1 2
public #
LoginUserCommandHandler &
(& '
UserManager' 2
<2 3
Domain3 9
.9 :
Entities: B
.B C
IdentityC K
.K L
AppUserL S
>S T
userManagerU `
,` a
SignInManager 
< 
Domain  
.  !
Entities! )
.) *
Identity* 2
.2 3
AppUser3 :
>: ;
signInManager< I
,I J
ITokenHandler 
tokenHandler &
,& '
IUserService( 4
service5 <
)< =
{ 	
_userManager 
= 
userManager &
;& '
_signInManager 
= 
signInManager *
;* +
_tokenHandler 
= 
tokenHandler (
;( )
_userService 
= 
service "
;" #
} 	
public 
async 
Task 
< $
LoginUserCommandResponse 2
>2 3
Handle4 :
(: ;#
LoginUserCommandRequest; R
requestS Z
,Z [
CancellationToken\ m
cancellationTokenn 
)	 Ä
{ 	
Domain 
. 
Entities 
. 
Identity $
.$ %
AppUser% ,
user- 1
=2 3
await4 9
_userManager: F
.F G
FindByNameAsyncG V
(V W
requestW ^
.^ _
UsernameOrEmail_ n
)n o
;o p
if 
( 
user 
== 
null 
) 
user 
= 
await 
_userManager )
.) *
FindByEmailAsync* :
(: ;
request; B
.B C
UsernameOrEmailC R
)R S
;S T
if   
(   
user   
==   
null   
)   
throw!! 
new!! !
NotFoundUserException!! /
(!!/ 0
)!!0 1
;!!1 2
SignInResult## 
result## 
=##  !
await##" '
_signInManager##( 6
.##6 7$
CheckPasswordSignInAsync##7 O
(##O P
user##P T
,##T U
request##V ]
.##] ^
Password##^ f
,##f g
false##h m
)##m n
;##n o
if%% 
(%% 
result%% 
.%% 
	Succeeded%%  
==%%! #
false%%$ )
)%%) *
throw&& 
new&& !
NotFoundUserException&& /
(&&/ 0
)&&0 1
;&&1 2
Token)) 
token)) 
=)) 
_tokenHandler)) '
.))' (
CreateAccessToken))( 9
())9 :
$num)): ;
,)); <
user))= A
)))A B
;))B C
await++ 
_userService++ 
.++ 
UpdateRefreshToken++ 1
(++1 2
token++2 7
.++7 8
RefreshToken++8 D
,++D E
user++F J
.++J K
Id++K M
,++M N
token++O T
.++T U

Expiration++U _
,++_ `
$num++a b
)++b c
;++c d
return-- 
new-- $
LoginUserCommandResponse-- /
(--/ 0
)--0 1
{.. 
Token// 
=// 
token// 
}00 
;00 
}33 	
}44 
}55 ƒ
´D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\AppUser\LoginUser\LoginUserCommandRequest.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
AppUser4 ;
.; <
	LoginUser< E
{		 
public

 

class

 #
LoginUserCommandRequest

 (
:

) *
IRequest

* 2
<

2 3$
LoginUserCommandResponse

3 K
>

K L
{ 
public 
string 
UsernameOrEmail %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
string 
Password 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
} ∂
¨D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\AppUser\LoginUser\LoginUserCommandResponse.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
AppUser4 ;
.; <
	LoginUser< E
{		 
public

 

class

 $
LoginUserCommandResponse

 )
{ 
public 
Token 
Token 
{ 
get  
;  !
set" %
;% &
}' (
} 
} à
±D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\AppUser\RefreshToken\RefreshTokenCommandHandler.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
AppUser4 ;
.; <
RefreshToken< H
{		 
public

 

class

 &
RefreshTokenCommandHandler

 +
:

, -
IRequestHandler

. =
<

= >&
RefreshTokenCommandRequest

> X
,

X Y'
RefreshTokenCommandResponse

Z u
>

u v
{ 
private 
readonly 
UserManager $
<$ %
Domain% +
.+ ,
Entities, 4
.4 5
Identity5 =
.= >
AppUser> E
>E F
_userManagerG S
;S T
private 
readonly 
ITokenHandler &
_tokenHandler' 4
;4 5
private 
readonly 
IUserService %
_userService& 2
;2 3
public &
RefreshTokenCommandHandler )
() *
UserManager* 5
<5 6
Domain6 <
.< =
Entities= E
.E F
IdentityF N
.N O
AppUserO V
>V W
userManagerX c
,c d
ITokenHandlere r
tokenHandlers 
,	 Ä
IUserService
Å ç
userService
é ô
)
ô ö
{ 	
_userManager 
= 
userManager &
;& '
_tokenHandler 
= 
tokenHandler (
;( )
_userService 
= 
userService &
;& '
} 	
public 
async 
Task 
< '
RefreshTokenCommandResponse 5
>5 6
Handle7 =
(= >&
RefreshTokenCommandRequest> X
requestY `
,` a
CancellationTokenb s
cancellationToken	t Ö
)
Ö Ü
{ 	
Domain 
. 
Entities 
. 
Identity $
.$ %
AppUser% ,
?, -
user. 2
=3 4
await5 :
_userManager; G
.G H
UsersH M
.M N
FirstOrDefaultAsyncN a
(a b
ub c
=>d f
ug h
.h i
RefreshTokeni u
==v x
request	y Ä
.
Ä Å
RefreshToken
Å ç
)
ç é
;
é è
if 
( 
user 
!= 
null 
&& 
user  $
?$ %
.% &
RefreshTokenEndDate& 9
>: ;
DateTime< D
.D E
UtcNowE K
)K L
{ 
Token 
token 
= 
_tokenHandler +
.+ ,
CreateAccessToken, =
(= >
$num> ?
,? @
userA E
)E F
;F G
await 
_userService "
." #
UpdateRefreshToken# 5
(5 6
token6 ;
.; <
RefreshToken< H
,H I
userJ N
.N O
IdO Q
,Q R
tokenS X
.X Y

ExpirationY c
,c d
$nume f
)f g
;g h
return 
new '
RefreshTokenCommandResponse 6
(6 7
)7 8
{9 :
Token: ?
=@ A
tokenB G
}H I
;I J
} 
return   
new   
(   
)   
;   
}!! 	
}"" 
}## ¥
±D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\AppUser\RefreshToken\RefreshTokenCommandRequest.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
AppUser4 ;
.; <
RefreshToken< H
{		 
public

 

class

 &
RefreshTokenCommandRequest

 +
:

+ ,
IRequest

, 4
<

4 5'
RefreshTokenCommandResponse

5 P
>

P Q
{ 
public 
string 
RefreshToken "
{# $
get% (
;( )
set* -
;- .
}/ 0
} 
} ¬
≤D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\AppUser\RefreshToken\RefreshTokenCommandResponse.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
AppUser4 ;
.; <
RefreshToken< H
{		 
public

 

class

 '
RefreshTokenCommandResponse

 ,
{ 
public 
Token 
Token 
{ 
get  
;  !
set" %
;% &
}' (
} 
} ƒ
¿D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\ProductImageFiles\RemoveProductImage\RemoveProductImageHandler.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
ProductImageFiles4 E
.E F
RemoveProductImageF X
{ 
public 

class %
RemoveProductImageHandler *
:+ ,
IRequestHandler- <
<< =%
RemoveProductImageRequest= V
,V W&
RemoveProductImageResponseX r
>r s
{		 
private

 
readonly

 "
IProductReadRepository

 /"
_productReadRepository

0 F
;

F G
private 
readonly #
IProductWriteRepository 0#
_productWriteRepository1 H
;H I
public %
RemoveProductImageHandler (
(( )"
IProductReadRepository) ?!
productReadRepository@ U
,U V#
IProductWriteRepositoryW n#
productWriteRepository	o Ö
)
Ö Ü
{ 	"
_productReadRepository "
=# $!
productReadRepository% :
;: ;#
_productWriteRepository #
=$ %"
productWriteRepository& <
;< =
} 	
public 
async 
Task 
< &
RemoveProductImageResponse 4
>4 5
Handle6 <
(< =%
RemoveProductImageRequest= V
requestW ^
,^ _
CancellationToken` q
cancellationToken	r É
)
É Ñ
{ 	
Domain 
. 
Entities 
. 
Product #
?# $
product% ,
=- .
await/ 4"
_productReadRepository5 K
.K L
TableL Q
.Q R
IncludeR Y
(Y Z
pZ [
=>\ ^
p_ `
.` a
ProductImageFilesa r
)r s
.s t 
FirstOrDefaultAsync	t á
(
á à
p
à â
=>
ä å
p
ç é
.
é è
Id
è ë
==
í î
Guid
ï ô
.
ô ö
Parse
ö ü
(
ü †
request
† ß
.
ß ®
Id
® ™
)
™ ´
)
´ ¨
;
¨ ≠
ProductImageFile 
? 
productImageFile .
=/ 0
product1 8
?8 9
.9 :
ProductImageFiles: K
.K L
FirstOrDefaultL Z
(Z [
p[ \
=>] _
p` a
.a b
Idb d
==e g
Guidh l
.l m
Parsem r
(r s
requests z
.z {
ImageId	{ Ç
)
Ç É
)
É Ñ
;
Ñ Ö
if 
( 
productImageFile  
!=! #
null$ (
)( )
product 
? 
. 
ProductImageFiles *
.* +
Remove+ 1
(1 2
productImageFile2 B
)B C
;C D
await #
_productWriteRepository )
.) *
	SaveAsync* 3
(3 4
)4 5
;5 6
return 
new &
RemoveProductImageResponse 1
(1 2
)2 3
;3 4
} 	
}   
}!! Ä
¿D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\ProductImageFiles\RemoveProductImage\RemoveProductImageRequest.cs
	namespace		 	
ETicaretAPI		
 
.		 
Application		 !
.		! "
Features		" *
.		* +
Commands		+ 3
.		3 4
ProductImageFiles		4 E
.		E F
RemoveProductImage		F X
{

 
public 

class %
RemoveProductImageRequest *
:+ ,
IRequest- 5
<5 6&
RemoveProductImageResponse6 P
>P Q
{ 
public 
string 
? 
Id 
{ 
get 
;  
set! $
;$ %
}& '
public 
string 
? 
ImageId 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
} »
¡D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\ProductImageFiles\RemoveProductImage\RemoveProductImageResponse.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
ProductImageFiles4 E
.E F
RemoveProductImageF X
{ 
public		 

class		 &
RemoveProductImageResponse		 +
{

 
} 
} ã!
¿D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\ProductImageFiles\UploadProductImage\UploadProductImageHandler.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
ProductImageFiles4 E
.E F
UploadProductImageF X
{ 
public 

class %
UploadProductImageHandler *
:+ ,
IRequestHandler- <
<< =%
UploadProductImageRequest= V
,V W&
UploadProductImageResponseX r
>r s
{ 
private 
readonly 
IStorageService %
_storageService& 5
;5 6
private 
readonly "
IProductReadRepository /"
_productReadRepository0 F
;F G
private 
readonly ,
 IProductImageFileWriteRepository 9,
 _productImageFileWriteRepository: Z
;Z [
public %
UploadProductImageHandler (
(( )
IStorageService) 8
storageService9 G
,G H"
IProductReadRepositoryI _!
productReadRepository` u
,u v-
 IProductImageFileWriteRepository	w ó-
productImageFileWriteRepository
ò ∑
)
∑ ∏
{ 	
_storageService 
= 
storageService ,
;, -"
_productReadRepository "
=# $!
productReadRepository% :
;: ;,
 _productImageFileWriteRepository ,
=- .+
productImageFileWriteRepository/ N
;N O
} 	
public 
async 
Task 
< &
UploadProductImageResponse 4
>4 5
Handle6 <
(< =%
UploadProductImageRequest= V
requestW ^
,^ _
CancellationToken` q
cancellationToken	r É
)
É Ñ
{ 	
List 
< 
( 
string 
fileName !
,! "
string# )
pathOrContainerName* =
)= >
>> ?
result@ F
=G H
awaitI N
_storageServiceO ^
.^ _
UploadAsync_ j
(j k
$strk y
,y z
request	{ Ç
.
Ç É
Files
É à
)
à â
;
â ä
Domain 
. 
Entities 
. 
Product #
product$ +
=, -
await. 3"
_productReadRepository4 J
.J K
GetByIdAsyncK W
(W X
requestX _
._ `
Id` b
)b c
;c d
await!! ,
 _productImageFileWriteRepository!! 2
.!!2 3
AddRangeAsync!!3 @
(!!@ A
result!!A G
.!!G H
Select!!H N
(!!N O
d!!O P
=>!!Q S
new!!T W
ProductImageFile!!X h
(!!h i
)!!i j
{"" 
FileName## 
=## 
d## 
.## 
fileName## %
,##% &
FilePath$$ 
=$$ 
d$$ 
.$$ 
pathOrContainerName$$ 0
,$$0 1
Storage%% 
=%% 
_storageService%% )
.%%) *
StorageName%%* 5
,%%5 6
Products&& 
=&& 
new&& 
List&& #
<&&# $
Domain&&$ *
.&&* +
Entities&&+ 3
.&&3 4
Product&&4 ;
>&&; <
(&&< =
)&&= >
{&&? @
product&&A H
}&&I J
}(( 
)(( 
.(( 
ToList(( 
((( 
)(( 
)(( 
;(( 
await** ,
 _productImageFileWriteRepository** 2
.**2 3
	SaveAsync**3 <
(**< =
)**= >
;**> ?
return++ 
new++ 
(++ 
)++ 
;++ 
},, 	
}-- 
}.. ¸
¿D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\ProductImageFiles\UploadProductImage\UploadProductImageRequest.cs
	namespace

 	
ETicaretAPI


 
.

 
Application

 !
.

! "
Features

" *
.

* +
Commands

+ 3
.

3 4
ProductImageFiles

4 E
.

E F
UploadProductImage

F X
{ 
public 

class %
UploadProductImageRequest *
:+ ,
IRequest- 5
<5 6&
UploadProductImageResponse6 P
>P Q
{ 
public 
string 
Id 
{ 
get 
; 
set  #
;# $
}% &
public 
IFormFileCollection "
?" #
Files$ )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
} 
} »
¡D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\ProductImageFiles\UploadProductImage\UploadProductImageResponse.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
ProductImageFiles4 E
.E F
UploadProductImageF X
{ 
public		 

class		 &
UploadProductImageResponse		 +
{

 
} 
} Ü
≥D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\Product\CreateProduct\CreateProductCommandHandler.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
Product4 ;
.; <
CreateProduct< I
{ 
public 

class '
CreateProductCommandHandler ,
:- .
IRequestHandler/ >
<> ?'
CreateProductCommandRequest? Z
,Z [(
CreateProductCommandResponse\ x
>x y
{ 
private		 
readonly		 #
IProductWriteRepository		 0#
_productWriteRepository		1 H
;		H I
private

 
readonly

 
IProductHubService

 +
_productHubService

, >
;

> ?
public '
CreateProductCommandHandler *
(* +#
IProductWriteRepository+ B"
productWriteRepositoryC Y
,Y Z
IProductHubService[ m
productHubServicen 
)	 Ä
{ 	#
_productWriteRepository #
=$ %"
productWriteRepository& <
;< =
_productHubService 
=  
productHubService! 2
;2 3
} 	
public 
async 
Task 
< (
CreateProductCommandResponse 6
>6 7
Handle8 >
(> ?'
CreateProductCommandRequest? Z
request[ b
,b c
CancellationTokend u
cancellationToken	v á
)
á à
{ 	
await #
_productWriteRepository )
.) *
AddAsync* 2
(2 3
new3 6
Domain7 =
.= >
Entities> F
.F G
ProductG N
(N O
)O P
{ 
Name 
= 
request 
. 
Name #
,# $
Price 
= 
request 
.  
Price  %
,% &
Stock 
= 
request 
.  
Stock  %
} 
) 
; 
await #
_productWriteRepository )
.) *
	SaveAsync* 3
(3 4
)4 5
;5 6
await
 
_productHubService #
.# $$
ProductAddedMessageAsync$ <
(< =
$"= ?
{? @
request@ G
.G H
NameH L
}L M
$strM Y
"Y Z
)Z [
;[ \
return 
new (
CreateProductCommandResponse 3
(3 4
)4 5
;5 6
} 	
}   
}!! ·
≥D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\Product\CreateProduct\CreateProductCommandRequest.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
Product4 ;
.; <
CreateProduct< I
{		 
public

 

class

 '
CreateProductCommandRequest

 ,
:

- .
IRequest

/ 7
<

7 8(
CreateProductCommandResponse

8 T
>

T U
{ 
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
int 
Stock 
{ 
get 
; 
set  #
;# $
}% &
public 
decimal 
Price 
{ 
get "
;" #
set$ '
;' (
}) *
} 
} Æ
¥D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\Product\CreateProduct\CreateProductCommandResponse.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
Product4 ;
.; <
CreateProduct< I
{ 
public		 

class		 (
CreateProductCommandResponse		 -
{

 
} 
} Ç
≥D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\Product\RemoveProduct\RemoveProductCommandHandler.cs
	namespace

 	
ETicaretAPI


 
.

 
Application

 !
.

! "
Features

" *
.

* +
Commands

+ 3
.

3 4
Product

4 ;
.

; <
RemoveProduct

< I
{ 
public 

class '
RemoveProductCommandHandler ,
:- .
IRequestHandler/ >
<> ?'
RemoveProductCommandRequest? Z
,Z [(
RemoveProductCommandResponse\ x
>x y
{ 
private 
readonly #
IProductWriteRepository 0#
_productWriteRepository1 H
;H I
public '
RemoveProductCommandHandler *
(* +#
IProductWriteRepository+ B"
productWriteRepositoryC Y
)Y Z
{ 	#
_productWriteRepository #
=$ %"
productWriteRepository& <
;< =
} 	
public 
async 
Task 
< (
RemoveProductCommandResponse 6
>6 7
Handle8 >
(> ?'
RemoveProductCommandRequest? Z
request[ b
,b c
CancellationTokend u
cancellationToken	v á
)
á à
{ 	
await #
_productWriteRepository )
.) *
RemoveAsync* 5
(5 6
request6 =
.= >
Id> @
)@ A
;A B
await #
_productWriteRepository )
.) *
	SaveAsync* 3
(3 4
)4 5
;5 6
return 
new 
( 
) 
; 
} 	
} 
} Ø
≥D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\Product\RemoveProduct\RemoveProductCommandRequest.cs
	namespace		 	
ETicaretAPI		
 
.		 
Application		 !
.		! "
Features		" *
.		* +
Commands		+ 3
.		3 4
Product		4 ;
.		; <
RemoveProduct		< I
{

 
public 

class '
RemoveProductCommandRequest ,
:- .
IRequest/ 7
<7 8(
RemoveProductCommandResponse8 T
>T U
{ 
public 
string 
Id 
{ 
get 
; 
set  #
;# $
}% &
} 
} Æ
¥D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\Product\RemoveProduct\RemoveProductCommandResponse.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
Product4 ;
.; <
RemoveProduct< I
{ 
public		 

class		 (
RemoveProductCommandResponse		 -
{

 
} 
} Â
≥D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\Product\UpdateProduct\UpdateProductCommandHandler.cs
	namespace

 	
ETicaretAPI


 
.

 
Application

 !
.

! "
Features

" *
.

* +
Commands

+ 3
.

3 4
Product

4 ;
.

; <
UpdateProduct

< I
{ 
public 

class '
UpdateProductCommandHandler ,
:- .
IRequestHandler/ >
<> ?'
UpdateProductCommandRequest? Z
,Z [(
UpdateProductCommandResponse\ x
>x y
{ 
private 
readonly #
IProductWriteRepository 0#
_productWriteRepository1 H
;H I
private 
readonly "
IProductReadRepository /"
_productReadRepository0 F
;F G
public '
UpdateProductCommandHandler *
(* +#
IProductWriteRepository+ B"
productWriteRepositoryC Y
,Y Z"
IProductReadRepository[ q"
productReadRepository	r á
)
á à
{ 	#
_productWriteRepository #
=$ %"
productWriteRepository& <
;< ="
_productReadRepository "
=# $!
productReadRepository% :
;: ;
} 	
public 
async 
Task 
< (
UpdateProductCommandResponse 6
>6 7
Handle8 >
(> ?'
UpdateProductCommandRequest? Z
request[ b
,b c
CancellationTokend u
cancellationToken	v á
)
á à
{ 	
Domain 
. 
Entities 
. 
Product #
product% ,
=- .
await/ 4"
_productReadRepository5 K
.K L
GetByIdAsyncL X
(X Y
requestY `
.` a
Ida c
)c d
;d e
product 
. 
Price 
= 
request #
.# $
Price$ )
;) *
product 
. 
Stock 
= 
request #
.# $
Stock$ )
;) *
product 
. 
Name 
= 
request "
." #
Name# '
;' (
await #
_productWriteRepository )
.) *
	SaveAsync* 3
(3 4
)4 5
;5 6
return 
new 
( 
) 
; 
} 	
}   
}!! ˜	
≥D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\Product\UpdateProduct\UpdateProductCommandRequest.cs
	namespace		 	
ETicaretAPI		
 
.		 
Application		 !
.		! "
Features		" *
.		* +
Commands		+ 3
.		3 4
Product		4 ;
.		; <
UpdateProduct		< I
{

 
public 

class '
UpdateProductCommandRequest ,
:- .
IRequest/ 7
<7 8(
UpdateProductCommandResponse8 T
>T U
{ 
public 
string 
Id 
{ 
get 
; 
set  #
;# $
}% &
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
int 
Stock 
{ 
get 
; 
set  #
;# $
}% &
public 
decimal 
Price 
{ 
get "
;" #
set$ '
;' (
}) *
} 
} Æ
¥D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Commands\Product\UpdateProduct\UpdateProductCommandResponse.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Commands+ 3
.3 4
Product4 ;
.; <
UpdateProduct< I
{ 
public		 

class		 (
UpdateProductCommandResponse		 -
{

 
} 
} •
∫D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Queries\ProductImageFile\GetProductImages\GetProductImagesHandler.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Queries+ 2
.2 3
ProductImageFile3 C
.C D
GetProductImagesD T
{ 
public 

class #
GetProductImagesHandler (
:) *
IRequestHandler+ :
<: ;#
GetProductImagesRequest; R
,R S
ListT X
<X Y$
GetProductImagesResponseY q
>q r
>r s
{ 
private 
readonly "
IProductReadRepository /"
_productReadRepository0 F
;F G
private 
readonly 
IConfiguration '
_configuration( 6
;6 7
public 
async 
Task 
< 
List 
< $
GetProductImagesResponse 7
>7 8
>8 9
Handle: @
(@ A#
GetProductImagesRequestA X
requestY `
,` a
CancellationTokenb s
cancellationToken	t Ö
)
Ö Ü
{ 	
Domain 
. 
Entities 
. 
Product #
?# $
product% ,
=- .
await/ 4"
_productReadRepository5 K
.K L
TableL Q
.Q R
IncludeR Y
(Y Z
pZ [
=>\ ^
p_ `
.` a
ProductImageFilesa r
)r s
.s t 
FirstOrDefaultAsync	t á
(
á à
p
à â
=>
ä å
p
ç é
.
é è
Id
è ë
==
í î
Guid
ï ô
.
ô ö
Parse
ö ü
(
ü †
request
† ß
.
ß ®
Id
® ™
)
™ ´
)
´ ¨
;
¨ ≠
return 
product 
. 
ProductImageFiles -
.- .
Select. 4
(4 5
y5 6
=>7 9
new: =$
GetProductImagesResponse> V
{ 
FilePath 
= 
$" 
{ 
_configuration ,
[, -
$str- =
]= >
}> ?
$str? @
{@ A
yA B
.B C
FilePathC K
}K L
"L M
,M N
FileName 
= 
y 
. 
FileName &
,& '
Id 
= 
y 
. 
Id 
} 
) 
. 
ToList 
( 
) 
; 
} 	
} 
}   È
∫D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Queries\ProductImageFile\GetProductImages\GetProductImagesRequest.cs
	namespace		 	
ETicaretAPI		
 
.		 
Application		 !
.		! "
Features		" *
.		* +
Queries		+ 2
.		2 3
ProductImageFile		3 C
.		C D
GetProductImages		D T
{

 
public 

class #
GetProductImagesRequest (
:) *
IRequest+ 3
<3 4
List4 8
<8 9$
GetProductImagesResponse9 Q
>Q R
>R S
{ 
public 
string 
Id 
{ 
get 
; 
set  #
;# $
}% &
} 
} à
ªD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Queries\ProductImageFile\GetProductImages\GetProductImagesResponse.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Queries+ 2
.2 3
ProductImageFile3 C
.C D
GetProductImagesD T
{ 
public		 

class		 $
GetProductImagesResponse		 )
{

 
public 
string 
FilePath 
{  
get! $
;$ %
set' *
;* +
}, -
public 
string 
FileName 
{  
get! $
;$ %
set' *
;* +
}, -
public 
Guid 
Id 
{ 
get 
; 
set "
;" #
}$ %
} 
} ˝
∞D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Queries\Product\GetAllProduct\GetAllProductQueryHandler.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Queries+ 2
.2 3
Product3 :
.: ;
GetAllProduct; H
{ 
public 

class %
GetAllProductQueryHandler *
:+ ,
IRequestHandler- <
<< =%
GetAllProductQueryRequest= V
,V W&
GetAllProductQueryResponseX r
>r s
{ 
private 
readonly "
IProductReadRepository /"
_productReadRepository0 F
;F G
public %
GetAllProductQueryHandler (
(( )"
IProductReadRepository) ?!
productReadRepository@ U
)U V
{ 	"
_productReadRepository "
=# $!
productReadRepository% :
;: ;
} 	
public 
async 
Task 
< &
GetAllProductQueryResponse 4
>4 5
Handle6 <
(< =%
GetAllProductQueryRequest= V
requestW ^
,^ _
CancellationToken` q
cancellationToken	r É
)
É Ñ
{ 	
var 
query 
= "
_productReadRepository .
.. /
GetAll/ 5
(5 6
tracking6 >
:> ?
false@ E
)E F
;F G
var 
products 
= 
query  
. 
Paginate 
( 
page 
: 
request  '
.' (
Page( ,
,, -
pageSize. 6
:6 7
request8 ?
.? @
Size@ D
,D E
orderByF M
:M N
pO P
=>Q S
pT U
.U V
CreatedDateV a
,a b

descendingc m
:m n
trueo s
)s t
. 
Include 
( 
y 
=> 
y 
.  
ProductImageFiles  1
)1 2
. 
Select 
( 
p 
=> 
new  
{ 
p 
. 
Id 
, 
p 
. 
Name 
, 
p   
.   
Stock   
,   
p!! 
.!! 
Price!! 
,!! 
p"" 
."" 
CreatedDate"" !
,""! "
p## 
.## 
UpdatedDate## !
,##! "
productImageFile$$ $
=$$% &
p$$( )
.$$) *
ProductImageFiles$$* ;
.$$; <
FirstOrDefault$$< J
($$J K
)$$K L
}%% 
)%% 
;%% 
var'' 

totalCount'' 
='' 
query'' "
.''" #
Count''# (
(''( )
)'') *
;''* +
return)) 
new)) &
GetAllProductQueryResponse)) 1
())1 2
)))2 3
{** 

TotalCount++ 
=++ 

totalCount++ '
,++' (
Products,, 
=,, 
products,, #
}-- 
;-- 
}.. 	
}// 
}00 õ
∞D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Queries\Product\GetAllProduct\GetAllProductQueryRequest.cs
	namespace		 	
ETicaretAPI		
 
.		 
Application		 !
.		! "
Features		" *
.		* +
Queries		+ 2
.		2 3
Product		3 :
.		: ;
GetAllProduct		; H
{

 
public 

class %
GetAllProductQueryRequest *
:+ ,
IRequest- 5
<5 6&
GetAllProductQueryResponse6 P
>P Q
{ 
public 
int 
Page 
{ 
get 
; 
set "
;" #
}$ %
=& '
$num( )
;) *
public 
int 
Size 
{ 
get 
; 
set "
;" #
}$ %
=& '
$num( )
;) *
} 
} ﬂ
±D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Queries\Product\GetAllProduct\GetAllProductQueryResponse.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Queries+ 2
.2 3
Product3 :
.: ;
GetAllProduct; H
{ 
public		 

class		 &
GetAllProductQueryResponse		 +
{

 
public 
int 

TotalCount 
{ 
get  #
;# $
set% (
;( )
}* +
public 
object 
Products 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
} Ø
≤D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Queries\Product\GetByIdProduct\GetByIdProductQueryHandler.cs
	namespace

 	
ETicaretAPI


 
.

 
Application

 !
.

! "
Features

" *
.

* +
Queries

+ 2
.

2 3
Product

3 :
.

: ;
GetByIdProduct

; I
{ 
public 

class &
GetByIdProductQueryHandler +
:, -
IRequestHandler. =
<= >&
GetByIdProductQueryRequest> X
,X Y'
GetByIdProductQueryResponseZ u
>u v
{ 
private 
readonly "
IProductReadRepository /"
_productReadRepository0 F
;F G
public &
GetByIdProductQueryHandler )
() *"
IProductReadRepository* @!
productReadRepositoryA V
)V W
{ 	"
_productReadRepository "
=# $!
productReadRepository% :
;: ;
} 	
public 
async 
Task 
< '
GetByIdProductQueryResponse 5
>5 6
Handle7 =
(= >&
GetByIdProductQueryRequest> X
requestY `
,` a
CancellationTokenb s
cancellationToken	t Ö
)
Ö Ü
{ 	
Domain 
. 
Entities 
. 
Product #
product$ +
=, -
await. 3"
_productReadRepository4 J
.J K
GetByIdAsyncK W
(W X
requestX _
._ `
Id` b
,b c
trackingd l
:l m
falsen s
)s t
;t u
return 
new '
GetByIdProductQueryResponse 2
(2 3
)3 4
{ 
Name 
= 
product 
. 
Name #
,# $
Price 
= 
product 
.  
Price  %
,% &
Stock 
= 
product 
.  
Stock  %
,% &
} 
; 
} 	
} 
} ¨
≤D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Queries\Product\GetByIdProduct\GetByIdProductQueryRequest.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Queries+ 2
.2 3
Product3 :
.: ;
GetByIdProduct; I
{ 
public 

class &
GetByIdProductQueryRequest +
:, -
IRequest. 6
<6 7'
GetByIdProductQueryResponse7 R
>R S
{ 
public 
string 
Id 
{ 
get 
; 
set  #
;# $
}% &
} 
}		 Ù
≥D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Features\Queries\Product\GetByIdProduct\GetByIdProductQueryResponse.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Features" *
.* +
Queries+ 2
.2 3
Product3 :
.: ;
GetByIdProduct; I
{		 
public

 

class

 '
GetByIdProductQueryResponse

 ,
{ 
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
int 
Stock 
{ 
get 
; 
set  #
;# $
}% &
public 
decimal 
Price 
{ 
get "
;" #
set$ '
;' (
}) *
} 
} ú
ùD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Repositories\Customer\ICustomerReadRepository.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Repositories" .
.. /
Customer/ 7
{ 
public 

	interface #
ICustomerReadRepository ,
:, -
IReadRepository- <
<< =
ETicaretAPI= H
.H I
DomainI O
.O P
EntitiesP X
.X Y
CustomerY a
>a b
{ 
} 
} ü
ûD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Repositories\Customer\ICustomerWriteRepository.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Repositories" .
.. /
Customer/ 7
{ 
public 

	interface $
ICustomerWriteRepository -
:. /
IWriteRepository0 @
<@ A
ETicaretAPIA L
.L M
DomainM S
.S T
EntitiesT \
.\ ]
Customer] e
>e f
{ 
} 
} à
ïD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Repositories\File\IFileReadRepository.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Repositories" .
.. /
File/ 3
{ 
public		 

	interface		 
IFileReadRepository		 (
:		) *
IReadRepository		+ :
<		: ;
ETicaretAPI		; F
.		F G
Domain		G M
.		M N
Entities		N V
.		V W
File		W [
>		[ \
{

 
} 
} ã
ñD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Repositories\File\IFileWriteRepository.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Repositories" .
.. /
File/ 3
{ 
public		 

	interface		  
IFileWriteRepository		 )
:		* +
IWriteRepository		, <
<		< =
ETicaretAPI		= H
.		H I
Domain		I O
.		O P
Entities		P X
.		X Y
File		Y ]
>		] ^
{

 
} 
} ´
£D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Repositories\InvoiceFile\IInvoiceFileReadRepository.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Repositories" .
.. /
InvoiceFile/ :
{ 
public		 

	interface		 &
IInvoiceFileReadRepository		 /
:		0 1
IReadRepository		2 A
<		A B
ETicaretAPI		B M
.		M N
Domain		N T
.		T U
Entities		U ]
.		] ^
InvoiceFile		^ i
>		i j
{

 
} 
} Æ
§D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Repositories\InvoiceFile\IInvoiceFileWriteRepository.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Repositories" .
.. /
InvoiceFile/ :
{ 
public		 

	interface		 '
IInvoiceFileWriteRepository		 0
:		1 2
IWriteRepository		3 C
<		C D
ETicaretAPI		D O
.		O P
Domain		P V
.		V W
Entities		W _
.		_ `
InvoiceFile		` k
>		k l
{

 
} 
} æ
åD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Repositories\IReadRepository.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Repositories" .
{ 
public 

	interface 
IReadRepository $
<$ %
T% &
>& '
:( )
IRepository* 5
<5 6
T6 7
>7 8
where9 >
T? @
:A B

BaseEntityC M
{ 

IQueryable 
< 
T 
> 
GetAll 
( 
bool !
tracking" *
=+ ,
true- 1
)1 2
;2 3

IQueryable		 
<		 
T		 
>		 
GetWhere		 
(		 

Expression		 )
<		) *
Func		* .
<		. /
T		/ 0
,		0 1
bool		2 6
>		6 7
>		7 8
method		9 ?
,		? @
bool		A E
tracking		F N
=		O P
true		Q U
)		U V
;		V W
Task

 
<

 
T

 
>

 
GetSingleAsync

 
(

 

Expression

 )
<

) *
Func

* .
<

. /
T

/ 0
,

0 1
bool

2 6
>

6 7
>

7 8
method

9 ?
,

? @
bool

A E
tracking

F N
=

O P
true

Q U
)

U V
;

V W
Task 
< 
T 
> 
GetByIdAsync 
( 
string #
id$ &
,& '
bool( ,
tracking- 5
=6 7
true8 <
)< =
;= >
} 
} ç
àD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Repositories\IRepository.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Repositories" .
{ 
public 

	interface 
IRepository  
<  !
T! "
>" #
where$ )
T* +
:, -

BaseEntity. 8
{ 
DbSet 
< 
T 
> 
Table 
{ 
get 
; 
} 
}		 
}

 ¶
çD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Repositories\IWriteRepository.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Repositories" .
{ 
public 

	interface 
IWriteRepository %
<% &
T& '
>' (
:) *
IRepository+ 6
<6 7
T7 8
>8 9
where: ?
T@ A
:B C

BaseEntityD N
{ 
Task 
< 
bool 
> 
AddAsync 
( 
T 
entity $
)$ %
;% &
Task 
< 
bool 
> 
AddRangeAsync  
(  !
List! %
<% &
T& '
>' (
datas) .
). /
;/ 0
bool		 
Remove		 
(		 
T		 
entity		 
)		 
;		 
bool

 
RemoveRange

 
(

 
List

 
<

 
T

 
>

  
datas

! &
)

& '
;

' (
Task 
< 
bool 
> 
RemoveAsync 
( 
string %
id& (
)( )
;) *
bool 
Update 
( 
T 
entity 
) 
; 
Task 
< 
int 
> 
	SaveAsync 
( 
) 
; 
} 
} ç
óD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Repositories\Order\IOrderReadRepository.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Repositories" .
.. /
Order/ 4
{ 
public 

	interface  
IOrderReadRepository )
:* +
IReadRepository, ;
<; <
ETicaretAPI< G
.G H
DomainH N
.N O
EntitiesO W
.W X
OrderX ]
>] ^
{ 
} 
} ê
òD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Repositories\Order\IOrderWriteRepository.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Repositories" .
.. /
Order/ 4
{ 
public 

	interface !
IOrderWriteRepository *
:+ ,
IWriteRepository- =
<= >
ETicaretAPI> I
.I J
DomainJ P
.P Q
EntitiesQ Y
.Y Z
OrderZ _
>_ `
{ 
} 
} ƒ
≠D:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Repositories\ProductImageFile\IProductImageFileReadRepository.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Repositories" .
.. /
ProductImageFile/ ?
{ 
public		 

	interface		 +
IProductImageFileReadRepository		 4
:		5 6
IReadRepository		7 F
<		F G
ETicaretAPI		G R
.		R S
Domain		S Y
.		Y Z
Entities		Z b
.		b c
ProductImageFile		c s
>		s t
{

 
} 
} «
ÆD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Repositories\ProductImageFile\IProductImageFileWriteRepository.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Repositories" .
.. /
ProductImageFile/ ?
{ 
public		 

	interface		 ,
 IProductImageFileWriteRepository		 5
:		6 7
IWriteRepository		8 H
<		H I
ETicaretAPI		I T
.		T U
Domain		U [
.		[ \
Entities		\ d
.		d e
ProductImageFile		e u
>		u v
{

 
} 
} ó
õD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Repositories\Product\IProductReadRepository.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Repositories" .
.. /
Product/ 6
{ 
public 

	interface "
IProductReadRepository +
:, -
IReadRepository. =
<= >
ETicaretAPI> I
.I J
DomainJ P
.P Q
EntitiesQ Y
.Y Z
ProductZ a
>a b
{ 
} 
} ö
úD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Repositories\Product\IProductWriteRepository.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
Repositories" .
.. /
Product/ 6
{ 
public 

	interface #
IProductWriteRepository ,
:- .
IWriteRepository/ ?
<? @
ETicaretAPI@ K
.K L
DomainL R
.R S
EntitiesS [
.[ \
Product\ c
>c d
{ 
} 
} ô
åD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\RequestParameters\Pagination.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "
RequestParameters" 3
{ 
public 

record 

Pagination 
{ 
public 
int 
Page 
{ 
get 
; 
set "
;" #
}$ %
=& '
$num( )
;) *
public 
int 
PageSize 
{ 
get !
;! "
set# &
;& '
}( )
=* +
$num, -
;- .
} 
}		 ¸
ÉD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\ServiceRegistration.cs
	namespace 	
ETicaretAPI
 
. 
Application !
{ 
public 

static 
class 
ServiceRegistration +
{ 
public 
static 
void "
AddApplicationServices 1
(1 2
this2 6
IServiceCollection7 I
servicesJ R
)R S
{		 	
services 
. 

AddMediatR 
(  
typeof  &
(& '
ServiceRegistration' :
): ;
); <
;< =
services 
. 
AddHttpClient "
(" #
)# $
;$ %
} 	
} 
} «
öD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\Validators\Products\CreateProductValidator.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "

Validators" ,
., -
Products- 5
{ 
public 

class "
CreateProductValidator '
:( )
AbstractValidator* ;
<; <
VM_Create_Product< M
>M N
{ 
public "
CreateProductValidator %
(% &
)& '
{		 	
RuleFor

 
(

 
p

 
=>

 
p

 
.

 
Name

 
)

  
. 
NotEmpty 
( 
) 
. 
NotNull 
( 
) 
. 
WithMessage  
(  !
$str! C
)C D
. 
MaximumLength 
( 
$num "
)" #
. 
MinimumLength 
( 
$num  
)  !
. 
WithMessage  
(  !
$str! X
)X Y
;Y Z
RuleFor 
( 
p 
=> 
p 
. 
Stock  
)  !
. 
NotEmpty 
( 
) 
. 
NotNull 
( 
) 
. 
WithMessage  
(  !
$str! G
)G H
. 
Must 
( 
s 
=> 
s 
>= 
$num  !
)! "
. 
WithMessage  
(  !
$str! K
)K L
;L M
RuleFor 
( 
p 
=> 
p 
. 
Price  
)  !
. 
NotEmpty 
( 
) 
. 
NotNull 
( 
) 
. 
WithMessage 
(  
$str  G
)G H
. 
Must 
( 
s 
=> 
s 
>= 
$num  
)  !
. 
WithMessage 
(  
$str  K
)K L
;L M
}!! 	
}"" 
}## Ä
ïD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\ViewModels\Products\VM_Create_Product.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "

ViewModels" ,
., -
Products- 5
{ 
public 

class 
VM_Create_Product "
{ 
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
int 
Stock 
{ 
get 
; 
set  #
;# $
}% &
public 
decimal 
Price 
{ 
get "
;" #
set$ '
;' (
}) *
} 
}		 ñ
ïD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Application\ViewModels\Products\VM_Update_Product.cs
	namespace 	
ETicaretAPI
 
. 
Application !
.! "

ViewModels" ,
., -
Products- 5
{ 
public		 

class		 
VM_Update_Product		 "
{

 
public 
string 
Id 
{ 
get 
; 
set  #
;# $
}% &
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
int 
Stock 
{ 
get 
; 
set  #
;# $
}% &
public 
decimal 
Price 
{ 
get "
;" #
set$ '
;' (
}) *
} 
} 