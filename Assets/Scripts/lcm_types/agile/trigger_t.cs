/* LCM type definition class file
 * This file was automatically generated by lcm-gen
 * DO NOT MODIFY BY HAND!!!!
 */

using System;
using System.Collections.Generic;
using System.IO;
using LCM.LCM;
 
namespace agile
{
    public sealed class trigger_t : LCM.LCM.LCMEncodable
    {
        public long utime;
 
        public trigger_t()
        {
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0xa686a0e0f882d897L;
 
        static trigger_t()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("agile.trigger_t"))
                return 0L;
 
            classes.Add("agile.trigger_t");
            ulong hash = LCM_FINGERPRINT_BASE
                ;
            classes.RemoveAt(classes.Count - 1);
            return (hash<<1) + ((hash>>63)&1);
        }
 
        public void Encode(LCMDataOutputStream outs)
        {
            outs.Write((long) LCM_FINGERPRINT);
            _encodeRecursive(outs);
        }
 
        public void _encodeRecursive(LCMDataOutputStream outs)
        {
            outs.Write(this.utime); 
 
        }
 
        public trigger_t(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public trigger_t(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static agile.trigger_t _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            agile.trigger_t o = new agile.trigger_t();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            this.utime = ins.ReadInt64();
 
        }
 
        public agile.trigger_t Copy()
        {
            agile.trigger_t outobj = new agile.trigger_t();
            outobj.utime = this.utime;
 
            return outobj;
        }
    }
}
