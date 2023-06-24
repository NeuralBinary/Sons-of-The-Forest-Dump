using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Sons.Ai.Vail.Memory
{
	// Token: 0x02000214 RID: 532
	[Token(Token = "0x2000214")]
	[CreateAssetMenu(menuName = "Sons/Ai/Memory Defaults", fileName = "MemoryDefaults", order = 0)]
	[Serializable]
	public class StimuliInfluenceDefaults : ScriptableObject
	{
		// Token: 0x06000F1A RID: 3866 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0x2BB51A0", Offset = "0x2BB37A0", VA = "0x182BB51A0")]
		private ValueDropdownList<string> GetStimuliTypes()
		{
			return null;
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1B")]
		[Address(RVA = "0x2BB51F0", Offset = "0x2BB37F0", VA = "0x182BB51F0")]
		internal void OnValidate()
		{
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1C")]
		[Address(RVA = "0x2BB5330", Offset = "0x2BB3930", VA = "0x182BB5330")]
		public void SetMemoryInfluenceValues(Dictionary<Type, StimuliInfluenceValues> typeMemory)
		{
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1D")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public StimuliInfluenceDefaults()
		{
		}

		// Token: 0x04000932 RID: 2354
		[Token(Token = "0x4000932")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<StimuliInfluence> _values;
	}
}
