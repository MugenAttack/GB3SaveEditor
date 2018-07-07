using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB3SaveEditor
{
    public class Part
    {
        public byte[] data;
        public string name = "";
        const int ID_Address = 0x0;
        const int WeaponDPS_Address = 0x4;
        const int Slot_Address = 0x6;
        const int Label_Address = 0xA;
        const int Level_Address = 0xC;
        const int Rarity_Address = 0xD;
        const int Abilities_Address = 0x18;
        const int AbilityValues_Address = 0x2C;

        public Part(byte[] pData)
        {
            if (pData.Length == 84)
                data = pData;
        }

        public int ID
        {
            get
            {
                return BitConverter.ToInt32(data, ID_Address);
            }

            set
            {
                byte[] c = BitConverter.GetBytes(value);
                for (int i = 0; i < 4; i++)
                    data[ID_Address + i] = c[i];
            }
        }

        public short WeaponDPS
        {
            get
            {
                return BitConverter.ToInt16(data, WeaponDPS_Address);
            }

            set
            {
                byte[] c = BitConverter.GetBytes(value);
                for (int i = 0; i < 2; i++)
                    data[WeaponDPS_Address + i] = c[i];
            }
        }

        public short Slot
        {
            get
            {
                return BitConverter.ToInt16(data, Slot_Address);
            }

            set
            {
                byte[] c = BitConverter.GetBytes(value);
                for (int i = 0; i < 2; i++)
                    data[Slot_Address + i] = c[i];
            }
        }

        public byte Label
        {
            get
            {
                return data[Label_Address];
            }

            set
            {
                data[Label_Address] = value;
            }
        }

        public byte Level
        {
            get
            {
                return data[Level_Address];
            }

            set
            {
                data[Level_Address] = value;
            }
        }

        public byte Rarity
        {
            get
            {
                return data[Rarity_Address];
            }

            set
            {
                data[Rarity_Address] = value;
            }
        }

        public short getAbility(int index)
        {
            return BitConverter.ToInt16(data, Abilities_Address + (index * 2));
        }

        public void setAbility(int index, short value)
        {
            byte[] c = BitConverter.GetBytes(value);
            for (int i = 0; i < 2; i++)
                data[Abilities_Address + (index * 2) + i] = c[i];
        }

        public float getAbilityValue(int index)
        {
            return BitConverter.ToSingle(data,AbilityValues_Address + (index * 4));
            
        }

        public void setAbilityValue(int index, float value)
        {
            byte[] c = BitConverter.GetBytes(value);
            for (int i = 0; i < 4; i++)
                data[AbilityValues_Address + (index * 4) + i] = c[i];
        }
    }

    
}
