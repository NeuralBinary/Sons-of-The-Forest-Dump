using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Sons.Ai.Vail.Memory
{
	// Token: 0x02000213 RID: 531
	[Token(Token = "0x2000213")]
	[Serializable]
	public class StimuliInfluence
	{
		// Token: 0x06000F16 RID: 3862 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F16")]
		[Address(RVA = "0x2BB4F80", Offset = "0x2BB3580", VA = "0x182BB4F80")]
		private ValueDropdownList<string> GetStimuliTypes()
		{
			return null;
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F17")]
		[Address(RVA = "0x2BB4FD0", Offset = "0x2BB35D0", VA = "0x182BB4FD0")]
		internal void OnValidate()
		{
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F18")]
		[Address(RVA = "0x2BB50E0", Offset = "0x2BB36E0", VA = "0x182BB50E0")]
		public void AddTypeMemory(Dictionary<Type, StimuliInfluenceValues> typeMemory)
		{
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F19")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public StimuliInfluence()
		{
		}

		// Token: 0x0400092F RID: 2351
		[Token(Token = "0x400092F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _type;

		// Token: 0x04000930 RID: 2352
		[Token(Token = "0x4000930")]
		[FieldOffset(Offset = "0x18")]
		private Type _cachedType;

		// Token: 0x04000931 RID: 2353
		[Token(Token = "0x4000931")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StimuliInfluenceValues _values;
	}
}
