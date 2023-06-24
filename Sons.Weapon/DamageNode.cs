using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Weapon
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	[AddComponentMenu("Sons/Weapon/Damage Node")]
	[Serializable]
	public class DamageNode : DamageCallbackMono, IDamageCallbackSender, IImpactReceiver, IMonoBehaviour, IImpactSender, IBreakSender
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x17000025")]
		public bool CanBlock
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x270DEE0", Offset = "0x270C4E0", VA = "0x18270DEE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x6124D0", Offset = "0x610AD0", VA = "0x1806124D0")]
		public void SetBreakAmount(float breakAmount)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x28D8B80", Offset = "0x28D7180", VA = "0x1828D8B80")]
		public void SetAbsorptionAmount(float absorptionAmount)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x25AEED0", Offset = "0x25AD4D0", VA = "0x1825AEED0")]
		public void SetIsArmour(bool value)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xAFF3F0", Offset = "0xAFD9F0", VA = "0x180AFF3F0")]
		public void SetImpactAudioMaterial(AudioImpactMaterial audioMaterial)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x25AEEC0", Offset = "0x25AD4C0", VA = "0x1825AEEC0")]
		public bool IsArmour()
		{
			return default(bool);
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060000E4 RID: 228 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060000E5 RID: 229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000004")]
		private event Action<IImpactSender, IImpactData, bool> _dismemberImpactReceivers
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x319C710", Offset = "0x319AD10", VA = "0x18319C710")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x319C880", Offset = "0x319AE80", VA = "0x18319C880")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x17000026")]
		public bool IsBlocking
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x319C9F0", Offset = "0x319AFF0", VA = "0x18319C9F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x17000027")]
		public bool IsDodging
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x6124E0", Offset = "0x610AE0", VA = "0x1806124E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x17000028")]
		public bool IsParrying
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x25AEEA0", Offset = "0x25AD4A0", VA = "0x1825AEEA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2DBF050", Offset = "0x2DBD650", VA = "0x182DBF050", Slot = "14")]
		public Transform GetRootTransform()
		{
			return null;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x270DF00", Offset = "0x270C500", VA = "0x18270DF00")]
		public void SetIsBlocking(bool value)
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x26FA7E0", Offset = "0x26F8DE0", VA = "0x1826FA7E0")]
		public void SetBlockDamageMultiplier(float value)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x319CAF0", Offset = "0x319B0F0", VA = "0x18319CAF0")]
		public void SetIsDodging(bool value)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x25AEEB0", Offset = "0x25AD4B0", VA = "0x1825AEEB0")]
		public void SetIsParrying(bool value)
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x319CB00", Offset = "0x319B100", VA = "0x18319CB00")]
		public void SetTeam(float teamDamageMultiplier, Type teamStimuliType)
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0", Slot = "17")]
		private string GetId()
		{
			return null;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x319CB60", Offset = "0x319B160", VA = "0x18319CB60", Slot = "18")]
		public bool IsChild()
		{
			return default(bool);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
		public DamageNode GetParentNode()
		{
			return null;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000029")]
		public Collider GetCollider
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x319CC20", Offset = "0x319B220", VA = "0x18319CC20")]
		private void OnValidate()
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x319CCB0", Offset = "0x319B2B0", VA = "0x18319CCB0")]
		private void Start()
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x319CDF0", Offset = "0x319B3F0", VA = "0x18319CDF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x319CE20", Offset = "0x319B420", VA = "0x18319CE20", Slot = "4")]
		protected override bool IsValidImpact(IImpactData impactData)
		{
			return default(bool);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x319C710", Offset = "0x319AD10", VA = "0x18319C710")]
		public void RegisterDismemberImpactCallback(Action<IImpactSender, IImpactData, bool> onImpact)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x319CEF0", Offset = "0x319B4F0", VA = "0x18319CEF0")]
		private void UnHookFromChild()
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x319CF00", Offset = "0x319B500", VA = "0x18319CF00")]
		public void AssignParent(DamageNode damageNode)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x319CF90", Offset = "0x319B590", VA = "0x18319CF90")]
		private void AssignChild(DamageNode damageNode)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x319D330", Offset = "0x319B930", VA = "0x18319D330")]
		public void UnHookFromParent()
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x319D410", Offset = "0x319BA10", VA = "0x18319D410")]
		public ValueDropdownList<string> GetAllIds()
		{
			return null;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0", Slot = "5")]
		public string GetName()
		{
			return null;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x319D7F0", Offset = "0x319BDF0", VA = "0x18319D7F0", Slot = "6")]
		public int GetId()
		{
			return 0;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x319DA40", Offset = "0x319C040", VA = "0x18319DA40")]
		private bool WasImpactBlocked(IImpactData impactData)
		{
			return default(bool);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x319DCF0", Offset = "0x319C2F0", VA = "0x18319DCF0")]
		private float GetDamageMultiplier(IImpactData impactData, bool wasBlocked)
		{
			return 0f;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x319DFC0", Offset = "0x319C5C0", VA = "0x18319DFC0", Slot = "7")]
		public void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x319E1B0", Offset = "0x319C7B0", VA = "0x18319E1B0")]
		private void HandleImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x319E5B0", Offset = "0x319CBB0", VA = "0x18319E5B0")]
		public void ApplyNodeDamage(float damage, [System.Runtime.InteropServices.Optional] IImpactData impactData)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x319E610", Offset = "0x319CC10", VA = "0x18319E610")]
		[ContextMenu("Force Break")]
		public void ForceBreak()
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x319E730", Offset = "0x319CD30", VA = "0x18319E730")]
		private void CheckBreak(IImpactData impactData)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x319E780", Offset = "0x319CD80", VA = "0x18319E780")]
		public void RepairBreak(float recoveredHealth)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x319E7B0", Offset = "0x319CDB0", VA = "0x18319E7B0")]
		public static bool IsFlesh(Component comp)
		{
			return default(bool);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x319E850", Offset = "0x319CE50", VA = "0x18319E850")]
		public bool IsFlesh()
		{
			return default(bool);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x319E8F0", Offset = "0x319CEF0", VA = "0x18319E8F0")]
		public AudioImpactMaterial ImpactAudioMaterial()
		{
			return AudioImpactMaterial.None;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x319E920", Offset = "0x319CF20", VA = "0x18319E920")]
		public void SpawnBlood(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		private void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "15")]
		private MonoBehaviour GetSourceStimuli()
		{
			return null;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x319F280", Offset = "0x319D880", VA = "0x18319F280")]
		public DamageNode()
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "8")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "9")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x6000110")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[FormerlySerializedAs("_sourceMap")]
		private DamageNodeMap _nodeMap;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[FormerlySerializedAs("_id")]
		private string _name;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _autoFindCollider;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Collider _collider;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[FormerlySerializedAs("_damageMultiplier")]
		[SerializeField]
		private float _damageMultiplierProjectile;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _damageMultiplierBlunt;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _damageMultiplierSharp;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _damageMultiplierExplosive;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _damageMultiplierBlocking;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private bool _canBlock;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		[SerializeField]
		private bool _isBlocking;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x76")]
		[Tooltip("If false, all impact damage remains with impact to be applied if another node is hit")]
		[SerializeField]
		private bool _updateImpactDamage;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _damageAbsorptionAmount;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private bool _useBreak;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _breakAmount;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Tooltip("If true this node accumulates all damage beyond break amount. If false additional damage sets remainingRawDamage on impact.")]
		[SerializeField]
		private bool _takeDamageAfterBreak;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool _isBroken;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _currentAppliedNodeDamage;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private DamageNode _parentDamageNode;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private DamageNode _childDamageNode;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _isDodging;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool _isParrying;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		private bool _isArmour;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int _lastImpactId;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float _lastImpactTime;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool _useTeamDamage;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float _teamDamageMultiplier;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Type _teamStimuliType;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioImpactMaterial _impactAudioMaterial;
	}
}
