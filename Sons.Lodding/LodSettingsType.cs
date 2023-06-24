using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Sons.Lodding
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[Serializable]
	public class LodSettingsType : ISerializationCallbackReceiver
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x30C4190", Offset = "0x30C2790", VA = "0x1830C4190")]
		public static ValueDropdownList<LodSettingsType> ValueDropdownValues()
		{
			return null;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x17000016")]
		public int StippleIndex
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x17000017")]
		public bool EnableStipple
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x30C4470", Offset = "0x30C2A70", VA = "0x1830C4470")]
		public bool Equals(LodSettingsType other)
		{
			return default(bool);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x30C44E0", Offset = "0x30C2AE0", VA = "0x1830C44E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x30C4590", Offset = "0x30C2B90", VA = "0x1830C4590")]
		private LodSettingsType()
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x30C4600", Offset = "0x30C2C00", VA = "0x1830C4600")]
		private LodSettingsType(string name, int enumId, bool enableStipple, int stippleIndex)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x30C46B0", Offset = "0x30C2CB0", VA = "0x1830C46B0")]
		public static bool operator ==(LodSettingsType a, LodSettingsType b)
		{
			return default(bool);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x30C46D0", Offset = "0x30C2CD0", VA = "0x1830C46D0")]
		public static bool operator !=(LodSettingsType a, LodSettingsType b)
		{
			return default(bool);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x30C4760", Offset = "0x30C2D60", VA = "0x1830C4760")]
		public static implicit operator LodSettingsType(string value)
		{
			return null;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x30C4920", Offset = "0x30C2F20", VA = "0x1830C4920")]
		public static explicit operator LodSettingsType(int value)
		{
			return null;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x30C4AC0", Offset = "0x30C30C0", VA = "0x1830C4AC0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x30C4AD0", Offset = "0x30C30D0", VA = "0x1830C4AD0")]
		private void RefreshProperties()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x30C4CD0", Offset = "0x30C32D0", VA = "0x1830C4CD0")]
		private void ApplyFrom(LodSettingsType eachItem)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x30C4D40", Offset = "0x30C3340", VA = "0x1830C4D40")]
		public static LodSettingsType GetFromStippleIndex(int index)
		{
			return null;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x30C4EB0", Offset = "0x30C34B0", VA = "0x1830C4EB0")]
		public static LodSettingsType GetFromName(string lodType)
		{
			return null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
		public LodSettingsTypeEnum GetId()
		{
			return LodSettingsTypeEnum.Trees;
		}

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LodSettingsType Trees;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x8")]
		public static readonly LodSettingsType SmallTree;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x10")]
		public static readonly LodSettingsType Bush;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x18")]
		public static readonly LodSettingsType SmallBush;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x20")]
		public static readonly LodSettingsType Rocks;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x28")]
		public static readonly LodSettingsType SmallRocks;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x30")]
		public static readonly LodSettingsType Plant;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x38")]
		public static readonly LodSettingsType Moss;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x40")]
		public static readonly LodSettingsType PickUps;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x48")]
		public static readonly LodSettingsType BuiltStructure;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x50")]
		public static readonly LodSettingsType CaveEntrance;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x58")]
		public static readonly LodSettingsType MediumCave;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x60")]
		public static readonly LodSettingsType SmallCave;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x68")]
		public static readonly LodSettingsType Cliffs;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x70")]
		private static readonly List<LodSettingsType> AllSettings;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x10")]
		private int _id;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x14")]
		private int _stippleIndex;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x18")]
		private bool _enableStipple;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private string _name;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x28")]
		private int _hash;
	}
}
