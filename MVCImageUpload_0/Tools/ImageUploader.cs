using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MVCImageUpload_0.Tools
{
    public static class ImageUploader
    {
        //HttpPostedFileBase => MVC'de eger Post yönteminde bir dosya geliyorsa bu dosya, HttpPostedFileBase tipinde tutulur...


        public static string UploadImage(string serverPath, HttpPostedFileBase file)
        {
            if (file != null)
            {
                Guid uniqueName = Guid.NewGuid(); //bu Metot size Bilgisayarınızın mac adresini, ip adresini, timezone'ununu ve oturumda bulunan kullanıcı adresini alıp harmanlayarak işletim sisteminize göre 36 karakterlik veya 38 karakterlik bir şifre döndürür...


                string[] fileArray = file.FileName.Split('.'); //burada split metodu sayesinde ilgili yapının uzantısının da iceride bulundugu bir string dizisi almıs olduk...SPlit metodu belirttiginiz char karakterinden metni bölerek size bir array sunar...

                string extension = fileArray[fileArray.Length - 1].ToLower(); //dosya uzantısını yakalayarak kücük harflere cevirdik...

                string fileName = $"{uniqueName}.{extension}"; // normal şartlarda biz burada GUid kullandıgımız icin asla bir dosya ismi aynı olmayacaktır...Lakin siz Guid kullanmazsanız (kullanıcıya yüklemek istedigi dosyanın ismini sorup onu back end'e atabilirsiniz)..Böyle bir durumda burada aynı zamanda bir baska kontrol mekanizması acılarak veritabanında imagePath'lerde o isim var mı diye sorgulayıp sadece yoksa devam etmelisiniz...Bunu öncelikle extension'i kontrol edip sonra yapmalısınız...

                if (extension=="jpg"||extension=="gif"||extension=="jpeg")
                {
                    if (File.Exists(HttpContext.Current.Server.MapPath(serverPath+fileName)))
                    {
                        return "1"; //Ancak GUid kullandıgımız icin bu acıdan zaten güvendeyiz(Dosya var kodu)
                    }
                    string filePath = HttpContext.Current.Server.MapPath(serverPath + fileName);
                    file.SaveAs(filePath);
                    return serverPath + filePath;

                }
                return "2"; //Secilen dosya bir resim degildir...





            }

            return "3";//dosya bos kodu
        }
    }
}



//13asdasd___??=01123123

//brrrraaaa__-111111111