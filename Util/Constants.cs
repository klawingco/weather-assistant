using System;
using System.Collections.Generic;
using System.Text;

namespace Weather_Assistant.Util
{
    // This could eventually moved into Resource file
    // But for the sake of simplicity, We'll add the values here directly
    public static class Constants
    {
        public static string WelcomeMessage = @"
/ / /\ \ \/ \   /_\  ___ ___(_)___| |_ __ _ _ __ | |_  
\ \/  \/ /  /  //_\\/ __/ __| / __| __/ _` | '_ \| __| 
 \  /\  /\_/  /  _  \__ \__ | \__ | || (_| | | | | |_  
  \/  \/\/___ \_/ \_|___|___|_|___/\__\__,_|_| |_|\__| 
__   __  / _ \      / |                                
\ \ / / | | | |     | |                                
 \ V /  | |_| |  _  | |                                
  \_/    \___/  (_) |_|                                                                                                 
 ";

        public static string MadeWithLove = "Made with <3 :  Marc 'KL' Lawingco";
        public static string AskZipCodeMessage = "Whats your Zip Code? : ";
        public static string ConfirmedZipCodeMessage = "Its {0}? Gee Thanks!. Now please wait for a bit.... ";
        public static string SelectQuestionMessage = "Please select your question. I'll do my best to answer it!.\n==================";
        public static string ZipCodeValid = "Location: {0}\nCountry: {1}\nRegion: {2}";
        public static string ZipCodeInvalid = "It seems that zip code is not valid US Code :(...";

    }
}
