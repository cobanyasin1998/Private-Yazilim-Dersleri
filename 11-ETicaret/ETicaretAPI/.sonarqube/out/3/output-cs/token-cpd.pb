™
ëD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Infrastructure\ETicaretAPI.SignalR\Consts\ReceiveFunctionNames.cs
	namespace 	
ETicaretAPI
 
. 
SignalR 
. 
Consts $
{ 
public		 

static		 
class		  
ReceiveFunctionNames		 ,
{

 
public 
const 
string 
ProductAddedMessage /
=0 1
$str2 N
;N O
} 
} Û
ÖD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Infrastructure\ETicaretAPI.SignalR\HubRegistration.cs
	namespace 	
ETicaretAPI
 
. 
SignalR 
{ 
public 

static 
class 
HubRegistration '
{ 
public 
static 
void 
MapHubs "
(" #
this# '
WebApplication( 6
webApplication7 E
)E F
{		 	
webApplication

 
.

 
MapHub

 !
<

! "

ProductHub

" ,
>

, -
(

- .
$str

. <
)

< =
;

= >
} 	
} 
} Å
ìD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Infrastructure\ETicaretAPI.SignalR\HubServices\ProductHubService.cs
	namespace 	
ETicaretAPI
 
. 
SignalR 
. 
HubServices )
{ 
public 

class 
ProductHubService "
:# $
IProductHubService% 7
{		 
private 
readonly 
IHubContext $
<$ %

ProductHub% /
>/ 0
_hubContext1 <
;< =
public 
ProductHubService  
(  !
IHubContext! ,
<, -

ProductHub- 7
>7 8

hubContext9 C
)C D
{ 	
_hubContext 
= 

hubContext $
;$ %
} 	
public 
async 
Task $
ProductAddedMessageAsync 2
(2 3
string3 9
message: A
)A B
{ 	
await 
_hubContext 
. 
Clients %
.% &
All& )
.) *
	SendAsync* 3
(3 4 
ReceiveFunctionNames4 H
.H I
ProductAddedMessageI \
,\ ]
message^ e
)e f
;f g
} 	
} 
} í
ÖD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Infrastructure\ETicaretAPI.SignalR\Hubs\ProductHub.cs
	namespace 	
ETicaretAPI
 
. 
SignalR 
. 
Hubs "
{		 
public

 

class

 

ProductHub

 
:

 
Hub

 
{ 
} 
} í
âD:\Ki≈üisel\Private-Yazilim-Dersleri\Yazƒ±lƒ±m Dersleri\11-ETicaret\ETicaretAPI\Infrastructure\ETicaretAPI.SignalR\ServiceRegistration.cs
	namespace 	
ETicaretAPI
 
. 
SignalR 
{ 
public 

static 
class 
ServiceRegistration +
{ 
public		 
static		 
void		 
AddSignalRServices		 -
(		- .
this		. 2
IServiceCollection		3 E
services		F N
)		N O
{

 	
services 
. 
AddTransient !
<! "
IProductHubService" 4
,4 5
ProductHubService6 G
>G H
(H I
)I J
;J K
services 
. 

AddSignalR 
(  
)  !
;! "
} 	
} 
} 