using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	[CreateAssetMenu(menuName = "Sons/Ai/Spawn Modifiers", fileName = "VailSpawnModifiers", order = 0)]
	public class VailSpawnModifiers : ScriptableObject
	{
		// Token: 0x0600082F RID: 2095 RVA: 0x00005B50 File Offset: 0x00003D50
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x2B66BC0", Offset = "0x2B651C0", VA = "0x182B66BC0")]
		public float GetSpawnCountMult(VailActorTypeId typeId)
		{
			return 0f;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public VailSpawnModifiers()
		{
		}

		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x4000673")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<VailSpawnModifiers.SpawnCountModifier> _modifierList;

		// Token: 0x020000D4 RID: 212
		[Token(Token = "0x20000D4")]
		[Serializable]
		private class SpawnCountModifier
		{
			// Token: 0x06000831 RID: 2097 RVA: 0x00005B68 File Offset: 0x00003D68
			[Token(Token = "0x6000831")]
			[Address(RVA = "0x2B577D0", Offset = "0x2B55DD0", VA = "0x182B577D0")]
			private Color GetGuiColor()
			{
				return default(Color);
			}

			// Token: 0x06000832 RID: 2098 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000832")]
			[Address(RVA = "0x6C1AF0", Offset = "0x6C00F0", VA = "0x1806C1AF0")]
			public SpawnCountModifier()
			{
			}

			// Token: 0x04000674 RID: 1652
			[Token(Token = "0x4000674")]
			[FieldOffset(Offset = "0x10")]
			public VailActorTypeId _typeId;

			// Token: 0x04000675 RID: 1653
			[Token(Token = "0x4000675")]
			[FieldOffset(Offset = "0x14")]
			public float _spawnMult;
		}
	}
}
