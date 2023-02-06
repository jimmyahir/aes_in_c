public class AES
    {
        byte[] _2447_AES_sbox = new byte[256]
        {
           0x63, 0x7C, 0x77, 0x7B, 0xF2, 0x6B, 0x6F, 0xC5, 0x30, 0x01, 0x67, 0x2B, 0xFE, 0xD7, 0xAB, 0x76,
           0xCA, 0x82, 0xC9, 0x7D, 0xFA, 0x59, 0x47, 0xF0, 0xAD, 0xD4, 0xA2, 0xAF, 0x9C, 0xA4, 0x72, 0xC0,
           0xB7, 0xFD, 0x93, 0x26, 0x36, 0x3F, 0xF7, 0xCC, 0x34, 0xA5, 0xE5, 0xF1, 0x71, 0xD8, 0x31, 0x15,
           0x04, 0xC7, 0x23, 0xC3, 0x18, 0x96, 0x05, 0x9A, 0x07, 0x12, 0x80, 0xE2, 0xEB, 0x27, 0xB2, 0x75,
           0x09, 0x83, 0x2C, 0x1A, 0x1B, 0x6E, 0x5A, 0xA0, 0x52, 0x3B, 0xD6, 0xB3, 0x29, 0xE3, 0x2F, 0x84,
           0x53, 0xD1, 0x00, 0xED, 0x20, 0xFC, 0xB1, 0x5B, 0x6A, 0xCB, 0xBE, 0x39, 0x4A, 0x4C, 0x58, 0xCF,
           0xD0, 0xEF, 0xAA, 0xFB, 0x43, 0x4D, 0x33, 0x85, 0x45, 0xF9, 0x02, 0x7F, 0x50, 0x3C, 0x9F, 0xA8,
           0x51, 0xA3, 0x40, 0x8F, 0x92, 0x9D, 0x38, 0xF5, 0xBC, 0xB6, 0xDA, 0x21, 0x10, 0xFF, 0xF3, 0xD2,
           0xCD, 0x0C, 0x13, 0xEC, 0x5F, 0x97, 0x44, 0x17, 0xC4, 0xA7, 0x7E, 0x3D, 0x64, 0x5D, 0x19, 0x73,
           0x60, 0x81, 0x4F, 0xDC, 0x22, 0x2A, 0x90, 0x88, 0x46, 0xEE, 0xB8, 0x14, 0xDE, 0x5E, 0x0B, 0xDB,
           0xE0, 0x32, 0x3A, 0x0A, 0x49, 0x06, 0x24, 0x5C, 0xC2, 0xD3, 0xAC, 0x62, 0x91, 0x95, 0xE4, 0x79,
           0xE7, 0xC8, 0x37, 0x6D, 0x8D, 0xD5, 0x4E, 0xA9, 0x6C, 0x56, 0xF4, 0xEA, 0x65, 0x7A, 0xAE, 0x08,
           0xBA, 0x78, 0x25, 0x2E, 0x1C, 0xA6, 0xB4, 0xC6, 0xE8, 0xDD, 0x74, 0x1F, 0x4B, 0xBD, 0x8B, 0x8A,
           0x70, 0x3E, 0xB5, 0x66, 0x48, 0x03, 0xF6, 0x0E, 0x61, 0x35, 0x57, 0xB9, 0x86, 0xC1, 0x1D, 0x9E,
           0xE1, 0xF8, 0x98, 0x11, 0x69, 0xD9, 0x8E, 0x94, 0x9B, 0x1E, 0x87, 0xE9, 0xCE, 0x55, 0x28, 0xDF,
           0x8C, 0xA1, 0x89, 0x0D, 0xBF, 0xE6, 0x42, 0x68, 0x41, 0x99, 0x2D, 0x0F, 0xB0, 0x54, 0xBB, 0x16
        };
        byte[] _2447_AES_isbox = new byte[256]
        {
            0x52, 0x09, 0x6A, 0xD5, 0x30, 0x36, 0xA5, 0x38, 0xBF, 0x40, 0xA3, 0x9E, 0x81, 0xF3, 0xD7, 0xFB,
            0x7C, 0xE3, 0x39, 0x82, 0x9B, 0x2F, 0xFF, 0x87, 0x34, 0x8E, 0x43, 0x44, 0xC4, 0xDE, 0xE9, 0xCB,
            0x54, 0x7B, 0x94, 0x32, 0xA6, 0xC2, 0x23, 0x3D, 0xEE, 0x4C, 0x95, 0x0B, 0x42, 0xFA, 0xC3, 0x4E,
            0x08, 0x2E, 0xA1, 0x66, 0x28, 0xD9, 0x24, 0xB2, 0x76, 0x5B, 0xA2, 0x49, 0x6D, 0x8B, 0xD1, 0x25,
            0x72, 0xF8, 0xF6, 0x64, 0x86, 0x68, 0x98, 0x16, 0xD4, 0xA4, 0x5C, 0xCC, 0x5D, 0x65, 0xB6, 0x92,
            0x6C, 0x70, 0x48, 0x50, 0xFD, 0xED, 0xB9, 0xDA, 0x5E, 0x15, 0x46, 0x57, 0xA7, 0x8D, 0x9D, 0x84,
            0x90, 0xD8, 0xAB, 0x00, 0x8C, 0xBC, 0xD3, 0x0A, 0xF7, 0xE4, 0x58, 0x05, 0xB8, 0xB3, 0x45, 0x06,
            0xD0, 0x2C, 0x1E, 0x8F, 0xCA, 0x3F, 0x0F, 0x02, 0xC1, 0xAF, 0xBD, 0x03, 0x01, 0x13, 0x8A, 0x6B,
            0x3A, 0x91, 0x11, 0x41, 0x4F, 0x67, 0xDC, 0xEA, 0x97, 0xF2, 0xCF, 0xCE, 0xF0, 0xB4, 0xE6, 0x73,
            0x96, 0xAC, 0x74, 0x22, 0xE7, 0xAD, 0x35, 0x85, 0xE2, 0xF9, 0x37, 0xE8, 0x1C, 0x75, 0xDF, 0x6E,
            0x47, 0xF1, 0x1A, 0x71, 0x1D, 0x29, 0xC5, 0x89, 0x6F, 0xB7, 0x62, 0x0E, 0xAA, 0x18, 0xBE, 0x1B,
            0xFC, 0x56, 0x3E, 0x4B, 0xC6, 0xD2, 0x79, 0x20, 0x9A, 0xDB, 0xC0, 0xFE, 0x78, 0xCD, 0x5A, 0xF4,
            0x1F, 0xDD, 0xA8, 0x33, 0x88, 0x07, 0xC7, 0x31, 0xB1, 0x12, 0x10, 0x59, 0x27, 0x80, 0xEC, 0x5F,
            0x60, 0x51, 0x7F, 0xA9, 0x19, 0xB5, 0x4A, 0x0D, 0x2D, 0xE5, 0x7A, 0x9F, 0x93, 0xC9, 0x9C, 0xEF,
            0xA0, 0xE0, 0x3B, 0x4D, 0xAE, 0x2A, 0xF5, 0xB0, 0xC8, 0xEB, 0xBB, 0x3C, 0x83, 0x53, 0x99, 0x61,
            0x17, 0x2B, 0x04, 0x7E, 0xBA, 0x77, 0xD6, 0x26, 0xE1, 0x69, 0x14, 0x63, 0x55, 0x21, 0x0C, 0x7D
        };

        byte _2447_AES_colmul(int a, int b)
        {
            int x = b, z, t1 = 1;
            z = (a & t1) * x;
            for (byte i = 1; i <= 4; i++)
            {
                x = b;
                for (byte i2 = 1; i2 <= i; i2++)
                {
                    x = (x << 1) ^ (((x >> 7) & 1) * 0x1b);
                }
                z = z ^ (((a >> i) & 1) * x);
            }
            return (byte)z;
        }

        public byte[] AES_Encrypt(byte[] Data, byte[] Key)
        {
            int i, tsize = 160 + Key.Length + ((Key.Length - 16) * (3)), ri = 1, rounds, j, tmp;
            int[] rconst, round_keys, tmpk = new int[4], temporary = new int[16], ret = new int[16];
            byte[] emul = new byte[16] { 0x02, 0x01, 0x01, 0x03, 0x03, 0x02, 0x01, 0x01, 0x01, 0x03, 0x02, 0x01, 0x01, 0x01, 0x03, 0x02 };
            byte[] ret2 = new byte[16];

            //	Calculating all round constants needed
            rounds = ((Key.Length / 4) + 6);
            rconst = new int[rounds];
            rconst[0] = 1;
            for (i = 1; i < rounds; i++)
            {
                rconst[i] = rconst[i - 1];
                if ((rconst[i] & 0x80) == 0x80)
                {
                    rconst[i] <<= 1;
                    rconst[i] ^= 0x1b;
                }
                else
                    rconst[i] <<= 1;
            }

            //	KEY EXPANSION
            round_keys = new int[tsize];
            for (i = 0; i < Key.Length; i++)
                round_keys[i] = Key[i];
            while (i < tsize)
            {
                for (j = 0; j < 4; j++)
                    tmpk[j] = round_keys[j + i - 4];
                if ((i % Key.Length) == 0)
                {
                    j = tmpk[0]; tmpk[0] = tmpk[1]; tmpk[1] = tmpk[2]; tmpk[2] = tmpk[3]; tmpk[3] = j;
                    for (j = 0; j < 4; j++)
                        tmpk[j] = _2447_AES_sbox[tmpk[j]];
                    tmpk[0] = tmpk[0] ^ rconst[ri - 1];
                    ri++;
                }
                if (((i % Key.Length) == 16) && (Key.Length >= 32))
                {
                    for (j = 0; j < 4; j++)
                        tmpk[j] = _2447_AES_sbox[tmpk[j]];
                }
                for (j = 0; j < 4; j++)
                {
                    round_keys[i] = round_keys[i - Key.Length] ^ tmpk[j];
                    i++;
                }
            }

            //round 0 -- XOR with Current Round Key
            for (j = 0; j < 16; j++)
                ret[j] = (Data[j] ^ round_keys[j]);

            ri = 16;
            for (i = 1; i <= rounds; i++)
            {
                // -- SBOX
                for (j = 0; j < 16; j++)
                    ret[j] = _2447_AES_sbox[ret[j]];

                // --  SHIFT_ROW
                tmp = ret[1]; ret[1] = ret[5]; ret[5] = ret[9]; ret[9] = ret[13]; ret[13] = tmp;
                tmp = ret[2]; ret[2] = ret[10]; ret[10] = tmp; tmp = ret[6]; ret[6] = ret[14]; ret[14] = tmp;
                tmp = ret[3]; ret[3] = ret[15]; ret[15] = ret[11]; ret[11] = ret[7]; ret[7] = tmp;

                if (i != rounds)
                {
                    // -- MIX
                    for (j = 0; j < 4; j++)
                        for (tmp = 0; tmp < 16; tmp = tmp + 4)
                            temporary[j + tmp] = ((_2447_AES_colmul(emul[j], ret[tmp])) ^ (_2447_AES_colmul(emul[j + 4], ret[tmp + 1])) ^ (_2447_AES_colmul(emul[j + 8], ret[tmp + 2])) ^ (_2447_AES_colmul(emul[j + 12], ret[tmp + 3])));

                    // -- copying temp values back to state ret
                    for (j = 0; j < 16; j++)
                        ret[j] = temporary[j];
                }
                // -- XOR with the Round key
                for (j = 0; j < 16; j++, ri++)
                    ret[j] = ret[j] ^ round_keys[ri];
            }
            for (j = 0; j < 16; j++)
                ret2[j] = (byte)ret[j];
            return ret2;
        }

        public byte[] AES_Decrypt(byte[] Encrypted_Data, byte[] Key)
        {
            int i, tsize = 160 + Key.Length + ((Key.Length - 16) * (3)), ri = 1, rounds, tmp, j;
            int[] ret = new int[16], rconst, tmpk = new int[4], temporary = new int[16], round_keys;
            byte[] ret2 = new byte[16], dmul = new byte[16] { 0x0E, 0x09, 0x0D, 0x0B, 0x0B, 0x0E, 0x09, 0x0D, 0x0D, 0x0B, 0x0E, 0x09, 0x09, 0x0D, 0x0B, 0x0E };
            
            //	Calculating all round constants needed
            rounds = ((Key.Length / 4) + 6);
            rconst = new int[rounds];
            rconst[0] = 1;
            for (i = 1; i < rounds; i++)
            {
                rconst[i] = rconst[i - 1];
                if ((rconst[i] & 0x80) == 0x80)
                {
                    rconst[i] <<= 1;
                    rconst[i] ^= 0x1b;
                }
                else
                    rconst[i] <<= 1;
            }

            //	KEY EXPANSION
            round_keys = new int[tsize];
            for (i = 0; i < Key.Length; i++)
                round_keys[i] = Key[i];
            while (i < tsize)
            {
                for (j = 0; j < 4; j++)
                    tmpk[j] = round_keys[j + i - 4];
                if ((i % Key.Length) == 0)
                {
                    j = tmpk[0]; tmpk[0] = tmpk[1]; tmpk[1] = tmpk[2]; tmpk[2] = tmpk[3]; tmpk[3] = j;
                    for (j = 0; j < 4; j++)
                        tmpk[j] = _2447_AES_sbox[tmpk[j]];
                    tmpk[0] = tmpk[0] ^ rconst[ri - 1];
                    ri++;
                }
                if (((i % Key.Length) == 16) && (Key.Length >= 32))
                {
                    for (j = 0; j < 4; j++)
                        tmpk[j] = _2447_AES_sbox[tmpk[j]];
                }
                for (j = 0; j < 4; j++)
                {
                    round_keys[i] = round_keys[i - Key.Length] ^ tmpk[j];
                    i++;
                }
            }
            //	copying encrypted data
            for (j = 0; j < 16; j++)
                ret[j] = Encrypted_Data[j];

            ri = tsize - 16;
            for (i = rounds; i >= 1; i--)
            {
                //rounde 10 -- XOR with Round key
                for (j = 0; j < 16; j++)
                    ret[j] = (ret[j] ^ round_keys[ri + j]);
                ri = ri - 16;

                if (i != rounds)
                {
                    //round 9...1 -- MIX
                    for (j = 0; j < 4; j++)
                        for (tmp = 0; tmp < 16; tmp = tmp + 4)
                            temporary[j + tmp] = ((_2447_AES_colmul(dmul[j], ret[tmp])) ^ (_2447_AES_colmul(dmul[j + 4], ret[tmp + 1])) ^ (_2447_AES_colmul(dmul[j + 8], ret[tmp + 2])) ^ (_2447_AES_colmul(dmul[j + 12], ret[tmp + 3])));

                    //copying temp back to state ret
                    for (j = 0; j < 16; j++)
                        ret[j] = temporary[j];
                }

                //round 10 --  SHIFT_ROW
                tmp = ret[5]; ret[5] = ret[1]; ret[1] = ret[13]; ret[13] = ret[9]; ret[9] = tmp;
                tmp = ret[2]; ret[2] = ret[10]; ret[10] = tmp; tmp = ret[6]; ret[6] = ret[14]; ret[14] = tmp;
                tmp = ret[3]; ret[3] = ret[7]; ret[7] = ret[11]; ret[11] = ret[15]; ret[15] = tmp;

                //round 10 -- SBOX
                for (j = 0; j < 16; j++)
                    ret[j] = _2447_AES_isbox[ret[j]];
            }

            //round 0 -- XOR ONLY with Original key
            for (j = 0; j < 16; j++)
                ret[j] = ret[j] ^ round_keys[j];

            for (j = 0; j < 16; j++)
                ret2[j] = (byte)ret[j];
            return ret2;
        }
    }
