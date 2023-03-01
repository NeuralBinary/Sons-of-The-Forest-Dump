using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Multiplayer;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000635 RID: 1589
	[Token(Token = "0x2000635")]
	[AddComponentMenu("Sons/Gameplay/ContainerItemSpawner")]
	public class ContainerItemSpawner : BoltEntityBehaviourWrapper<IStorageContainerState>
	{
		// Token: 0x060028C3 RID: 10435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C3")]
		[Address(RVA = "0x2DB3810", Offset = "0x2DB2810", VA = "0x182DB3810")]
		public void Awake()
		{
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C4")]
		[Address(RVA = "0x2DB4960", Offset = "0x2DB3960", VA = "0x182DB4960")]
		private void Start()
		{
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C5")]
		[Address(RVA = "0x2DB3AE0", Offset = "0x2DB2AE0", VA = "0x182DB3AE0")]
		private void OnEnable()
		{
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C6")]
		[Address(RVA = "0x2DB3580", Offset = "0x2DB2580", VA = "0x182DB3580", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C7")]
		[Address(RVA = "0x2DB3AD0", Offset = "0x2DB2AD0", VA = "0x182DB3AD0")]
		private void OnBreak(IBreakSender obj, IImpactData impactData)
		{
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C8")]
		[Address(RVA = "0x2DB4A50", Offset = "0x2DB3A50", VA = "0x182DB4A50")]
		private void Update()
		{
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C9")]
		[Address(RVA = "0x2DB3B20", Offset = "0x2DB2B20", VA = "0x182DB3B20")]
		public void OpenContainerNetworkCallback()
		{
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028CA")]
		[Address(RVA = "0x2DB3C00", Offset = "0x2DB2C00", VA = "0x182DB3C00")]
		public void OpenContainer(int contentsSeed = -1)
		{
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028CB")]
		[Address(RVA = "0x2DB3930", Offset = "0x2DB2930", VA = "0x182DB3930")]
		private void DisableTriggers()
		{
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028CC")]
		[Address(RVA = "0x2DB3A70", Offset = "0x2DB2A70", VA = "0x182DB3A70")]
		public void GrabEnter()
		{
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028CD")]
		[Address(RVA = "0x2DB3AA0", Offset = "0x2DB2AA0", VA = "0x182DB3AA0")]
		public void GrabExit()
		{
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028CE")]
		[Address(RVA = "0x2DB49A0", Offset = "0x2DB39A0", VA = "0x182DB49A0")]
		public void ToggleIcon(bool enable)
		{
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028CF")]
		[Address(RVA = "0x2DB4B40", Offset = "0x2DB3B40", VA = "0x182DB4B40")]
		public ContainerItemSpawner()
		{
		}

		// Token: 0x0400246F RID: 9327
		[Token(Token = "0x400246F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Transform> _spawnTransforms;

		// Token: 0x04002470 RID: 9328
		[Token(Token = "0x4002470")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ItemAnchorLocalOffsetData> _itemAnchorLocalOffsets;

		// Token: 0x04002471 RID: 9329
		[Token(Token = "0x4002471")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		private Transform _spawnTransform;

		// Token: 0x04002472 RID: 9330
		[Token(Token = "0x4002472")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector3 _randomOffset;

		// Token: 0x04002473 RID: 9331
		[Token(Token = "0x4002473")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector3 _randomRotation;

		// Token: 0x04002474 RID: 9332
		[Token(Token = "0x4002474")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ContainerItemSpawnerData _spawnData;

		// Token: 0x04002475 RID: 9333
		[Token(Token = "0x4002475")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _spawnsAreDynamic;

		// Token: 0x04002476 RID: 9334
		[Token(Token = "0x4002476")]
		[FieldOffset(Offset = "0x69")]
		[SerializeField]
		private bool _isBreakableOnly;

		// Token: 0x04002477 RID: 9335
		[Token(Token = "0x4002477")]
		[FieldOffset(Offset = "0x6A")]
		[SerializeField]
		private bool _autoCollectTriggers;

		// Token: 0x04002478 RID: 9336
		[Token(Token = "0x4002478")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<Collider> _triggers;

		// Token: 0x04002479 RID: 9337
		[Token(Token = "0x4002479")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[EventRef]
		private string _openContainerEvent;

		// Token: 0x0400247A RID: 9338
		[Token(Token = "0x400247A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0400247B RID: 9339
		[Token(Token = "0x400247B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _interactIcon;

		// Token: 0x0400247C RID: 9340
		[Token(Token = "0x400247C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _triggerOpen;

		// Token: 0x0400247D RID: 9341
		[Token(Token = "0x400247D")]
		[FieldOffset(Offset = "0x91")]
		[SerializeField]
		private bool _canForceSpawnFirstTarp;

		// Token: 0x0400247E RID: 9342
		[Token(Token = "0x400247E")]
		[FieldOffset(Offset = "0x92")]
		[SerializeField]
		private bool _isOpen;

		// Token: 0x0400247F RID: 9343
		[Token(Token = "0x400247F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private DamageNode _damageNode;

		// Token: 0x04002480 RID: 9344
		[Token(Token = "0x4002480")]
		[FieldOffset(Offset = "0xA0")]
		private bool _isFocused;
	}
}
