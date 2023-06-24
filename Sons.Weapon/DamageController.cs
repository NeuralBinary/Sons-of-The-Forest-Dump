using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Weapon
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	[AddComponentMenu("Sons/Weapon/Damage Controller")]
	public class DamageController : DamageCallbackMono
	{
		// Token: 0x060000CD RID: 205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x319A920", Offset = "0x3198F20", VA = "0x18319A920")]
		public void SetBlocking(bool value)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x319AB10", Offset = "0x3199110", VA = "0x18319AB10")]
		public void SetBlockDamageMultiplier(float value)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x213CBA0", Offset = "0x213B1A0", VA = "0x18213CBA0")]
		public bool IsBlocking()
		{
			return default(bool);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1F05980", Offset = "0x1F03F80", VA = "0x181F05980")]
		public float GetBlockDamageMultiplier()
		{
			return 0f;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x319ACF0", Offset = "0x31992F0", VA = "0x18319ACF0")]
		public void SetDodging(bool value)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x319AEE0", Offset = "0x31994E0", VA = "0x18319AEE0")]
		public void SetParrying(bool value)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x319B0C0", Offset = "0x31996C0", VA = "0x18319B0C0")]
		public void SetDamageEnabled(bool value)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x319B2B0", Offset = "0x31998B0", VA = "0x18319B2B0")]
		public void SetTeam(float teamDamageMultiplier, Type teamStimuliType)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x319B4A0", Offset = "0x3199AA0", VA = "0x18319B4A0")]
		private void OnValidate()
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x319B5E0", Offset = "0x3199BE0", VA = "0x18319B5E0")]
		private void OnEnable()
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x319B8B0", Offset = "0x3199EB0", VA = "0x18319B8B0")]
		private void OnDisable()
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x319BBC0", Offset = "0x319A1C0", VA = "0x18319BBC0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x319C0A0", Offset = "0x319A6A0", VA = "0x18319C0A0")]
		private new bool IsValid(IImpactData impactData)
		{
			return default(bool);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x319A870", Offset = "0x3198E70", VA = "0x18319A870")]
		private void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x319C350", Offset = "0x319A950", VA = "0x18319C350")]
		public void RepairBreaks(float newHealth)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x319C560", Offset = "0x319AB60", VA = "0x18319C560")]
		public DamageNode GetNodeById(int id)
		{
			return null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x319C6C0", Offset = "0x319ACC0", VA = "0x18319C6C0")]
		public DamageController()
		{
		}

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		private const float MinTimeBetweenReceived = 2f;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _autoFindInChildren;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("_sources")]
		[SerializeField]
		private List<DamageNode> _damageNodes;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<int, float> _receivedSources;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x58")]
		private List<int> _removeBuffer;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x60")]
		private bool _isBlocking;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x64")]
		private float _blockDamageMultiplier;
	}
}
