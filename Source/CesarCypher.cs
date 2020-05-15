using System;

namespace Codenation.Challenge
{
    public class CesarCypher : ICrypt, IDecrypt
    {
        public string Crypt(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                string result = "";
                message = message.ToLower();
                for (int i = 0; i < message.Length; i++)
                {
                    if ( Char.IsNumber(message[i]) || Char.IsWhiteSpace(message[i]))
                    {
                        result += message[i];

                    }
                    else if (message[i] >= 'a' && message[i] <= 'z')
                    {
                        int numbchar = Convert.ToInt16(((message[i] - 94) % 26) + 97);
                        result += Convert.ToChar(numbchar); 
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
            }
                return result;

            }
        }

        public string Decrypt(string cryptedMessage)
        {
            if (cryptedMessage == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                string result = "";
                cryptedMessage = cryptedMessage.ToLower();
                for (int i = 0; i < cryptedMessage.Length; i++)
                {
                    if (Char.IsNumber(cryptedMessage[i]) || Char.IsWhiteSpace(cryptedMessage[i]))
                    {
                        result += cryptedMessage[i];

                    }
                    else if (cryptedMessage[i] >= 'a' && cryptedMessage[i] <= 'z')
                    {
                        int numbchar = Convert.ToInt16(((cryptedMessage[i] - 74) % 26) + 97);
                        result += Convert.ToChar(numbchar);
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                return result;

            }
        }
    }
}
