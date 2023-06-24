using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Multiplayer
{
	// Token: 0x0200028D RID: 653
	[Token(Token = "0x200028D")]
	[AddComponentMenu("Sons/Construction/FreeFormSystemNetworkProxy - Client")]
	public class FreeFormSystemNetworkProxyClient : FreeFormSystemNetworkProxyBase
	{
		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060013DE RID: 5086 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000439")]
		public static LocallyAnticipatedStructures LocallyAnticipatedStructures
		{
			[Token(Token = "0x60013DD")]
			[Address(RVA = "0x2DE1270", Offset = "0x2DDF870", VA = "0x182DE1270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013DE")]
			[Address(RVA = "0x2DE12B0", Offset = "0x2DDF8B0", VA = "0x182DE12B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013DF")]
		[Address(RVA = "0x2DE1340", Offset = "0x2DDF940", VA = "0x182DE1340")]
		private void Awake()
		{
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E0")]
		[Address(RVA = "0x2DE1880", Offset = "0x2DDFE80", VA = "0x182DE1880")]
		private void OnDestroy()
		{
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E1")]
		[Address(RVA = "0x2DE1A10", Offset = "0x2DE0010", VA = "0x182DE1A10")]
		private void LateUpdate()
		{
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E2")]
		[Address(RVA = "0x2DE1BC0", Offset = "0x2DE01C0", VA = "0x182DE1BC0")]
		private void OnFinishedLoadingMainScene(object o)
		{
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E3")]
		[Address(RVA = "0x2DE1D50", Offset = "0x2DE0350", VA = "0x182DE1D50")]
		private static void RequestAllStructuresData()
		{
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E4")]
		[Address(RVA = "0x2DE1E30", Offset = "0x2DE0430", VA = "0x182DE1E30")]
		public void SendPlaceActionData(IConstructionModule module, TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E5")]
		[Address(RVA = "0x2DE2050", Offset = "0x2DE0650", VA = "0x182DE2050", Slot = "304")]
		public override void OnEvent(FreeFormStructureCreated evnt)
		{
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E6")]
		[Address(RVA = "0x2DE24E0", Offset = "0x2DE0AE0", VA = "0x182DE24E0", Slot = "322")]
		public override void OnEvent(FreeFormStructureRejected evnt)
		{
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E7")]
		[Address(RVA = "0x2DE2610", Offset = "0x2DE0C10", VA = "0x182DE2610", Slot = "306")]
		public override void OnEvent(FreeFormStructureEditedTransform evnt)
		{
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E8")]
		[Address(RVA = "0x2DE28F0", Offset = "0x2DE0EF0", VA = "0x182DE28F0", Slot = "309")]
		public override void OnEvent(FreeFormStructureEditedElements evnt)
		{
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E9")]
		[Address(RVA = "0x2DE2BD0", Offset = "0x2DE11D0", VA = "0x182DE2BD0", Slot = "310")]
		public override void OnEvent(FreeFormStructureEditedLinks evnt)
		{
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013EA")]
		[Address(RVA = "0x2DE2EB0", Offset = "0x2DE14B0", VA = "0x182DE2EB0", Slot = "308")]
		public override void OnEvent(FreeFormStructureCascadeRepositionSupported evnt)
		{
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013EB")]
		[Address(RVA = "0x2DE30C0", Offset = "0x2DE16C0", VA = "0x182DE30C0", Slot = "305")]
		public override void OnEvent(FreeFormStructureDestroyed evnt)
		{
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013EC")]
		[Address(RVA = "0x2DE33B0", Offset = "0x2DE19B0", VA = "0x182DE33B0", Slot = "362")]
		public override void OnEvent(FreeFormStructureCreationValidated evnt)
		{
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013ED")]
		[Address(RVA = "0x2DE3500", Offset = "0x2DE1B00", VA = "0x182DE3500", Slot = "365")]
		public override void OnEvent(FreeFormStructureDamagedStatus evnt)
		{
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x2DE3770", Offset = "0x2DE1D70", VA = "0x182DE3770")]
		private ConstructionManager GetOrFetchConstructionManager()
		{
			return null;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013EF")]
		[Address(RVA = "0x2DE39C0", Offset = "0x2DE1FC0", VA = "0x182DE39C0")]
		private void OnBlobSyncDeserialize()
		{
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F0")]
		[Address(RVA = "0x2DE39D0", Offset = "0x2DE1FD0", VA = "0x182DE39D0")]
		public void RegisterCommand(FreeFormStructureCommand command)
		{
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F1")]
		[Address(RVA = "0x2DE3AA0", Offset = "0x2DE20A0", VA = "0x182DE3AA0")]
		private void ExecuteCommand(FreeFormStructureCommand cmd, ConstructionManager manager)
		{
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F2")]
		[Address(RVA = "0x2DE3C60", Offset = "0x2DE2260", VA = "0x182DE3C60")]
		private void FlushDeprecatedCommands()
		{
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x2DE3FE0", Offset = "0x2DE25E0", VA = "0x182DE3FE0")]
		public FreeFormSystemNetworkProxyClient()
		{
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F4")]
		[Address(RVA = "0x2DE40D0", Offset = "0x2DE26D0", VA = "0x182DE40D0")]
		[CompilerGenerated]
		private void <Awake>g__PostInitCallback|10_0()
		{
		}

		// Token: 0x040009AC RID: 2476
		[Token(Token = "0x40009AC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Header("References")]
		private ElementProfileDatabase _elementDB;

		// Token: 0x040009AD RID: 2477
		[Token(Token = "0x40009AD")]
		[FieldOffset(Offset = "0x50")]
		private readonly byte _blobChannel;

		// Token: 0x040009AE RID: 2478
		[Token(Token = "0x40009AE")]
		[FieldOffset(Offset = "0x51")]
		private bool _waitingForBlob;

		// Token: 0x040009AF RID: 2479
		[Token(Token = "0x40009AF")]
		[FieldOffset(Offset = "0x58")]
		private ConstructionManager _manager;

		// Token: 0x040009B0 RID: 2480
		[Token(Token = "0x40009B0")]
		[FieldOffset(Offset = "0x60")]
		private RuntimeStructureDatabase.VersionControllerManual _versionController;

		// Token: 0x040009B1 RID: 2481
		[Token(Token = "0x40009B1")]
		[FieldOffset(Offset = "0x68")]
		private List<FreeFormStructureCommand> _commands;
	}
}
