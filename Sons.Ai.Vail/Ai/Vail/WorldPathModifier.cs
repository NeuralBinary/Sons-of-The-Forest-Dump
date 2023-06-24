using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000E6 RID: 230
	[Token(Token = "0x20000E6")]
	[AddComponentMenu("Sons/Ai/WorldPathModifier")]
	public class WorldPathModifier : MonoBehaviour
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00005E38 File Offset: 0x00004038
		[Token(Token = "0x17000081")]
		public float Radius
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000897")]
		[Address(RVA = "0x2B6ED90", Offset = "0x2B6D390", VA = "0x182B6ED90")]
		private void RebuildWorldPaths()
		{
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000898")]
		[Address(RVA = "0x2B6EE50", Offset = "0x2B6D450", VA = "0x182B6EE50")]
		private void SnapToTerrain()
		{
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x2B6EEE0", Offset = "0x2B6D4E0", VA = "0x182B6EEE0")]
		private void PositionToCameraTrace()
		{
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x2B6EF70", Offset = "0x2B6D570", VA = "0x182B6EF70")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089B")]
		[Address(RVA = "0x2B6EF80", Offset = "0x2B6D580", VA = "0x182B6EF80")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089C")]
		[Address(RVA = "0x2B6EF90", Offset = "0x2B6D590", VA = "0x182B6EF90")]
		private void DrawGizmos()
		{
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089D")]
		[Address(RVA = "0xB07D60", Offset = "0xB06360", VA = "0x180B07D60")]
		public WorldPathModifier()
		{
		}

		// Token: 0x0400071B RID: 1819
		[Token(Token = "0x400071B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _radius;

		// Token: 0x0400071C RID: 1820
		[Token(Token = "0x400071C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _alwaysDrawGizmos;
	}
}
