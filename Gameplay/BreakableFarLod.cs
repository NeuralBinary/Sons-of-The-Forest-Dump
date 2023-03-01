using System;
using Il2CppDummyDll;
using Sons.TerrainDetail;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200062F RID: 1583
	[Token(Token = "0x200062F")]
	[AddComponentMenu("Sons/Gameplay/BreakableFarLod")]
	public class BreakableFarLod : MonoBehaviour
	{
		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06002871 RID: 10353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000558")]
		public GameObject OriginalObject
		{
			[Token(Token = "0x6002871")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002872")]
		[Address(RVA = "0x541240", Offset = "0x540240", VA = "0x180541240")]
		public void SetOriginalObject(GameObject root)
		{
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002873")]
		[Address(RVA = "0x2DAD460", Offset = "0x2DAC460", VA = "0x182DAD460")]
		private void TryGetWorldObjectLocatorHolder()
		{
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002874")]
		[Address(RVA = "0x2DAD440", Offset = "0x2DAC440", VA = "0x182DAD440")]
		private void OnValidate()
		{
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002875")]
		[Address(RVA = "0x2DAD300", Offset = "0x2DAC300", VA = "0x182DAD300")]
		public void OnEnable()
		{
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002876")]
		[Address(RVA = "0x2DACD40", Offset = "0x2DABD40", VA = "0x182DACD40")]
		private void InitializeWorldObjectLocatorHolder()
		{
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002877")]
		[Address(RVA = "0x2DAD1C0", Offset = "0x2DAC1C0", VA = "0x182DAD1C0")]
		public void OnDisable()
		{
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002878")]
		[Address(RVA = "0x2DAD450", Offset = "0x2DAC450", VA = "0x182DAD450")]
		private void OnWorldObjectLocatorStateChanged(WorldObjectState state)
		{
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002879")]
		[Address(RVA = "0x2DACE80", Offset = "0x2DABE80", VA = "0x182DACE80")]
		private void OnBreak()
		{
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287A")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public BreakableFarLod()
		{
		}

		// Token: 0x0400241D RID: 9245
		[Token(Token = "0x400241D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _originalObject;

		// Token: 0x0400241E RID: 9246
		[Token(Token = "0x400241E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WorldObjectLocatorHolder _worldObjectLocatorHolder;

		// Token: 0x0400241F RID: 9247
		[Token(Token = "0x400241F")]
		[FieldOffset(Offset = "0x30")]
		private bool _isBroken;
	}
}
