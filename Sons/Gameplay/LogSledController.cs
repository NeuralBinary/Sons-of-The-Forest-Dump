using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Bolt;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Crafting.Structures;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x02000746 RID: 1862
	[Token(Token = "0x2000746")]
	[AddComponentMenu("Sons/Gameplay/LogSledController")]
	public class LogSledController : EntityBehaviour<IScrewStructureWithStorageState>
	{
		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060031E7 RID: 12775 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
		// (set) Token: 0x060031E8 RID: 12776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067F")]
		public bool IsClientProxy
		{
			[Token(Token = "0x60031E7")]
			[Address(RVA = "0x2875120", Offset = "0x2873720", VA = "0x182875120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60031E8")]
			[Address(RVA = "0x2875130", Offset = "0x2873730", VA = "0x182875130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060031E9 RID: 12777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000680")]
		public Transform PlayerAttachPoint
		{
			[Token(Token = "0x60031E9")]
			[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060031EA RID: 12778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000681")]
		public Transform PushPivot
		{
			[Token(Token = "0x60031EA")]
			[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060031EB RID: 12779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000682")]
		public LogSledControllerDefinition Definition
		{
			[Token(Token = "0x60031EB")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031EC")]
		[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
		public List<GameObject> GetPlayerIkArmTargets()
		{
			return null;
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031ED")]
		[Address(RVA = "0x3438560", Offset = "0x3436B60", VA = "0x183438560")]
		private void SetBushBreakerActive(bool value)
		{
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031EE")]
		[Address(RVA = "0x8DF490", Offset = "0x8DDA90", VA = "0x1808DF490")]
		public void SetDisconnectedCallback(Action<LogSledController> disconnectViaSled)
		{
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031EF")]
		[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
		public BoltEntity GetBoltEntity()
		{
			return null;
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F0")]
		[Address(RVA = "0x3493480", Offset = "0x3491A80", VA = "0x183493480")]
		private void OnValidate()
		{
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F1")]
		[Address(RVA = "0x3493490", Offset = "0x3491A90", VA = "0x183493490")]
		private void InitializeComponents()
		{
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F2")]
		[Address(RVA = "0x3493580", Offset = "0x3491B80", VA = "0x183493580")]
		private void OnEnable()
		{
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F3")]
		[Address(RVA = "0x34938D0", Offset = "0x3491ED0", VA = "0x1834938D0")]
		private void OnLogsLayoutItemGroupItemAdded(GameObject newItem)
		{
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F4")]
		[Address(RVA = "0x3493AD0", Offset = "0x34920D0", VA = "0x183493AD0")]
		private void OnLogsLayoutItemGroupRenderableLoaded(Transform newItemRenderableTransform)
		{
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F5")]
		private static void InitializeComponent<T>(GameObject gameObjectSource, ref T component) where T : Component
		{
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F6")]
		[Address(RVA = "0x3493BF0", Offset = "0x34921F0", VA = "0x183493BF0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F7")]
		[Address(RVA = "0x3493EC0", Offset = "0x34924C0", VA = "0x183493EC0", Slot = "17")]
		public override void Detached()
		{
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F8")]
		[Address(RVA = "0x3494150", Offset = "0x3492750", VA = "0x183494150")]
		private void OnNetworkTranslationControllerChanged(BoltEntity playerEntity)
		{
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F9")]
		[Address(RVA = "0x3494240", Offset = "0x3492840", VA = "0x183494240")]
		private void SetupClientProxy()
		{
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031FA")]
		[Address(RVA = "0x3494270", Offset = "0x3492870", VA = "0x183494270")]
		private void DisableOnNetworkProxy()
		{
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031FB")]
		[Address(RVA = "0x3494450", Offset = "0x3492A50", VA = "0x183494450")]
		private void OnDisable()
		{
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		[Token(Token = "0x60031FC")]
		[Address(RVA = "0x3494600", Offset = "0x3492C00", VA = "0x183494600")]
		public bool TriggerDisconnect(PlayerLogSledAction playerLogSledAction)
		{
			return default(bool);
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031FD")]
		[Address(RVA = "0x3494740", Offset = "0x3492D40", VA = "0x183494740")]
		private void ConnectPlayer()
		{
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031FE")]
		[Address(RVA = "0x3494900", Offset = "0x3492F00", VA = "0x183494900")]
		private void TryConnectInitialize()
		{
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031FF")]
		[Address(RVA = "0x3494A30", Offset = "0x3493030", VA = "0x183494A30")]
		private void SetStorageInteraction(bool value)
		{
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003200")]
		[Address(RVA = "0x3494BB0", Offset = "0x34931B0", VA = "0x183494BB0")]
		private void SetMainInteraction(bool value)
		{
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003201")]
		[Address(RVA = "0x3494D90", Offset = "0x3493390", VA = "0x183494D90")]
		private void DisconnectPlayer()
		{
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003202")]
		[Address(RVA = "0x3495050", Offset = "0x3493650", VA = "0x183495050")]
		private void TryDisconnectCleanup()
		{
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003203")]
		[Address(RVA = "0x3495380", Offset = "0x3493980", VA = "0x183495380")]
		private void DisconnectLocalPlayerIk()
		{
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003204")]
		[Address(RVA = "0x3494740", Offset = "0x3492D40", VA = "0x183494740")]
		private void OnInteraction()
		{
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003205")]
		[Address(RVA = "0x3495490", Offset = "0x3493A90", VA = "0x183495490")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003206")]
		[Address(RVA = "0x34955F0", Offset = "0x3493BF0", VA = "0x1834955F0")]
		private void UpdateAverageSpeed()
		{
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003207")]
		[Address(RVA = "0x3495710", Offset = "0x3493D10", VA = "0x183495710")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003208")]
		[Address(RVA = "0x34957D0", Offset = "0x3493DD0", VA = "0x1834957D0")]
		private void UpdateNetworkConnection()
		{
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x0000F210 File Offset: 0x0000D410
		[Token(Token = "0x6003209")]
		[Address(RVA = "0x34959A0", Offset = "0x3493FA0", VA = "0x1834959A0")]
		private bool IsOfflineOrConnectedToPlayer()
		{
			return default(bool);
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600320A")]
		[Address(RVA = "0x3495AE0", Offset = "0x34940E0", VA = "0x183495AE0")]
		private void CheckFlipFixer()
		{
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x0000F228 File Offset: 0x0000D428
		[Token(Token = "0x600320B")]
		[Address(RVA = "0x3495FE0", Offset = "0x34945E0", VA = "0x183495FE0")]
		private bool IsFlipped()
		{
			return default(bool);
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x0000F240 File Offset: 0x0000D440
		[Token(Token = "0x600320C")]
		[Address(RVA = "0x22711D0", Offset = "0x226F7D0", VA = "0x1822711D0")]
		private bool IsLocalPlayerConnected()
		{
			return default(bool);
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x0000F258 File Offset: 0x0000D458
		[Token(Token = "0x600320D")]
		[Address(RVA = "0x3496130", Offset = "0x3494730", VA = "0x183496130")]
		private bool IsPlayerConnected()
		{
			return default(bool);
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x0000F270 File Offset: 0x0000D470
		[Token(Token = "0x600320E")]
		[Address(RVA = "0x3496150", Offset = "0x3494750", VA = "0x183496150")]
		private bool IsNetWorkPlayerConnected()
		{
			return default(bool);
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600320F")]
		[Address(RVA = "0x34961D0", Offset = "0x34947D0", VA = "0x1834961D0")]
		private void UpdateNetworkTranslationControl()
		{
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003210")]
		[Address(RVA = "0x3496490", Offset = "0x3494A90", VA = "0x183496490")]
		private void SetToKinematic(bool shouldBeKinematic)
		{
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003211")]
		[Address(RVA = "0x3496610", Offset = "0x3494C10", VA = "0x183496610")]
		private void UpdateBushBreaker()
		{
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x0000F288 File Offset: 0x0000D488
		[Token(Token = "0x6003212")]
		[Address(RVA = "0x3496660", Offset = "0x3494C60", VA = "0x183496660")]
		private static float CalculateAverageSpeed(Vector3 currentPosition, ref int positionHistoryIndex, ref Vector3[] positionHistory, int historySize, bool forceRefresh = false)
		{
			return 0f;
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		[Token(Token = "0x6003213")]
		[Address(RVA = "0x3496940", Offset = "0x3494F40", VA = "0x183496940")]
		private static float CalculateAverageOffsetMagnitude(Vector3[] positionHistory)
		{
			return 0f;
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003214")]
		[Address(RVA = "0x3496AC0", Offset = "0x34950C0", VA = "0x183496AC0")]
		private void UpdateWeight()
		{
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		[Token(Token = "0x6003215")]
		[Address(RVA = "0x3496B50", Offset = "0x3495150", VA = "0x183496B50")]
		public float GetStorageFullFactor()
		{
			return 0f;
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003216")]
		[Address(RVA = "0x3496D90", Offset = "0x3495390", VA = "0x183496D90")]
		private void UpdatePosition()
		{
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		[Token(Token = "0x6003217")]
		[Address(RVA = "0x3497070", Offset = "0x3495670", VA = "0x183497070")]
		private Quaternion CalculateRotation(Transform rigidbodyTransform, Vector3 newPosition, Vector3 upVector)
		{
			return default(Quaternion);
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		[Token(Token = "0x6003218")]
		[Address(RVA = "0xAFF2A0", Offset = "0xAFD8A0", VA = "0x180AFF2A0")]
		public LayerMask GetGroundCollisionMask()
		{
			return default(LayerMask);
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003219")]
		[Address(RVA = "0x3497250", Offset = "0x3495850", VA = "0x183497250")]
		public GameObject SetupPlayerColliders(Transform parentTarget)
		{
			return null;
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600321A")]
		[Address(RVA = "0x34976A0", Offset = "0x3495CA0", VA = "0x1834976A0")]
		public void SetupIgnoredColliders(GameObject playerCollidersInstance, [Optional] GameObject baseGameObject)
		{
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600321B")]
		[Address(RVA = "0x34978B0", Offset = "0x3495EB0", VA = "0x1834978B0")]
		public void RefreshIgnoredColliders(GameObject playerCollidersInstance, [Optional] GameObject baseGameObject)
		{
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600321C")]
		[Address(RVA = "0x3497A80", Offset = "0x3496080", VA = "0x183497A80")]
		public void SetupPlayerProxyIk(BoltEntity playerEntity)
		{
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600321D")]
		[Address(RVA = "0x3497C60", Offset = "0x3496260", VA = "0x183497C60")]
		public void DisconnectPlayerProxyIk(BoltEntity playerEntity)
		{
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600321E")]
		[Address(RVA = "0x3497D50", Offset = "0x3496350", VA = "0x183497D50")]
		private void SetupPlayerProxyIk(BoltPlayerSetup boltPlayerSetup)
		{
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600321F")]
		[Address(RVA = "0x3497E70", Offset = "0x3496470", VA = "0x183497E70")]
		private void DisconnectPlayerProxyIk(BoltPlayerSetup boltPlayerSetup)
		{
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003220")]
		[Address(RVA = "0x3498040", Offset = "0x3496640", VA = "0x183498040")]
		public void SetupIkChains(IkTargetsController ikTargetsController)
		{
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003221")]
		[Address(RVA = "0x3498220", Offset = "0x3496820", VA = "0x183498220")]
		public void DisconnectIkChains(IkTargetsController ikTargetsController)
		{
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003222")]
		[Address(RVA = "0x3498410", Offset = "0x3496A10", VA = "0x183498410")]
		public LogSledController()
		{
		}

		// Token: 0x04002B10 RID: 11024
		[Token(Token = "0x4002B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LogSledControllerDefinition _definition;

		// Token: 0x04002B11 RID: 11025
		[Token(Token = "0x4002B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("_genericInteraction")]
		private GenericInteraction _mainInteraction;

		// Token: 0x04002B12 RID: 11026
		[Token(Token = "0x4002B12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _storageInteractions;

		// Token: 0x04002B13 RID: 11027
		[Token(Token = "0x4002B13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ScrewStructure _screwStructure;

		// Token: 0x04002B14 RID: 11028
		[Token(Token = "0x4002B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<GameObject> _playerIkArmTargets;

		// Token: 0x04002B15 RID: 11029
		[Token(Token = "0x4002B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _bushBreakerObject;

		// Token: 0x04002B16 RID: 11030
		[Token(Token = "0x4002B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BoltEntity _boltEntity;

		// Token: 0x04002B17 RID: 11031
		[Token(Token = "0x4002B17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[FormerlySerializedAs("_layoutItemGroup")]
		[SerializeField]
		private InWorldLayoutItemGroup _logsLayoutItemGroup;

		// Token: 0x04002B18 RID: 11032
		[Token(Token = "0x4002B18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private InWorldLayoutItemGroup _rocksLayoutItemGroup;

		// Token: 0x04002B19 RID: 11033
		[Token(Token = "0x4002B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private InWorldLayoutItemGroup _stonesLayoutItemGroup;

		// Token: 0x04002B1A RID: 11034
		[Token(Token = "0x4002B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[FormerlySerializedAs("_playerColliders")]
		[SerializeField]
		private GameObject _blockerColliders;

		// Token: 0x04002B1B RID: 11035
		[Token(Token = "0x4002B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private LayerMask _groundCollisionLayerMask;

		// Token: 0x04002B1C RID: 11036
		[Token(Token = "0x4002B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x04002B1D RID: 11037
		[Token(Token = "0x4002B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform _playerAttachPoint;

		// Token: 0x04002B1E RID: 11038
		[Token(Token = "0x4002B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Transform _pushPivot;

		// Token: 0x04002B1F RID: 11039
		[Token(Token = "0x4002B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04002B20 RID: 11040
		[Token(Token = "0x4002B20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _minMovementThreshold;

		// Token: 0x04002B21 RID: 11041
		[Token(Token = "0x4002B21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<GameObject> _enableWhenDisconnected;

		// Token: 0x04002B22 RID: 11042
		[Token(Token = "0x4002B22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _flipCollider;

		// Token: 0x04002B23 RID: 11043
		[Token(Token = "0x4002B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private List<MonoBehaviour> _disableOnNetworkProxy;

		// Token: 0x04002B24 RID: 11044
		[Token(Token = "0x4002B24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool _isLocalPlayerConnected;

		// Token: 0x04002B25 RID: 11045
		[Token(Token = "0x4002B25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _twistRotationAngle;

		// Token: 0x04002B26 RID: 11046
		[Token(Token = "0x4002B26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private PlayerLogSledAction _localPlayerController;

		// Token: 0x04002B27 RID: 11047
		[Token(Token = "0x4002B27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Quaternion _lerpedRotation;

		// Token: 0x04002B28 RID: 11048
		[Token(Token = "0x4002B28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 _lerpedPosition;

		// Token: 0x04002B29 RID: 11049
		[Token(Token = "0x4002B29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float _defaultRigidbodyMass;

		// Token: 0x04002B2A RID: 11050
		[Token(Token = "0x4002B2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool _isDisconnectingPlayer;

		// Token: 0x04002B2B RID: 11051
		[Token(Token = "0x4002B2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Action<LogSledController> _disconnectedCallback;

		// Token: 0x04002B2C RID: 11052
		[Token(Token = "0x4002B2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3[] _positionHistory;

		// Token: 0x04002B2D RID: 11053
		[Token(Token = "0x4002B2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int _positionHistoryIndex;

		// Token: 0x04002B2E RID: 11054
		[Token(Token = "0x4002B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private bool _bushBreakerHistoryInvalid;

		// Token: 0x04002B2F RID: 11055
		[Token(Token = "0x4002B2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x115")]
		private bool _setToKinematic;

		// Token: 0x04002B30 RID: 11056
		[Token(Token = "0x4002B30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x116")]
		private bool _debugDisableMinMovement;

		// Token: 0x04002B31 RID: 11057
		[Token(Token = "0x4002B31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x117")]
		private bool _debugDisablePositionUpdate;

		// Token: 0x04002B32 RID: 11058
		[Token(Token = "0x4002B32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float _yAngle;

		// Token: 0x04002B33 RID: 11059
		[Token(Token = "0x4002B33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private bool _isFlipped;

		// Token: 0x04002B34 RID: 11060
		[Token(Token = "0x4002B34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float _flippedStartTime;

		// Token: 0x04002B35 RID: 11061
		[Token(Token = "0x4002B35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private float _averageSpeed;

		// Token: 0x04002B36 RID: 11062
		[Token(Token = "0x4002B36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _completedConnectInitialize;

		// Token: 0x04002B37 RID: 11063
		[Token(Token = "0x4002B37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private GameObject _playerCollidersInstance;

		// Token: 0x04002B38 RID: 11064
		[Token(Token = "0x4002B38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private IkTargetsController _currentIkTargetsController;

		// Token: 0x04002B39 RID: 11065
		[Token(Token = "0x4002B39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private BoltPlayerSetup _currentBoltPlayerSetup;
	}
}
