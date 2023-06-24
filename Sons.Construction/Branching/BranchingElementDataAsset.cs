using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.Branching
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[CreateAssetMenu(menuName = "Sons/Construction/Branching/BranchingElementDataAsset")]
	public class BranchingElementDataAsset : ScriptableObject
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000029")]
		public BranchingElementData Data
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public BranchingElementDataAsset()
		{
		}

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BranchingElementData _data;
	}
}
