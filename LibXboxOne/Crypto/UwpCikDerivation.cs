using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;

namespace LibXboxOne
{
    public static class UwpCikDerivation
    {
        public static byte[] DeviceKey;
        public static bool DeviceKeyLoaded => DeviceKey != null;

        public static byte[] DecryptPackedKey(byte[] packedKey)
        {
            var engine = new AesWrapEngine();
            engine.Init(false, new KeyParameter(DeviceKey));
            return engine.Unwrap(packedKey, 0, packedKey.Length);
        }
    }
}