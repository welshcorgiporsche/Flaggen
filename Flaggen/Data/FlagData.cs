using System;
using Xamarin.Forms;
namespace Data;


public class FlagData
{
    public static Flag[] flags = new Flag[94] //Array of all the Answers
    {
        new Flag { ImageSource = ImageSource.FromFile("Afghanistan.jpg"), CorrectAnswer = "Afghanistan" },
        new Flag { ImageSource = ImageSource.FromFile("Albanien.jpg"), CorrectAnswer = "Albanien" },
        new Flag { ImageSource = ImageSource.FromFile("Andorra.jpg"), CorrectAnswer = "Andorra" },
        new Flag { ImageSource = ImageSource.FromFile("Armenien.jpg"), CorrectAnswer = "Armenien" },
        new Flag { ImageSource = ImageSource.FromFile("Aserbaidschan.jpg"), CorrectAnswer = "Aserbaidschan" },
        new Flag { ImageSource = ImageSource.FromFile("Bahrain.jpg"), CorrectAnswer = "Bahrain" },
        new Flag { ImageSource = ImageSource.FromFile("Bangladesch.jpg"), CorrectAnswer = "Bangladesch" },
        new Flag { ImageSource = ImageSource.FromFile("Belarus.jpg"), CorrectAnswer = "Belarus" },
        new Flag { ImageSource = ImageSource.FromFile("Belgien.jpg"), CorrectAnswer = "Belgien" },
        new Flag { ImageSource = ImageSource.FromFile("Bhutan.jpg"), CorrectAnswer = "Bhutan" },
        new Flag { ImageSource = ImageSource.FromFile("Bosnien_Herzegowina.jpg"), CorrectAnswer = "Bosnien und Herzegowina" },
        new Flag { ImageSource = ImageSource.FromFile("Brunei.jpg"), CorrectAnswer = "Brunei" },
        new Flag { ImageSource = ImageSource.FromFile("Bulgarien.jpg"), CorrectAnswer = "Bulgarien" },
        new Flag { ImageSource = ImageSource.FromFile("VK_China.jpg"), CorrectAnswer = "China" },
        new Flag { ImageSource = ImageSource.FromFile("Daenemark.jpg"), CorrectAnswer = "Dänemark" },
        new Flag { ImageSource = ImageSource.FromFile("Deutschland.jpg"), CorrectAnswer = "Deutschland" },
        new Flag { ImageSource = ImageSource.FromFile("Estland.jpg"), CorrectAnswer = "Estland" },
        new Flag { ImageSource = ImageSource.FromFile("Falkland_Islands.jpg"), CorrectAnswer = "Falklands" },
        new Flag { ImageSource = ImageSource.FromFile("Finnland.jpg"), CorrectAnswer = "Finnland" },
        new Flag { ImageSource = ImageSource.FromFile("Frankreich.jpg"), CorrectAnswer = "Frankreich" },
        new Flag { ImageSource = ImageSource.FromFile("Georgien.jpg"), CorrectAnswer = "Georgien" },
        new Flag { ImageSource = ImageSource.FromFile("Griechenland.jpg"), CorrectAnswer = "Griechenland" },
        new Flag { ImageSource = ImageSource.FromFile("Indien.jpg"), CorrectAnswer = "Indien" },
        new Flag { ImageSource = ImageSource.FromFile("Indonesien.jpg"), CorrectAnswer = "Indonesien" },
        new Flag { ImageSource = ImageSource.FromFile("Irak.jpg"), CorrectAnswer = "Irak" },
        new Flag { ImageSource = ImageSource.FromFile("Iran.jpg"), CorrectAnswer = "Iran" },
        new Flag { ImageSource = ImageSource.FromFile("Irland.jpg"), CorrectAnswer = "Irland" },
        new Flag { ImageSource = ImageSource.FromFile("Island.jpg"), CorrectAnswer = "Island" },
        new Flag { ImageSource = ImageSource.FromFile("Isle_of_Man.jpg"), CorrectAnswer = "Isle of Man" },
        new Flag { ImageSource = ImageSource.FromFile("Israel.jpg"), CorrectAnswer = "Israel" },
        new Flag { ImageSource = ImageSource.FromFile("Italien.jpg"), CorrectAnswer = "Italien" },
        new Flag { ImageSource = ImageSource.FromFile("Japan.jpg"), CorrectAnswer = "Japan" },
        new Flag { ImageSource = ImageSource.FromFile("Jemen.jpg"), CorrectAnswer ="Jemen" },
        new Flag { ImageSource = ImageSource.FromFile("Jordanien.jpg"), CorrectAnswer = "Jordanien" },
        new Flag { ImageSource = ImageSource.FromFile("Kambodscha.jpg"), CorrectAnswer = "Kambodscha" },
        new Flag { ImageSource = ImageSource.FromFile("Kroatien.jpg"), CorrectAnswer = "Kroatien" },
        new Flag { ImageSource = ImageSource.FromFile("Kosovo.jpg"), CorrectAnswer = "Kosovo" },
        new Flag { ImageSource = ImageSource.FromFile("Kasachstan.jpg"), CorrectAnswer = "Kasachstan" },
        new Flag { ImageSource = ImageSource.FromFile("Katar.jpg"), CorrectAnswer = "Katar" },
        new Flag { ImageSource = ImageSource.FromFile("Kirgisistan.jpg"), CorrectAnswer = "Kirgisistan" },
        new Flag { ImageSource = ImageSource.FromFile("Kuwait.jpg"), CorrectAnswer = "Kuwait" },
        new Flag { ImageSource = ImageSource.FromFile("Laos.jpg"), CorrectAnswer = "Laos" },
        new Flag { ImageSource = ImageSource.FromFile("Lettland.jpg"), CorrectAnswer = "Lettland" },
        new Flag { ImageSource = ImageSource.FromFile("Libanon.jpg"), CorrectAnswer = "Libanon" },
        new Flag { ImageSource = ImageSource.FromFile("Liechtenstein.jpg"), CorrectAnswer = "Liechtenstein" },
        new Flag { ImageSource = ImageSource.FromFile("Litauen.jpg"), CorrectAnswer = "Litauen" },
        new Flag { ImageSource = ImageSource.FromFile("Luxemburg.jpg"), CorrectAnswer = "Luxemburg" },
        new Flag { ImageSource = ImageSource.FromFile("Malaysia.jpg"), CorrectAnswer = "Malaysia" },
        new Flag { ImageSource = ImageSource.FromFile("Malta.jpg"), CorrectAnswer = "Malta" },
        new Flag { ImageSource = ImageSource.FromFile("Moldau.jpg"), CorrectAnswer = "Moldau" },
        new Flag { ImageSource = ImageSource.FromFile("Monaco.jpg"), CorrectAnswer = "Monaco" },
        new Flag { ImageSource = ImageSource.FromFile("Mongolei.jpg"), CorrectAnswer = "Mongolei" },
        new Flag { ImageSource = ImageSource.FromFile("Montenegro.jpg"), CorrectAnswer = "Montenegro" },
        new Flag { ImageSource = ImageSource.FromFile("Myanmar.jpg"), CorrectAnswer = "Myanmar" },
        new Flag { ImageSource = ImageSource.FromFile("Nepal.jpg"), CorrectAnswer = "Nepal" },
        new Flag { ImageSource = ImageSource.FromFile("Niederlande.jpg"), CorrectAnswer = "Niederlande" },
        new Flag { ImageSource = ImageSource.FromFile("Nordkorea.jpg"), CorrectAnswer = "Nordkorea" },
        new Flag { ImageSource = ImageSource.FromFile("Nordmazedonien.jpg"), CorrectAnswer = "Nordmazedonien" },
        new Flag { ImageSource = ImageSource.FromFile("Norwegen.jpg"), CorrectAnswer = "Norwegen" },
        new Flag { ImageSource = ImageSource.FromFile("Oman.jpg"), CorrectAnswer = "Oman" },
        new Flag { ImageSource = ImageSource.FromFile("Ost_Timor.jpg"), CorrectAnswer = "Ost-Timor" },
        new Flag { ImageSource = ImageSource.FromFile("Oesterreich.jpg"), CorrectAnswer = "Österreich" },
        new Flag { ImageSource = ImageSource.FromFile("Pakistan.jpg"), CorrectAnswer = "Pakistan" },
        new Flag { ImageSource = ImageSource.FromFile("Philippinen.jpg"), CorrectAnswer = "Philippinen" },
        new Flag { ImageSource = ImageSource.FromFile("Polen.jpg"), CorrectAnswer = "Polen" },
        new Flag { ImageSource = ImageSource.FromFile("Portugal.jpg"), CorrectAnswer = "Portugal" },
        new Flag { ImageSource = ImageSource.FromFile("Rumaenien.jpg"), CorrectAnswer = "Rumänien" },
        new Flag { ImageSource = ImageSource.FromFile("Russland.jpg"), CorrectAnswer = "Russland" },
        new Flag { ImageSource = ImageSource.FromFile("San_Marino.jpg"), CorrectAnswer = "San Marino" },
        new Flag { ImageSource = ImageSource.FromFile("Saudi_Arabien.jpg"), CorrectAnswer = "Saudi-Arabien" },
        new Flag { ImageSource = ImageSource.FromFile("Schweden.jpg"), CorrectAnswer = "Schweden" },
        new Flag { ImageSource = ImageSource.FromFile("Schweiz.jpg"), CorrectAnswer = "Schweiz" },
        new Flag { ImageSource = ImageSource.FromFile("Serbien.jpg"), CorrectAnswer = "Serbien" },
        new Flag { ImageSource = ImageSource.FromFile("Singapur.jpg"), CorrectAnswer = "Singapur" },
        new Flag { ImageSource = ImageSource.FromFile("Slowakei.jpg"), CorrectAnswer = "Slowakei" },
        new Flag { ImageSource = ImageSource.FromFile("Slowenien.jpg"), CorrectAnswer = "Slowenien" },
        new Flag { ImageSource = ImageSource.FromFile("Spanien.jpg"), CorrectAnswer = "Spanien" },
        new Flag { ImageSource = ImageSource.FromFile("Sri_Lanka.jpg"), CorrectAnswer = "Sri Lanka" },
        new Flag { ImageSource = ImageSource.FromFile("Suedkorea.jpg"), CorrectAnswer = "Südkorea" },
        new Flag { ImageSource = ImageSource.FromFile("Syrien.jpg"), CorrectAnswer = "Syrien" },
        new Flag { ImageSource = ImageSource.FromFile("Tadschikistan.jpg"), CorrectAnswer = "Tadschikistan" },
        new Flag { ImageSource = ImageSource.FromFile("Taiwan.jpg"), CorrectAnswer = "Taiwan" },
        new Flag { ImageSource = ImageSource.FromFile("Thailand.jpg"), CorrectAnswer = "Thailand" },
        new Flag { ImageSource = ImageSource.FromFile("Tschechien.jpg"), CorrectAnswer = "Tschechien" },
        new Flag { ImageSource = ImageSource.FromFile("Tuerkei.jpg"), CorrectAnswer = "Türkei" },
        new Flag { ImageSource = ImageSource.FromFile("Turkmenistan.jpg"), CorrectAnswer = "Turkmenistan" },
        new Flag { ImageSource = ImageSource.FromFile("UAE.jpg"), CorrectAnswer = "UAE" },
        new Flag { ImageSource = ImageSource.FromFile("UK.jpg"), CorrectAnswer = "Vereinigtes Königreich" },
        new Flag { ImageSource = ImageSource.FromFile("Ukraine.jpg"), CorrectAnswer = "Ukraine" },
        new Flag { ImageSource = ImageSource.FromFile("Ungarn.jpg"), CorrectAnswer = "Ungarn" },
        new Flag { ImageSource = ImageSource.FromFile("Usbekistan.jpg"), CorrectAnswer = "Usbekistan" },
        new Flag { ImageSource = ImageSource.FromFile("Vatikanstadt.jpg"), CorrectAnswer = "Vatikanstadt" },
        new Flag { ImageSource = ImageSource.FromFile("Vietnam.jpg"), CorrectAnswer = "Vietnam" },
        new Flag { ImageSource = ImageSource.FromFile("Zypern.jpg"), CorrectAnswer = "Zypern" }

        // 94 Flags of Asia, Europe, The Falkland Islands and the Isle of Man


    };



    public Flag GetRandomFlag(Flag[] flags)
    {
        Random random = new Random();
        int index = random.Next(0, flags.Length);
        return flags[index];
    }




}
