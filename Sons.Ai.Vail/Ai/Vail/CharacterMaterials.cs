using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	[CreateAssetMenu(menuName = "Sons/Ai/Character Materials", fileName = "CharacterMaterials", order = 0)]
	public class CharacterMaterials : ScriptableObject
	{
		// Token: 0x06000436 RID: 1078 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x2B10EE0", Offset = "0x2B0F4E0", VA = "0x182B10EE0")]
		public CharacterMaterials.MaterialsForType GetMaterialsForType(VailActorTypeId typeId)
		{
			return null;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public CharacterMaterials()
		{
		}

		// Token: 0x0400035D RID: 861
		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CharacterMaterials.MaterialsForType> _setups;

		// Token: 0x02000055 RID: 85
		[Token(Token = "0x2000055")]
		[Serializable]
		public class MaterialsForType
		{
			// Token: 0x06000438 RID: 1080 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public MaterialsForType()
			{
			}

			// Token: 0x0400035E RID: 862
			[Token(Token = "0x400035E")]
			[FieldOffset(Offset = "0x10")]
			public VailActorTypeId _typeId;

			// Token: 0x0400035F RID: 863
			[Token(Token = "0x400035F")]
			[FieldOffset(Offset = "0x18")]
			public Material _headMaterial;

			// Token: 0x04000360 RID: 864
			[Token(Token = "0x4000360")]
			[FieldOffset(Offset = "0x20")]
			public Material _headCookedMaterial;

			// Token: 0x04000361 RID: 865
			[Token(Token = "0x4000361")]
			[FieldOffset(Offset = "0x28")]
			public Material _headDriedMaterial;

			// Token: 0x04000362 RID: 866
			[Token(Token = "0x4000362")]
			[FieldOffset(Offset = "0x30")]
			public Material _headBurntMaterial;

			// Token: 0x04000363 RID: 867
			[Token(Token = "0x4000363")]
			[FieldOffset(Offset = "0x38")]
			public Material _headRottenMaterial;

			// Token: 0x04000364 RID: 868
			[Token(Token = "0x4000364")]
			[FieldOffset(Offset = "0x40")]
			public Material _bodyMaterial;

			// Token: 0x04000365 RID: 869
			[Token(Token = "0x4000365")]
			[FieldOffset(Offset = "0x48")]
			public Material _bodyCookedMaterial;

			// Token: 0x04000366 RID: 870
			[Token(Token = "0x4000366")]
			[FieldOffset(Offset = "0x50")]
			public Material _bodyDriedMaterial;

			// Token: 0x04000367 RID: 871
			[Token(Token = "0x4000367")]
			[FieldOffset(Offset = "0x58")]
			public Material _bodyBurntMaterial;

			// Token: 0x04000368 RID: 872
			[Token(Token = "0x4000368")]
			[FieldOffset(Offset = "0x60")]
			public Material _bodyRottenMaterial;
		}
	}
}
