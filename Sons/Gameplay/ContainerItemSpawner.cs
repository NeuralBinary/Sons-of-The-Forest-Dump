using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Multiplayer;
using Sons.Save;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gameplay
{
	// Token: 0x02000751 RID: 1873
	[Token(Token = "0x2000751")]
	[AddComponentMenu("Sons/Gameplay/ContainerItemSpawner")]
	public class ContainerItemSpawner : BoltEntityBehaviourWrapper<IStorageContainerState>
	{
		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06003298 RID: 12952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700068A")]
		public string ContainerDataName
		{
			[Token(Token = "0x6003298")]
			[Address(RVA = "0x34A57D0", Offset = "0x34A3DD0", VA = "0x1834A57D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003299")]
		[Address(RVA = "0x34A57F0", Offset = "0x34A3DF0", VA = "0x1834A57F0")]
		public void Awake()
		{
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600329A")]
		[Address(RVA = "0x34A5970", Offset = "0x34A3F70", VA = "0x1834A5970")]
		private void Start()
		{
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600329B")]
		[Address(RVA = "0x34A59B0", Offset = "0x34A3FB0", VA = "0x1834A59B0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600329C")]
		[Address(RVA = "0x34A5CE0", Offset = "0x34A42E0", VA = "0x1834A5CE0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600329D")]
		[Address(RVA = "0x34A60E0", Offset = "0x34A46E0", VA = "0x1834A60E0")]
		private void OnBreak(IBreakSender obj, IImpactData impactData)
		{
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600329E")]
		[Address(RVA = "0x34A60F0", Offset = "0x34A46F0", VA = "0x1834A60F0")]
		private void Update()
		{
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600329F")]
		[Address(RVA = "0x34A61E0", Offset = "0x34A47E0", VA = "0x1834A61E0")]
		public void OpenContainerNetworkCallback(bool spawnItems)
		{
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A0")]
		[Address(RVA = "0x34A6290", Offset = "0x34A4890", VA = "0x1834A6290")]
		public void OpenContainer(bool spawnItems = true, int contentsSeed = -1)
		{
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A1")]
		[Address(RVA = "0x34A6C60", Offset = "0x34A5260", VA = "0x1834A6C60")]
		private void SpawnItems(int contentsSeed, bool openedLocally)
		{
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A2")]
		[Address(RVA = "0x34A7B70", Offset = "0x34A6170", VA = "0x1834A7B70")]
		private void DisableTriggers()
		{
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A3")]
		[Address(RVA = "0x34A7D50", Offset = "0x34A6350", VA = "0x1834A7D50")]
		public void GrabEnter()
		{
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A4")]
		[Address(RVA = "0x34A7D80", Offset = "0x34A6380", VA = "0x1834A7D80")]
		public void GrabExit()
		{
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A5")]
		[Address(RVA = "0x34A7DA0", Offset = "0x34A63A0", VA = "0x1834A7DA0")]
		public void ToggleIcon(bool enable)
		{
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A6")]
		[Address(RVA = "0x728460", Offset = "0x726A60", VA = "0x180728460")]
		public void SetContainerId(string containerId)
		{
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A7")]
		[Address(RVA = "0x34A7EE0", Offset = "0x34A64E0", VA = "0x1834A7EE0")]
		public void SaveAsSatisfied()
		{
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A8")]
		[Address(RVA = "0x34A7F50", Offset = "0x34A6550", VA = "0x1834A7F50")]
		private void SetupStateSync()
		{
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A9")]
		[Address(RVA = "0x34A80E0", Offset = "0x34A66E0", VA = "0x1834A80E0")]
		private void AppliedState(NamedIntData saveValue)
		{
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032AA")]
		[Address(RVA = "0x34A8130", Offset = "0x34A6730", VA = "0x1834A8130")]
		public ContainerItemSpawner()
		{
		}

		// Token: 0x04002BAE RID: 11182
		[Token(Token = "0x4002BAE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Transform> _spawnTransforms;

		// Token: 0x04002BAF RID: 11183
		[Token(Token = "0x4002BAF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ItemAnchorLocalOffsetData> _itemAnchorLocalOffsets;

		// Token: 0x04002BB0 RID: 11184
		[Token(Token = "0x4002BB0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private Transform _spawnTransform;

		// Token: 0x04002BB1 RID: 11185
		[Token(Token = "0x4002BB1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector3 _randomOffset;

		// Token: 0x04002BB2 RID: 11186
		[Token(Token = "0x4002BB2")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector3 _randomRotation;

		// Token: 0x04002BB3 RID: 11187
		[Token(Token = "0x4002BB3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ContainerItemSpawnerData _spawnData;

		// Token: 0x04002BB4 RID: 11188
		[Token(Token = "0x4002BB4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _spawnsAreDynamic;

		// Token: 0x04002BB5 RID: 11189
		[Token(Token = "0x4002BB5")]
		[FieldOffset(Offset = "0x69")]
		[SerializeField]
		private bool _isBreakableOnly;

		// Token: 0x04002BB6 RID: 11190
		[Token(Token = "0x4002BB6")]
		[FieldOffset(Offset = "0x6A")]
		[SerializeField]
		private bool _autoCollectTriggers;

		// Token: 0x04002BB7 RID: 11191
		[Token(Token = "0x4002BB7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<Collider> _triggers;

		// Token: 0x04002BB8 RID: 11192
		[Token(Token = "0x4002BB8")]
		[FieldOffset(Offset = "0x78")]
		[EventRef]
		[SerializeField]
		private string _openContainerEvent;

		// Token: 0x04002BB9 RID: 11193
		[Token(Token = "0x4002BB9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04002BBA RID: 11194
		[Token(Token = "0x4002BBA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _interactIcon;

		// Token: 0x04002BBB RID: 11195
		[Token(Token = "0x4002BBB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _triggerOpen;

		// Token: 0x04002BBC RID: 11196
		[Token(Token = "0x4002BBC")]
		[FieldOffset(Offset = "0x91")]
		[SerializeField]
		private bool _canForceSpawnFirstTarp;

		// Token: 0x04002BBD RID: 11197
		[Token(Token = "0x4002BBD")]
		[FieldOffset(Offset = "0x92")]
		[SerializeField]
		private bool _isOpen;

		// Token: 0x04002BBE RID: 11198
		[Token(Token = "0x4002BBE")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private DamageNode _damageNode;

		// Token: 0x04002BBF RID: 11199
		[Token(Token = "0x4002BBF")]
		[FieldOffset(Offset = "0xA0")]
		private bool _isFocused;

		// Token: 0x04002BC0 RID: 11200
		[Token(Token = "0x4002BC0")]
		[FieldOffset(Offset = "0xA4")]
		private int _locallyOpenedSeed;

		// Token: 0x04002BC1 RID: 11201
		[Token(Token = "0x4002BC1")]
		[FieldOffset(Offset = "0xA8")]
		private NamedIntData _namedIntData;

		// Token: 0x04002BC2 RID: 11202
		[Token(Token = "0x4002BC2")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UnityEvent _onLoadedAndIsSatisfied;

		// Token: 0x04002BC3 RID: 11203
		[Token(Token = "0x4002BC3")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string _containerId;
	}
}
