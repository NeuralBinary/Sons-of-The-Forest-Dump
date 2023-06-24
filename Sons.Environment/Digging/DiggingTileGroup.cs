using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.VFX;

namespace Sons.Environment.Digging
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	public class DiggingTileGroup : MonoBehaviour
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x1700000D")]
		public bool IsGroupActive
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2FA9840", Offset = "0x2FA7E40", VA = "0x182FA9840")]
		private void OnEnable()
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2F9E030", Offset = "0x2F9C630", VA = "0x182F9E030")]
		private void OnDisable()
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2FA9850", Offset = "0x2FA7E50", VA = "0x182FA9850")]
		private void OnValidate()
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2FA9920", Offset = "0x2FA7F20", VA = "0x182FA9920")]
		private void Awake()
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2FA99C0", Offset = "0x2FA7FC0", VA = "0x182FA99C0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2FA9B10", Offset = "0x2FA8110", VA = "0x182FA9B10")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2FA9C60", Offset = "0x2FA8260", VA = "0x182FA9C60")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2FA9C70", Offset = "0x2FA8270", VA = "0x182FA9C70")]
		private void DoClosestTest()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public DiggingTileGrid GetGrid()
		{
			return null;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2FAA580", Offset = "0x2FA8B80", VA = "0x182FAA580")]
		public VisualEffect GetDigImpactFX()
		{
			return null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2FAA5A0", Offset = "0x2FA8BA0", VA = "0x182FAA5A0")]
		public DiggingTile GetClosest(Vector3 location, out float distance)
		{
			return null;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2FAA660", Offset = "0x2FA8C60", VA = "0x182FAA660")]
		public float GetDistanceSquared(Vector3 worldLocation)
		{
			return 0f;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2FAA770", Offset = "0x2FA8D70", VA = "0x182FAA770")]
		public void SetGroupActive(bool value)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2FAA790", Offset = "0x2FA8D90", VA = "0x182FAA790")]
		public void DigAll()
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2FAA7B0", Offset = "0x2FA8DB0", VA = "0x182FAA7B0")]
		public DiggingTileGroup()
		{
		}

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DiggingTileGrid _grid;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DigTool _closestTest;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _closestTestOffset;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _simulateDig;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x35")]
		private bool _allowEditorRefresh;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x38")]
		private DiggingTile _previousTileTest;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x40")]
		private bool _groupActive;
	}
}
