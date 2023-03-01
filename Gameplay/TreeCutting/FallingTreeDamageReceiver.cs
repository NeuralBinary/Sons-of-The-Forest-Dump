using System;
using Il2CppDummyDll;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x020006DD RID: 1757
	[Token(Token = "0x20006DD")]
	public class FallingTreeDamageReceiver : MonoBehaviour, IImpactReceiver, IMonoBehaviour
	{
		// Token: 0x06002CF5 RID: 11509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CF5")]
		[Address(RVA = "0x2E03CC0", Offset = "0x2E02CC0", VA = "0x182E03CC0", Slot = "4")]
		public void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CF6")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public FallingTreeDamageReceiver()
		{
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF7")]
		[Address(RVA = "0x288E5E0", Offset = "0x288D5E0", VA = "0x18288E5E0", Slot = "5")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF8")]
		[Address(RVA = "0x5E9620", Offset = "0x5E8620", VA = "0x1805E9620", Slot = "6")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		[Token(Token = "0x6002CF9")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04002840 RID: 10304
		[Token(Token = "0x4002840")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DamageNode _damageNode;
	}
}
