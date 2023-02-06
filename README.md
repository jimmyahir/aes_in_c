# aes_in_c
AES implementation in C programming language for 128, 192 and 256-bits key sizes. (You can also bigger keys, like 512 bits or even 1024 bytes (way bigger)).

"AES.h" Header file contains following functions:

1) unsigned char _2447_AES_colmul(unsigned char a, unsigned char b)
  I use this function to calculate byte multiplication in Galois field while doing Mix Colulmns operation
  To use this function, you need to pass two different bytes and it will return multiplied value
  
2) void AES_Encrypt(unsigned char* Data, unsigned char* Key, int Key_size, unsigned char **ret)
  To encrypt any data in AES, use this function.
  'Data' variable will be your data that you want to encrypt.
  'Key' is the Key used to encrypt your data in AES.
  'Key_size' is the size of 'Key' (2nd parameter) in bytes.
        For AES-128 bit encryption, 'Key_size' should be 16. For AES-192 bit encryption, 'Key_size' should be 24.
        For AES-128 bit encryption, 'Key_size' should be 32. For AES-512 bit encryption, 'Key_size' should be 64.
        There is no limit on how big you want your key be, the only limit is integer max value it can take.
  'ret' is returning variable, which will have encrypted data.
  
3) void AES_Decrypt(unsigned char* Encrypted_Data, unsigned char* Key, int Key_size, unsigned char** ret)
  'Encrypted_Data' variable will be your encrypted data that you want to decrypt.
  'Key' and 'Key_size' parameters are same as function 'AES_Encrypt'.
  'ret' is returning variable, which will have decrypted data.
  
"AES.h" Header file also contains two following variables:

1) unsigned char _2447_AES_sbox[256]
  All sbox values which is used in AES_Encrypt function in the header file.
  
1) unsigned char _2447_AES_isbox[256]
  All inverse sbox values which is used in AES_Decrypt function in the header file.
  
  
EXAMPLE:
```
#include<stdlib.h>
#include<stdio.h>
#include"AES.h"

int main(int argc, char *argv[])
{
	const char* data1 = "Hello How are u?", *key1 = "ffffffffffffffffffffffff";
	unsigned char *data, *key, *enc_data, *dec_data;
  
	//  copying clear data and key into variables (I don't know why I have to use this way, my IDE wasn't accepting otherwise)
	data = (unsigned char*)malloc(16 * sizeof(unsigned char));
	key = (unsigned char*)malloc(24 * sizeof(unsigned char)); //  Here I allocated only 24 bytes because I am use 192 bits (24 bytes) key for encryption
	for (int i = 0; i < 16; i++)
		data[i] = data1[i];
	for (int i = 0; i < 24; i++)
		key[i] = key1[i];

	//  Here, I used AES-192 bits key size, so I gave '24' in 3rd parameter because 24 bytes = 192 bits
	AES_Encrypt(data, key, 24, &enc_data);

	//  To see the encrypted data in HEX form
	for (int i = 0; i < 16; i++)
		printf("%x, ", enc_data[i]);
	printf("\n");

	// Decrypting the encrypted data
	AES_Decrypt(enc_data, key, 24, &dec_data);

	//  To see the decrypted data in clear text form
	for (int i = 0; i < 16; i++)
		printf("%c, ", dec_data[i]);

	t1 = getchar();
	return 0;
}
```
