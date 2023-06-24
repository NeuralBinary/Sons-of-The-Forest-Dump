using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Rendering
{
	// Token: 0x020002A3 RID: 675
	[Token(Token = "0x20002A3")]
	[AddComponentMenu("Sons/Construction/CustomOcclusionVolume")]
	public class CustomOcclusionVolume : MonoBehaviour, IMonoBehaviour
	{
		// Token: 0x06001467 RID: 5223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001467")]
		[Address(RVA = "0x2DF17C0", Offset = "0x2DEFDC0", VA = "0x182DF17C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001468")]
		[Address(RVA = "0x2DF1B20", Offset = "0x2DF0120", VA = "0x182DF1B20")]
		private SuperStructure.Room GenerateRoom()
		{
			return null;
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001469")]
		[Address(RVA = "0x2DF1D20", Offset = "0x2DF0320", VA = "0x182DF1D20")]
		private void OnDisable()
		{
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600146A")]
		[Address(RVA = "0x2DF1D90", Offset = "0x2DF0390", VA = "0x182DF1D90")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600146B")]
		[Address(RVA = "0x675200", Offset = "0x673800", VA = "0x180675200")]
		public CustomOcclusionVolume()
		{
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600146C")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "4")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600146D")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "5")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0000BF3C File Offset: 0x0000A13C
		[Token(Token = "0x600146E")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x040009EF RID: 2543
		[Token(Token = "0x40009EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CustomOcclusionVolume.FakeSuperStructure _superStructure;

		// Token: 0x040009F0 RID: 2544
		[Token(Token = "0x40009F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _granularity;

		// Token: 0x020002A4 RID: 676
		[Token(Token = "0x20002A4")]
		[Serializable]
		public class FakeSuperStructure : SuperStructure
		{
			// Token: 0x17000441 RID: 1089
			// (get) Token: 0x0600146F RID: 5231 RVA: 0x0000BF54 File Offset: 0x0000A154
			[Token(Token = "0x17000441")]
			public override float GridTileHeight
			{
				[Token(Token = "0x600146F")]
				[Address(RVA = "0x2A21DD0", Offset = "0x2A203D0", VA = "0x182A21DD0", Slot = "7")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000442 RID: 1090
			// (get) Token: 0x06001470 RID: 5232 RVA: 0x0000BF6C File Offset: 0x0000A16C
			[Token(Token = "0x17000442")]
			public override float GridTileLength
			{
				[Token(Token = "0x6001470")]
				[Address(RVA = "0x2DF1E30", Offset = "0x2DF0430", VA = "0x182DF1E30", Slot = "8")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000443 RID: 1091
			// (get) Token: 0x06001471 RID: 5233 RVA: 0x0000BF84 File Offset: 0x0000A184
			[Token(Token = "0x17000443")]
			public override float GridTileHalfLength
			{
				[Token(Token = "0x6001471")]
				[Address(RVA = "0x2DF1E40", Offset = "0x2DF0440", VA = "0x182DF1E40", Slot = "9")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06001472 RID: 5234 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001472")]
			[Address(RVA = "0x2DF1E50", Offset = "0x2DF0450", VA = "0x182DF1E50")]
			public void Register(SuperStructure.Room room)
			{
			}

			// Token: 0x06001473 RID: 5235 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001473")]
			[Address(RVA = "0x2DF1FA0", Offset = "0x2DF05A0", VA = "0x182DF1FA0")]
			public FakeSuperStructure(IMonoBehaviour origin, float granularity)
			{
			}

			// Token: 0x040009F1 RID: 2545
			[Token(Token = "0x40009F1")]
			[FieldOffset(Offset = "0x108")]
			private float _gridTileHeight;

			// Token: 0x040009F2 RID: 2546
			[Token(Token = "0x40009F2")]
			[FieldOffset(Offset = "0x10C")]
			private float _gridTileLength;

			// Token: 0x040009F3 RID: 2547
			[Token(Token = "0x40009F3")]
			[FieldOffset(Offset = "0x110")]
			private float _gridTileHalfLength;
		}
	}
}
