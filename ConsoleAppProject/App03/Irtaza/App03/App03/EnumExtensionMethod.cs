using System.ComponentModel;
namespace App03;

public static class EnumExtensionMethod  
{  
    public static string GetEnumDescription(this Enum enumValue)  
    {  
        var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());  
  
        var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);  
  
        return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();  
    }  
}  