using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	[CreateAssetMenu(menuName = "Sons/Ai/StimuliGroupList", fileName = "Stimuli Group List", order = 0)]
	[Serializable]
	public class StimuliGroupList : ScriptableObject
	{
		// Token: 0x06000677 RID: 1655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x1487590", Offset = "0x1485B90", VA = "0x181487590")]
		private void OnValidate()
		{
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x2B3DFC0", Offset = "0x2B3C5C0", VA = "0x182B3DFC0")]
		private void CacheTypes()
		{
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x2B3E270", Offset = "0x2B3C870", VA = "0x182B3E270")]
		public void GetMappedTypes(Type groupType, List<Type> mappedTypes)
		{
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00004FF8 File Offset: 0x000031F8
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x2B3E440", Offset = "0x2B3CA40", VA = "0x182B3E440")]
		public bool GroupIncludes(Type groupType, Type checkType)
		{
			return default(bool);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x2B3E770", Offset = "0x2B3CD70", VA = "0x182B3E770")]
		public void CheckUsages(StringBuilder sb, List<Type> stimuliTypes)
		{
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x2B3EBE0", Offset = "0x2B3D1E0", VA = "0x182B3EBE0")]
		public StimuliGroupList()
		{
		}

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x18")]
		private bool _cacheDirty;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StimuliGroupList.StimuliGroup[] _stimuliGroups;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x28")]
		private List<StimuliGroupList.CachedStimuliGroup> _cachedStimuliGroups;

		// Token: 0x020000A5 RID: 165
		[Token(Token = "0x20000A5")]
		[Serializable]
		public struct StimuliGroup
		{
			// Token: 0x0600067D RID: 1661 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x2B3ECA0", Offset = "0x2B3D2A0", VA = "0x182B3ECA0")]
			private ValueDropdownList<string> GetStimuliTypes()
			{
				return null;
			}

			// Token: 0x0600067E RID: 1662 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x2B3ECF0", Offset = "0x2B3D2F0", VA = "0x182B3ECF0")]
			private ValueDropdownList<string> GetStimuliGroupTypes()
			{
				return null;
			}

			// Token: 0x0400052E RID: 1326
			[Token(Token = "0x400052E")]
			[FieldOffset(Offset = "0x0")]
			public string groupType;

			// Token: 0x0400052F RID: 1327
			[Token(Token = "0x400052F")]
			[FieldOffset(Offset = "0x8")]
			public string[] stimuliTypes;
		}

		// Token: 0x020000A6 RID: 166
		[Token(Token = "0x20000A6")]
		private struct CachedStimuliGroup
		{
			// Token: 0x04000530 RID: 1328
			[Token(Token = "0x4000530")]
			[FieldOffset(Offset = "0x0")]
			public Type GroupType;

			// Token: 0x04000531 RID: 1329
			[Token(Token = "0x4000531")]
			[FieldOffset(Offset = "0x8")]
			public List<Type> MappedTypes;
		}
	}
}
