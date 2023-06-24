using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Sons.VFX
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[AddComponentMenu("Sons/VFX/CollisionTriggerActivator")]
	public class CollisionTriggerActivator : MonoBehaviour
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x612490", Offset = "0x610A90", VA = "0x180612490")]
		public void ShouldSpawnPrefabs(bool shouldSpawn)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x15771D0", Offset = "0x15757D0", VA = "0x1815771D0")]
		public bool GetDestroyGroups()
		{
			return default(bool);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x316D740", Offset = "0x316BD40", VA = "0x18316D740")]
		private void OnValidate()
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x316D750", Offset = "0x316BD50", VA = "0x18316D750")]
		private void Start()
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x316D8C0", Offset = "0x316BEC0", VA = "0x18316D8C0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x316D920", Offset = "0x316BF20", VA = "0x18316D920")]
		private void Update()
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x316D9A0", Offset = "0x316BFA0", VA = "0x18316D9A0")]
		private void CheckLifespan()
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x316DC40", Offset = "0x316C240", VA = "0x18316DC40")]
		private void CheckTimeout()
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x316DCB0", Offset = "0x316C2B0", VA = "0x18316DCB0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x316DE50", Offset = "0x316C450", VA = "0x18316DE50")]
		private void ActivationProcess()
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x316E540", Offset = "0x316CB40", VA = "0x18316E540")]
		private void DestroyTarget(GameObject target)
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x316E600", Offset = "0x316CC00", VA = "0x18316E600")]
		private void PopulateLists(out List<GameObject> activateList, out List<GameObject> destroyList)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x316ED60", Offset = "0x316D360", VA = "0x18316ED60")]
		public void InsertGroup(int index, GameObject target)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x316EEA0", Offset = "0x316D4A0", VA = "0x18316EEA0")]
		public void AddGroup(GameObject target)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x316EFB0", Offset = "0x316D5B0", VA = "0x18316EFB0")]
		public void RemoveGroup(GameObject target)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x316F0D0", Offset = "0x316D6D0", VA = "0x18316F0D0")]
		private void DoSpawn()
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x316F210", Offset = "0x316D810", VA = "0x18316F210")]
		private void ActivateTarget(GameObject target)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x316F750", Offset = "0x316DD50", VA = "0x18316F750")]
		public void CleanGroups()
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x316F940", Offset = "0x316DF40", VA = "0x18316F940")]
		public void CleanTargets()
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x316FB30", Offset = "0x316E130", VA = "0x18316FB30")]
		public void AddTarget(GameObject eachChild)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
		public void SetNewParent(GameObject target)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x5F2110", Offset = "0x5F0710", VA = "0x1805F2110")]
		public void SetChangeParent(bool value)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x316FC40", Offset = "0x316E240", VA = "0x18316FC40")]
		public CollisionTriggerActivator()
		{
		}

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _selfDestruct;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _useTimeout;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _activateTimeout;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask _layerMask;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _useTagWhitelist;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<string> _tagWhiteList;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _useTagBlacklist;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<string> _tagBlackList;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _randomVelocityAmount;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _lifespan;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[FormerlySerializedAs("_reParent")]
		private bool _changeParent;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _newParent;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[FormerlySerializedAs("_rigidGroups")]
		private List<GameObject> _targetGroups;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _destroyGroups;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[FormerlySerializedAs("_rigids")]
		private List<GameObject> _targets;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x78")]
		[FormerlySerializedAs("_spawnPrefab")]
		[SerializeField]
		private bool _spawnPrefabs;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<SpawnDefinition> _spawnDefinitions;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UnityEvent _onTriggerEvent;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _debugActivation;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x98")]
		private Collider _collider;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0xA0")]
		private float _enabledTime;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xA4")]
		private float _activationProcessStarted;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0xA8")]
		private bool _completedLifespan;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0xB0")]
		private readonly List<GameObject> _activatedTargets;
	}
}
