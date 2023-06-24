using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail.Traits;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	[CreateAssetMenu(menuName = "Sons/Ai/VailTraitDefinition", fileName = "VailTraitDefinition", order = 0)]
	public class VailTraitDefinition : ScriptableObject
	{
		// Token: 0x06000862 RID: 2146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x2B6A7B0", Offset = "0x2B68DB0", VA = "0x182B6A7B0")]
		private void OnValidate()
		{
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x2B6AA40", Offset = "0x2B69040", VA = "0x182B6AA40")]
		private void Reset()
		{
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x2B6AA50", Offset = "0x2B69050", VA = "0x182B6AA50")]
		private void AddSpace(int opt)
		{
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x2B6AA60", Offset = "0x2B69060", VA = "0x182B6AA60")]
		private void BeginListItem(int opt)
		{
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x2B6AAD0", Offset = "0x2B690D0", VA = "0x182B6AAD0")]
		private void EndListItem(int opt)
		{
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x2B6AB40", Offset = "0x2B69140", VA = "0x182B6AB40")]
		private void ValidateTraits()
		{
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000868")]
		public Trait GetTrait<T>()
		{
			return null;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x2B6ABD0", Offset = "0x2B691D0", VA = "0x182B6ABD0")]
		public Trait GetTrait(Type targetType)
		{
			return null;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public VailTraitDefinition()
		{
		}

		// Token: 0x040006B8 RID: 1720
		[Token(Token = "0x40006B8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeReference]
		private List<Trait> _traits;
	}
}
