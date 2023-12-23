�
zD:\Kişisel\Private-Yazilim-Dersleri\Yazılım Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Domain\Entities\Basket.cs
	namespace		 	
ETicaretAPI		
 
.		 
Domain		 
.		 
Entities		 %
{

 
public 

class 
Basket 
: 

BaseEntity #
{ 
public 
string 
UserId 
{ 
get "
;" #
set$ '
;' (
}) *
public 
AppUser 
User 
{ 
get !
;! "
set# &
;& '
}( )
public 
ICollection 
< 

BasketItem %
>% &
BasketItems' 2
{3 4
get5 8
;8 9
set: =
;= >
}? @
} 
} �	
~D:\Kişisel\Private-Yazilim-Dersleri\Yazılım Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Domain\Entities\BasketItem.cs
	namespace 	
ETicaretAPI
 
. 
Domain 
. 
Entities %
{ 
public 

class 

BasketItem 
: 

BaseEntity &
{ 
public 
Guid 
BasketId 
{ 
get "
;" #
set$ '
;' (
}) *
public		 
Guid		 
	ProductId		 
{		 
get		  #
;		# $
set		% (
;		( )
}		* +
public 
int 
Quantity 
{ 
get !
;! "
set# &
;& '
}( )
public 
Basket 
Basket 
{ 
get "
;" #
set$ '
;' (
}) *
public 
Product 
Product 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
} �
�D:\Kişisel\Private-Yazilim-Dersleri\Yazılım Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Domain\Entities\Common\BaseEntity.cs
	namespace 	
ETicaretAPI
 
. 
Domain 
. 
Entities %
.% &
Common& ,
{ 
public 

class 

BaseEntity 
{ 
public 
Guid 
Id 
{ 
get 
; 
set !
;! "
}# $
public 
DateTime 
CreatedDate #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
virtual 
DateTime 
?  
UpdatedDate! ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
} 
}		 �
|D:\Kişisel\Private-Yazilim-Dersleri\Yazılım Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Domain\Entities\Customer.cs
	namespace 	
ETicaretAPI
 
. 
Domain 
. 
Entities %
{ 
public 

class 
Customer 
: 

BaseEntity &
{ 
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public		 
ICollection		 
<		 
Order		  
>		  !
Orders		" (
{		) *
get		+ .
;		. /
set		0 3
;		3 4
}		5 6
}

 
} �

xD:\Kişisel\Private-Yazilim-Dersleri\Yazılım Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Domain\Entities\File.cs
	namespace		 	
ETicaretAPI		
 
.		 
Domain		 
.		 
Entities		 %
{

 
public 

class 
File 
: 

BaseEntity !
{ 
public 
string 
FileName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
FilePath 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Storage 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
	NotMapped	 
] 
public 
override 
DateTime  
?  !
UpdatedDate" -
{. /
get0 3
=>4 6
base7 ;
.; <
UpdatedDate< G
;G H
setI L
=>M O
baseP T
.T U
UpdatedDateU `
=a b
valuec h
;h i
}j k
} 
} �
�D:\Kişisel\Private-Yazilim-Dersleri\Yazılım Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Domain\Entities\Identity\AppRole.cs
	namespace 	
ETicaretAPI
 
. 
Domain 
. 
Entities %
.% &
Identity& .
{		 
public

 

class

 
AppRole

 
:

 
IdentityRole

 '
<

' (
string

( .
>

. /
{ 
} 
} �	
�D:\Kişisel\Private-Yazilim-Dersleri\Yazılım Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Domain\Entities\Identity\AppUser.cs
	namespace 	
ETicaretAPI
 
. 
Domain 
. 
Entities %
.% &
Identity& .
{		 
public

 

class

 
AppUser

 
:

 
IdentityUser

 '
<

' (
string

( .
>

. /
{ 
public 
string 
NameSurname !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
? 
RefreshToken #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
DateTime 
? 
RefreshTokenEndDate ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
ICollection 
< 
Basket !
>! "
Baskets# *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
} 
} �
D:\Kişisel\Private-Yazilim-Dersleri\Yazılım Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Domain\Entities\InvoiceFile.cs
	namespace 	
ETicaretAPI
 
. 
Domain 
. 
Entities %
{ 
public		 

class		 
InvoiceFile		 
:		 
File		 !
{

 
} 
} �	
yD:\Kişisel\Private-Yazilim-Dersleri\Yazılım Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Domain\Entities\Order.cs
	namespace 	
ETicaretAPI
 
. 
Domain 
. 
Entities %
{ 
public 

class 
Order 
: 

BaseEntity #
{ 
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
Address 
{ 
get  #
;# $
set% (
;( )
}* +
public		 
Guid		 

CustomerId		 
{		  
get		! $
;		$ %
set		& )
;		) *
}		+ ,
public 
ICollection 
< 
Product "
>" #
Products$ ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
Customer 
Customer  
{! "
get# &
;& '
set( +
;+ ,
}- .
} 
} �
{D:\Kişisel\Private-Yazilim-Dersleri\Yazılım Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Domain\Entities\Product.cs
	namespace 	
ETicaretAPI
 
. 
Domain 
. 
Entities %
{ 
public 

class 
Product 
: 

BaseEntity %
{ 
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
int 
Stock 
{ 
get 
; 
set  #
;# $
}% &
public		 
decimal		 
Price		 
{		 
get		 "
;		" #
set		$ '
;		' (
}		) *
public 
ICollection 
< 
Order  
>  !
Orders" (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
ICollection 
< 
ProductImageFile +
>+ ,
ProductImageFiles- >
{? @
getA D
;D E
setF I
;I J
}K L
public 
ICollection 
< 

BasketItem %
>% &
BasketItems' 2
{3 4
get5 8
;8 9
set: =
;= >
}? @
} 
} �
�D:\Kişisel\Private-Yazilim-Dersleri\Yazılım Dersleri\11-ETicaret\ETicaretAPI\Core\ETicaretAPI.Domain\Entities\ProductImageFile.cs
	namespace 	
ETicaretAPI
 
. 
Domain 
. 
Entities %
{ 
public		 

class		 
ProductImageFile		 !
:		! "
File		" &
{

 
public 
ICollection 
< 
Product "
>" #
Products$ ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
} 
} 