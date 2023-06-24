using System;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Ai.Vail
{
	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	[Serializable]
	public class StatDriver
	{
		// Token: 0x06000604 RID: 1540 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x2B315F0", Offset = "0x2B2FBF0", VA = "0x182B315F0")]
		private static ValueDropdownList<string> GetStatAndTraitChoices()
		{
			return null;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x2B31600", Offset = "0x2B2FC00", VA = "0x182B31600")]
		private void UpdateStatType()
		{
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00004B78 File Offset: 0x00002D78
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x2B316B0", Offset = "0x2B2FCB0", VA = "0x182B316B0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00004B90 File Offset: 0x00002D90
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
		public bool IsInverted()
		{
			return default(bool);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		public string GetStatId()
		{
			return null;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public StatDriver()
		{
		}

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _statId;

		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x40004DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Type _statType;

		// Token: 0x040004DB RID: 1243
		[Token(Token = "0x40004DB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_flip")]
		private bool _invert;
	}
}
