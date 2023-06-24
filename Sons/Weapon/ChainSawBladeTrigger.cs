using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008A4 RID: 2212
	[Token(Token = "0x20008A4")]
	[AddComponentMenu("Sons/Weapon/ChainSawBladeTrigger")]
	public class ChainSawBladeTrigger : MonoBehaviour
	{
		// Token: 0x06003F04 RID: 16132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F04")]
		[Address(RVA = "0x35DD470", Offset = "0x35DBA70", VA = "0x1835DD470")]
		private void OnValidate()
		{
		}

		// Token: 0x06003F05 RID: 16133 RVA: 0x000132A8 File Offset: 0x000114A8
		[Token(Token = "0x6003F05")]
		[Address(RVA = "0x35DD5A0", Offset = "0x35DBBA0", VA = "0x1835DD5A0")]
		private bool ValidCollider(Collider other)
		{
			return default(bool);
		}

		// Token: 0x06003F06 RID: 16134 RVA: 0x000132C0 File Offset: 0x000114C0
		[Token(Token = "0x6003F06")]
		[Address(RVA = "0x35DD690", Offset = "0x35DBC90", VA = "0x1835DD690")]
		private bool IsWood(Collider other)
		{
			return default(bool);
		}

		// Token: 0x06003F07 RID: 16135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F07")]
		[Address(RVA = "0x35DD710", Offset = "0x35DBD10", VA = "0x1835DD710")]
		private void OnDisable()
		{
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F08")]
		[Address(RVA = "0x35DD770", Offset = "0x35DBD70", VA = "0x1835DD770")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003F09 RID: 16137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F09")]
		[Address(RVA = "0x35DDAE0", Offset = "0x35DC0E0", VA = "0x1835DDAE0")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06003F0A RID: 16138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F0A")]
		[Address(RVA = "0x35DDB40", Offset = "0x35DC140", VA = "0x1835DDB40")]
		private void UpdateOverlap(Collider other)
		{
		}

		// Token: 0x06003F0B RID: 16139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F0B")]
		[Address(RVA = "0x35DDC80", Offset = "0x35DC280", VA = "0x1835DDC80")]
		private void Update()
		{
		}

		// Token: 0x06003F0C RID: 16140 RVA: 0x000132D8 File Offset: 0x000114D8
		[Token(Token = "0x6003F0C")]
		[Address(RVA = "0x35DDED0", Offset = "0x35DC4D0", VA = "0x1835DDED0")]
		public bool IsCuttingFlesh()
		{
			return default(bool);
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x000132F0 File Offset: 0x000114F0
		[Token(Token = "0x6003F0D")]
		[Address(RVA = "0x2084CB0", Offset = "0x20832B0", VA = "0x182084CB0")]
		public bool IsCuttingTree()
		{
			return default(bool);
		}

		// Token: 0x06003F0E RID: 16142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F0E")]
		[Address(RVA = "0x35DDF40", Offset = "0x35DC540", VA = "0x1835DDF40")]
		public ChainSawBladeTrigger()
		{
		}

		// Token: 0x040034AD RID: 13485
		[Token(Token = "0x40034AD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Collider _bladeCollider;

		// Token: 0x040034AE RID: 13486
		[Token(Token = "0x40034AE")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<Collider> _activeColliders;

		// Token: 0x040034AF RID: 13487
		[Token(Token = "0x40034AF")]
		[FieldOffset(Offset = "0x30")]
		private float _cuttingFleshTime;

		// Token: 0x040034B0 RID: 13488
		[Token(Token = "0x40034B0")]
		[FieldOffset(Offset = "0x34")]
		private bool _cuttingTree;

		// Token: 0x040034B1 RID: 13489
		[Token(Token = "0x40034B1")]
		[FieldOffset(Offset = "0x35")]
		private bool _cuttingFlesh;
	}
}
