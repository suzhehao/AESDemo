import org.apache.commons.codec.binary.Base64;

import javax.crypto.*;
import javax.crypto.spec.SecretKeySpec;

public class AESHelper {
    private static String code = "AES/ECB/PKCS5Padding";

    public static void main(String... arg) throws Exception {
        String s = aesEncrypt("suzhehao1993", "GeTjVDouCRkr7Hwl");
        s = aesDecrypt("Har+IIKWLdwHlZHgj+S/Wg==", "GeTjVDouCRkr7Hwl");
        System.out.println(s);
    }

    public static String aesEncrypt(String str, String key) throws Exception {
        if (str == null || key == null) return null;
        Cipher cipher = Cipher.getInstance(code);
        cipher.init(Cipher.ENCRYPT_MODE, new SecretKeySpec(key.getBytes("utf-8"), "AES"));
        byte[] bytes = cipher.doFinal(str.getBytes("utf-8"));
        return Base64.encodeBase64String(bytes);
    }

    public static String aesDecrypt(String str, String key) throws Exception {
        if (str == null || key == null) return null;
        Cipher cipher = Cipher.getInstance(code);
        cipher.init(Cipher.DECRYPT_MODE, new SecretKeySpec(key.getBytes("utf-8"), "AES"));
        byte[] bytes = Base64.decodeBase64(str);
        bytes = cipher.doFinal(bytes);
        return new String(bytes, "utf-8");
    }
}
