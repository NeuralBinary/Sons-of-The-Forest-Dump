using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Animation;
using Sons.Areas;
using Sons.Crafting.Structures;
using Sons.Gameplay;
using Sons.Gameplay.CarryBody;
using Sons.Gameplay.GrabBag;
using Sons.Gameplay.Grabber;
using Sons.Physics;
using Sons.Wearable.Clothing;
using Sons.Wearable.Race;
using TheForest.Commons.Enums;
using TheForest.Items.Inventory;
using TheForest.Modding.Bridge.Interfaces;
using TheForest.Player.Data;
using TheForest.VR;
using UnityEngine;
using UnityEngine.Serialization;

namespace TheForest.Utils
{
	// Token: 0x020003C5 RID: 965
	[Token(Token = "0x20003C5")]
	public class LocalPlayer : MonoBehaviour, ILocalPlayer
	{
		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001981 RID: 6529 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001982 RID: 6530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000373")]
		public static Transform Transform
		{
			[Token(Token = "0x6001981")]
			[Address(RVA = "0x2CCE050", Offset = "0x2CCD050", VA = "0x182CCE050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001982")]
			[Address(RVA = "0x2CCF310", Offset = "0x2CCE310", VA = "0x182CCF310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001983 RID: 6531 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001984 RID: 6532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000374")]
		public static Rigidbody Rigidbody
		{
			[Token(Token = "0x6001983")]
			[Address(RVA = "0x2CCDD90", Offset = "0x2CCCD90", VA = "0x182CCDD90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001984")]
			[Address(RVA = "0x2CCEEF0", Offset = "0x2CCDEF0", VA = "0x182CCEEF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001985 RID: 6533 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001986 RID: 6534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000375")]
		public static GameObject GameObject
		{
			[Token(Token = "0x6001985")]
			[Address(RVA = "0x2CCD5D0", Offset = "0x2CCC5D0", VA = "0x182CCD5D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001986")]
			[Address(RVA = "0x2CCE730", Offset = "0x2CCD730", VA = "0x182CCE730")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001988 RID: 6536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000376")]
		public static GameObject PlayerBase
		{
			[Token(Token = "0x6001987")]
			[Address(RVA = "0x2CCDC10", Offset = "0x2CCCC10", VA = "0x182CCDC10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001988")]
			[Address(RVA = "0x2CCECB0", Offset = "0x2CCDCB0", VA = "0x182CCECB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600198A RID: 6538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000377")]
		private static Transform HeadTr
		{
			[Token(Token = "0x6001989")]
			[Address(RVA = "0x2CCD710", Offset = "0x2CCC710", VA = "0x182CCD710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600198A")]
			[Address(RVA = "0x2CCE910", Offset = "0x2CCD910", VA = "0x182CCE910")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x0600198B RID: 6539 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600198C RID: 6540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000378")]
		public static PlayerInventory Inventory
		{
			[Token(Token = "0x600198B")]
			[Address(RVA = "0x2CCD920", Offset = "0x2CCC920", VA = "0x182CCD920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600198C")]
			[Address(RVA = "0x2CCEAF0", Offset = "0x2CCDAF0", VA = "0x182CCEAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600198E RID: 6542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000379")]
		public static PlayerRaceSystem RaceSystem
		{
			[Token(Token = "0x600198D")]
			[Address(RVA = "0x2CCDD10", Offset = "0x2CCCD10", VA = "0x182CCDD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600198E")]
			[Address(RVA = "0x2CCEE30", Offset = "0x2CCDE30", VA = "0x182CCEE30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001990 RID: 6544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037A")]
		public static PlayerClothingSystem ClothingSystem
		{
			[Token(Token = "0x600198F")]
			[Address(RVA = "0x2CCD450", Offset = "0x2CCC450", VA = "0x182CCD450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001990")]
			[Address(RVA = "0x2CCE610", Offset = "0x2CCD610", VA = "0x182CCE610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001992 RID: 6546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037B")]
		public static StructureCraftingSystem StructureCraftingSystem
		{
			[Token(Token = "0x6001991")]
			[Address(RVA = "0x2CCDFD0", Offset = "0x2CCCFD0", VA = "0x182CCDFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001992")]
			[Address(RVA = "0x2CCF250", Offset = "0x2CCE250", VA = "0x182CCF250")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001994 RID: 6548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037C")]
		public static Vitals Vitals
		{
			[Token(Token = "0x6001993")]
			[Address(RVA = "0x2CCE090", Offset = "0x2CCD090", VA = "0x182CCE090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001994")]
			[Address(RVA = "0x2CCF370", Offset = "0x2CCE370", VA = "0x182CCF370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001996 RID: 6550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037D")]
		public static GameObject SpecialActions
		{
			[Token(Token = "0x6001995")]
			[Address(RVA = "0x2CCDED0", Offset = "0x2CCCED0", VA = "0x182CCDED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001996")]
			[Address(RVA = "0x2CCF0D0", Offset = "0x2CCE0D0", VA = "0x182CCF0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001998 RID: 6552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037E")]
		public static GameObject SpecialItems
		{
			[Token(Token = "0x6001997")]
			[Address(RVA = "0x2CCDF10", Offset = "0x2CCCF10", VA = "0x182CCDF10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001998")]
			[Address(RVA = "0x2CCF130", Offset = "0x2CCE130", VA = "0x182CCF130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001999 RID: 6553 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600199A RID: 6554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037F")]
		public static Transform MainCamTr
		{
			[Token(Token = "0x6001999")]
			[Address(RVA = "0x2CCDB50", Offset = "0x2CCCB50", VA = "0x182CCDB50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600199A")]
			[Address(RVA = "0x2CCEB90", Offset = "0x2CCDB90", VA = "0x182CCEB90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600199C RID: 6556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000380")]
		public static Camera MainCam
		{
			[Token(Token = "0x600199B")]
			[Address(RVA = "0x2CCDB90", Offset = "0x2CCCB90", VA = "0x182CCDB90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600199C")]
			[Address(RVA = "0x2CCEBF0", Offset = "0x2CCDBF0", VA = "0x182CCEBF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600199E RID: 6558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000381")]
		public static Camera InventoryCam
		{
			[Token(Token = "0x600199D")]
			[Address(RVA = "0x2CCD8A0", Offset = "0x2CCC8A0", VA = "0x182CCD8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600199E")]
			[Address(RVA = "0x2CCEA30", Offset = "0x2CCDA30", VA = "0x182CCEA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019A0 RID: 6560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000382")]
		public static camFollowHead CamFollowHead
		{
			[Token(Token = "0x600199F")]
			[Address(RVA = "0x2CCD390", Offset = "0x2CCC390", VA = "0x182CCD390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019A0")]
			[Address(RVA = "0x2CCE4F0", Offset = "0x2CCD4F0", VA = "0x182CCE4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019A2 RID: 6562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000383")]
		public static Animator Animator
		{
			[Token(Token = "0x60019A1")]
			[Address(RVA = "0x2CCD350", Offset = "0x2CCC350", VA = "0x182CCD350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019A2")]
			[Address(RVA = "0x2CCE490", Offset = "0x2CCD490", VA = "0x182CCE490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019A4 RID: 6564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000384")]
		public static PlayerAnimatorControl AnimControl
		{
			[Token(Token = "0x60019A3")]
			[Address(RVA = "0x2CCD2D0", Offset = "0x2CCC2D0", VA = "0x182CCD2D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019A4")]
			[Address(RVA = "0x2CCE3D0", Offset = "0x2CCD3D0", VA = "0x182CCE3D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019A6 RID: 6566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000385")]
		public static Grabber Grabber
		{
			[Token(Token = "0x60019A5")]
			[Address(RVA = "0x2CCD690", Offset = "0x2CCC690", VA = "0x182CCD690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019A6")]
			[Address(RVA = "0x2CCE850", Offset = "0x2CCD850", VA = "0x182CCE850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019A8 RID: 6568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000386")]
		public static PlayerSfx Sfx
		{
			[Token(Token = "0x60019A7")]
			[Address(RVA = "0x2CCDE90", Offset = "0x2CCCE90", VA = "0x182CCDE90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019A8")]
			[Address(RVA = "0x2CCF070", Offset = "0x2CCE070", VA = "0x182CCF070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000387")]
		public static PlayerStats Stats
		{
			[Token(Token = "0x60019A9")]
			[Address(RVA = "0x2CCDF90", Offset = "0x2CCCF90", VA = "0x182CCDF90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019AA")]
			[Address(RVA = "0x2CCF1F0", Offset = "0x2CCE1F0", VA = "0x182CCF1F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019AC RID: 6572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000388")]
		public static FirstPersonCharacter FpCharacter
		{
			[Token(Token = "0x60019AB")]
			[Address(RVA = "0x2CCD590", Offset = "0x2CCC590", VA = "0x182CCD590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019AC")]
			[Address(RVA = "0x2CCE6D0", Offset = "0x2CCD6D0", VA = "0x182CCE6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019AE RID: 6574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000389")]
		public static SimpleMouseRotator CamRotator
		{
			[Token(Token = "0x60019AD")]
			[Address(RVA = "0x2CCD3D0", Offset = "0x2CCC3D0", VA = "0x182CCD3D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019AE")]
			[Address(RVA = "0x2CCE550", Offset = "0x2CCD550", VA = "0x182CCE550")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060019AF RID: 6575 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019B0 RID: 6576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038A")]
		public static SimpleMouseRotator MainRotator
		{
			[Token(Token = "0x60019AF")]
			[Address(RVA = "0x2CCDBD0", Offset = "0x2CCCBD0", VA = "0x182CCDBD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019B0")]
			[Address(RVA = "0x2CCEC50", Offset = "0x2CCDC50", VA = "0x182CCEC50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019B2 RID: 6578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038B")]
		public static playerScriptSetup ScriptSetup
		{
			[Token(Token = "0x60019B1")]
			[Address(RVA = "0x2CCDE50", Offset = "0x2CCCE50", VA = "0x182CCDE50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019B2")]
			[Address(RVA = "0x2CCF010", Offset = "0x2CCE010", VA = "0x182CCF010")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060019B3 RID: 6579 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019B4 RID: 6580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038C")]
		public static playerHitReactions HitReactions
		{
			[Token(Token = "0x60019B3")]
			[Address(RVA = "0x2CCD750", Offset = "0x2CCC750", VA = "0x182CCD750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019B4")]
			[Address(RVA = "0x2CCE970", Offset = "0x2CCD970", VA = "0x182CCE970")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060019B5 RID: 6581 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019B6 RID: 6582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038D")]
		public static WaterLevelSensor WaterLevelSensor
		{
			[Token(Token = "0x60019B5")]
			[Address(RVA = "0x2CCE110", Offset = "0x2CCD110", VA = "0x182CCE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019B6")]
			[Address(RVA = "0x2CCF430", Offset = "0x2CCE430", VA = "0x182CCF430")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060019B7 RID: 6583 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019B8 RID: 6584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038E")]
		public static BoltEntity Entity
		{
			[Token(Token = "0x60019B7")]
			[Address(RVA = "0x2CCD550", Offset = "0x2CCC550", VA = "0x182CCD550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019B8")]
			[Address(RVA = "0x2CCE670", Offset = "0x2CCD670", VA = "0x182CCE670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019BA RID: 6586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038F")]
		public static IPlayerState State
		{
			[Token(Token = "0x60019B9")]
			[Address(RVA = "0x2CCDF50", Offset = "0x2CCCF50", VA = "0x182CCDF50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019BA")]
			[Address(RVA = "0x2CCF190", Offset = "0x2CCE190", VA = "0x182CCF190")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060019BB RID: 6587 RVA: 0x00007C80 File Offset: 0x00005E80
		[Token(Token = "0x17000390")]
		public static bool InWater
		{
			[Token(Token = "0x60019BB")]
			[Address(RVA = "0x2CCD7D0", Offset = "0x2CCC7D0", VA = "0x182CCD7D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019BD RID: 6589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000391")]
		public static SkinnedMeshRenderer AnimatedBook
		{
			[Token(Token = "0x60019BC")]
			[Address(RVA = "0x2CCD310", Offset = "0x2CCC310", VA = "0x182CCD310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019BD")]
			[Address(RVA = "0x2CCE430", Offset = "0x2CCD430", VA = "0x182CCE430")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000392")]
		public static GameObject GreebleRoot
		{
			[Token(Token = "0x60019BE")]
			[Address(RVA = "0x2CCD6D0", Offset = "0x2CCC6D0", VA = "0x182CCD6D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019BF")]
			[Address(RVA = "0x2CCE8B0", Offset = "0x2CCD8B0", VA = "0x182CCE8B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000393")]
		public static GameObject PlayerDeadCam
		{
			[Token(Token = "0x60019C0")]
			[Address(RVA = "0x2CCDC50", Offset = "0x2CCCC50", VA = "0x182CCDC50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019C1")]
			[Address(RVA = "0x2CCED10", Offset = "0x2CCDD10", VA = "0x182CCED10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000394")]
		public static Transform WatchTrVR
		{
			[Token(Token = "0x60019C2")]
			[Address(RVA = "0x2CCE0D0", Offset = "0x2CCD0D0", VA = "0x182CCE0D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019C3")]
			[Address(RVA = "0x2CCF3D0", Offset = "0x2CCE3D0", VA = "0x182CCF3D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000395")]
		public static Transform WorldInventoryPosition
		{
			[Token(Token = "0x60019C4")]
			[Address(RVA = "0x2CCE150", Offset = "0x2CCD150", VA = "0x182CCE150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019C5")]
			[Address(RVA = "0x2CCF490", Offset = "0x2CCE490", VA = "0x182CCF490")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000396")]
		public static IkTargetsController IkTargetsController
		{
			[Token(Token = "0x60019C6")]
			[Address(RVA = "0x2CCD790", Offset = "0x2CCC790", VA = "0x182CCD790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019C7")]
			[Address(RVA = "0x2CCE9D0", Offset = "0x2CCD9D0", VA = "0x182CCE9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000397")]
		public static UnderfootSurfaceDetector SurfaceDetector
		{
			[Token(Token = "0x60019C8")]
			[Address(RVA = "0x2CCE010", Offset = "0x2CCD010", VA = "0x182CCE010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019C9")]
			[Address(RVA = "0x2CCF2B0", Offset = "0x2CCE2B0", VA = "0x182CCF2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000398")]
		public static VRPlayerAdapter vrAdapter
		{
			[Token(Token = "0x60019CA")]
			[Address(RVA = "0x2CCE190", Offset = "0x2CCD190", VA = "0x182CCE190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019CB")]
			[Address(RVA = "0x2CCF4F0", Offset = "0x2CCE4F0", VA = "0x182CCF4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000399")]
		public static VRPlayerControl vrPlayerControl
		{
			[Token(Token = "0x60019CC")]
			[Address(RVA = "0x2CCE1D0", Offset = "0x2CCD1D0", VA = "0x182CCE1D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019CD")]
			[Address(RVA = "0x2CCF550", Offset = "0x2CCE550", VA = "0x182CCF550")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039A")]
		public static CameraMouseEvents InventoryMouseEventsVR
		{
			[Token(Token = "0x60019CE")]
			[Address(RVA = "0x2CCD8E0", Offset = "0x2CCC8E0", VA = "0x182CCD8E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019CF")]
			[Address(RVA = "0x2CCEA90", Offset = "0x2CCDA90", VA = "0x182CCEA90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039B")]
		public static LocalPlayer.SavedDataFields SavedData
		{
			[Token(Token = "0x60019D0")]
			[Address(RVA = "0x2CCDE10", Offset = "0x2CCCE10", VA = "0x182CCDE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019D1")]
			[Address(RVA = "0x2CCEFB0", Offset = "0x2CCDFB0", VA = "0x182CCEFB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039C")]
		public static PlayerStimuli PlayerStimuli
		{
			[Token(Token = "0x60019D2")]
			[Address(RVA = "0x2CCDCD0", Offset = "0x2CCCCD0", VA = "0x182CCDCD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019D3")]
			[Address(RVA = "0x2CCEDD0", Offset = "0x2CCDDD0", VA = "0x182CCEDD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019D5 RID: 6613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039D")]
		public static IGrabBagInteractionReceiver GrabBagInteractionReceiver
		{
			[Token(Token = "0x60019D4")]
			[Address(RVA = "0x2CCD650", Offset = "0x2CCC650", VA = "0x182CCD650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019D5")]
			[Address(RVA = "0x2CCE7F0", Offset = "0x2CCD7F0", VA = "0x182CCE7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019D7 RID: 6615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039E")]
		public static GiveItemsController GiveItemsController
		{
			[Token(Token = "0x60019D6")]
			[Address(RVA = "0x2CCD610", Offset = "0x2CCC610", VA = "0x182CCD610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019D7")]
			[Address(RVA = "0x2CCE790", Offset = "0x2CCD790", VA = "0x182CCE790")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019D9 RID: 6617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039F")]
		public static ReceiveItemsInteractionTrigger ReceiveItemsInteractionTrigger
		{
			[Token(Token = "0x60019D8")]
			[Address(RVA = "0x2CCDD50", Offset = "0x2CCCD50", VA = "0x182CCDD50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019D9")]
			[Address(RVA = "0x2CCEE90", Offset = "0x2CCDE90", VA = "0x182CCEE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A0")]
		public static PlayerRobbyInteraction RobbyInteraction
		{
			[Token(Token = "0x60019DA")]
			[Address(RVA = "0x2CCDDD0", Offset = "0x2CCCDD0", VA = "0x182CCDDD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019DB")]
			[Address(RVA = "0x2CCEF50", Offset = "0x2CCDF50", VA = "0x182CCEF50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A1")]
		public static PlayerExpressions PlayerExpressions
		{
			[Token(Token = "0x60019DC")]
			[Address(RVA = "0x2CCDC90", Offset = "0x2CCCC90", VA = "0x182CCDC90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019DD")]
			[Address(RVA = "0x2CCED70", Offset = "0x2CCDD70", VA = "0x182CCED70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A2")]
		public static CarryBody CarryBody
		{
			[Token(Token = "0x60019DE")]
			[Address(RVA = "0x2CCD410", Offset = "0x2CCC410", VA = "0x182CCD410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019DF")]
			[Address(RVA = "0x2CCE5B0", Offset = "0x2CCD5B0", VA = "0x182CCE5B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x00007C98 File Offset: 0x00005E98
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A3")]
		public static bool IsConstructing
		{
			[Token(Token = "0x60019E0")]
			[Address(RVA = "0x2CCD960", Offset = "0x2CCC960", VA = "0x182CCD960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60019E1")]
			[Address(RVA = "0x2CCEB50", Offset = "0x2CCDB50", VA = "0x182CCEB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x00007CB0 File Offset: 0x00005EB0
		[Token(Token = "0x170003A4")]
		public static bool IsInCaves
		{
			[Token(Token = "0x60019E2")]
			[Address(RVA = "0x2CCD9A0", Offset = "0x2CCC9A0", VA = "0x182CCD9A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x00007CC8 File Offset: 0x00005EC8
		[Token(Token = "0x170003A5")]
		public static bool IsInEndgame
		{
			[Token(Token = "0x60019E3")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x00007CE0 File Offset: 0x00005EE0
		[Token(Token = "0x170003A6")]
		public static bool IsInOutsideWorld
		{
			[Token(Token = "0x60019E4")]
			[Address(RVA = "0x2CCDAA0", Offset = "0x2CCCAA0", VA = "0x182CCDAA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x00007CF8 File Offset: 0x00005EF8
		[Token(Token = "0x170003A7")]
		public static bool IsInWorld
		{
			[Token(Token = "0x60019E5")]
			[Address(RVA = "0x2CCDAE0", Offset = "0x2CCCAE0", VA = "0x182CCDAE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x00007D10 File Offset: 0x00005F10
		[Token(Token = "0x170003A8")]
		public static bool IsInInventory
		{
			[Token(Token = "0x60019E6")]
			[Address(RVA = "0x2CCD9E0", Offset = "0x2CCC9E0", VA = "0x182CCD9E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x00007D28 File Offset: 0x00005F28
		[Token(Token = "0x170003A9")]
		public static bool IsInMidAction
		{
			[Token(Token = "0x60019E7")]
			[Address(RVA = "0x2CCDA00", Offset = "0x2CCCA00", VA = "0x182CCDA00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x00007D40 File Offset: 0x00005F40
		// (set) Token: 0x060019E9 RID: 6633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AA")]
		public static bool AllowConstructions
		{
			[Token(Token = "0x60019E8")]
			[Address(RVA = "0x2CCD290", Offset = "0x2CCC290", VA = "0x182CCD290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60019E9")]
			[Address(RVA = "0x2CCE390", Offset = "0x2CCD390", VA = "0x182CCE390")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x00007D58 File Offset: 0x00005F58
		[Token(Token = "0x170003AB")]
		public static PlayerInventory.PlayerViews CurrentView
		{
			[Token(Token = "0x60019EA")]
			[Address(RVA = "0x2CCD490", Offset = "0x2CCC490", VA = "0x182CCD490")]
			get
			{
				return PlayerInventory.PlayerViews.Loading;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x00007D70 File Offset: 0x00005F70
		[Token(Token = "0x170003AC")]
		public static bool IsUnderwater
		{
			[Token(Token = "0x60019EB")]
			[Address(RVA = "0x2CCDB00", Offset = "0x2CCCB00", VA = "0x182CCDB00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060019EC RID: 6636 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060019ED RID: 6637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000E")]
		public static event Action OnEnableCallback
		{
			[Token(Token = "0x60019EC")]
			[Address(RVA = "0x2CCD1D0", Offset = "0x2CCC1D0", VA = "0x182CCD1D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019ED")]
			[Address(RVA = "0x2CCE2D0", Offset = "0x2CCD2D0", VA = "0x182CCE2D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060019EE RID: 6638 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060019EF RID: 6639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000F")]
		public static event Action OnDisableEvent
		{
			[Token(Token = "0x60019EE")]
			[Address(RVA = "0x2CCD110", Offset = "0x2CCC110", VA = "0x182CCD110")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019EF")]
			[Address(RVA = "0x2CCE210", Offset = "0x2CCD210", VA = "0x182CCE210")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F0")]
		[Address(RVA = "0x2CCC0C0", Offset = "0x2CCB0C0", VA = "0x182CCC0C0")]
		private void OnEnable()
		{
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F1")]
		[Address(RVA = "0x2CCC070", Offset = "0x2CCB070", VA = "0x182CCC070")]
		private void OnDisable()
		{
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F2")]
		[Address(RVA = "0x2CC8DE0", Offset = "0x2CC7DE0", VA = "0x182CC8DE0")]
		private void Awake()
		{
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F3")]
		[Address(RVA = "0x2CCA1C0", Offset = "0x2CC91C0", VA = "0x182CCA1C0")]
		public void Initialize()
		{
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F4")]
		[Address(RVA = "0x2CCB210", Offset = "0x2CCA210", VA = "0x182CCB210")]
		private void OnDestroy()
		{
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019F5")]
		[Address(RVA = "0x2CC9050", Offset = "0x2CC8050", VA = "0x182CC9050")]
		public static GameObject GetActiveBowObject()
		{
			return null;
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F6")]
		[Address(RVA = "0x2CCA160", Offset = "0x2CC9160", VA = "0x182CCA160")]
		private void InitModding()
		{
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F7")]
		[Address(RVA = "0x2CCC290", Offset = "0x2CCB290", VA = "0x182CCC290")]
		private void ResetModding()
		{
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00007D88 File Offset: 0x00005F88
		[Token(Token = "0x60019F8")]
		[Address(RVA = "0x2CC8BC0", Offset = "0x2CC7BC0", VA = "0x182CC8BC0", Slot = "4")]
		public bool AddItem(int itemId, int amount = 1000, bool preventAutoEquip = true)
		{
			return default(bool);
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F9")]
		[Address(RVA = "0x2CC8C40", Offset = "0x2CC7C40", VA = "0x182CC8C40", Slot = "5")]
		public void AddItemsByType(ItemTypes typeMask, int amount = 1000, bool preventAutoEquip = true)
		{
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019FA")]
		[Address(RVA = "0x2CC9640", Offset = "0x2CC8640", VA = "0x182CC9640", Slot = "6")]
		public void Goto(Transform target)
		{
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019FB")]
		[Address(RVA = "0x2CC9F60", Offset = "0x2CC8F60", VA = "0x182CC9F60", Slot = "7")]
		public void Goto(Vector3 position)
		{
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019FC")]
		[Address(RVA = "0x2CC9490", Offset = "0x2CC8490", VA = "0x182CC9490")]
		private void GotoCave(bool inCave)
		{
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019FD")]
		[Address(RVA = "0x2CC8E70", Offset = "0x2CC7E70", VA = "0x182CC8E70")]
		public static void CheckCaveForcedEnter(Vector3 targetPos)
		{
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019FE")]
		[Address(RVA = "0x2CC8FB0", Offset = "0x2CC7FB0", VA = "0x182CC8FB0")]
		public static void CheckCaveForcedEnter(AreaMask areaMask)
		{
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019FF")]
		[Address(RVA = "0x2CCCB00", Offset = "0x2CCBB00", VA = "0x182CCCB00")]
		public static void SetPositionAndRotation(Vector3 position, Quaternion rotation, bool teleported = false)
		{
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A00")]
		[Address(RVA = "0x2CCCBC0", Offset = "0x2CCBBC0", VA = "0x182CCCBC0")]
		public static void SetPosition(Vector3 position)
		{
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A01")]
		[Address(RVA = "0x2CCCC30", Offset = "0x2CCBC30", VA = "0x182CCCC30")]
		public static void SetRotation(Quaternion rotation)
		{
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A02")]
		[Address(RVA = "0x2CCC500", Offset = "0x2CCB500", VA = "0x182CCC500")]
		public static void SetMenuLock(bool enable, bool pauseGame = true)
		{
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A03")]
		[Address(RVA = "0x2CCC460", Offset = "0x2CCB460", VA = "0x182CCC460")]
		public static void SetLookRotation(Vector3 rotationValue)
		{
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A04")]
		[Address(RVA = "0x2CCC3B0", Offset = "0x2CCB3B0", VA = "0x182CCC3B0")]
		public static void SetLookRotation(Vector2 rotationValue)
		{
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A05")]
		[Address(RVA = "0x2CCC680", Offset = "0x2CCB680", VA = "0x182CCC680")]
		public static void SetOverrideMovement(Vector2 vector2, bool runningOverride)
		{
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A06")]
		[Address(RVA = "0x2CCCDE0", Offset = "0x2CCBDE0", VA = "0x182CCCDE0")]
		public static void TeleportTo(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A07")]
		[Address(RVA = "0x2CC9040", Offset = "0x2CC8040", VA = "0x182CC9040")]
		public static void EnablePhysicsProxies()
		{
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A08")]
		[Address(RVA = "0x2CC9030", Offset = "0x2CC8030", VA = "0x182CC9030")]
		public static void DisablePhysicsProxies()
		{
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A09")]
		[Address(RVA = "0x2CCC770", Offset = "0x2CCB770", VA = "0x182CCC770")]
		private static void SetPhysicsProxiesBlock(bool value)
		{
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A0A")]
		[Address(RVA = "0x2CCC2E0", Offset = "0x2CCB2E0", VA = "0x182CCC2E0")]
		public static void SetCurrentView(PlayerInventory.PlayerViews value)
		{
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00007DA0 File Offset: 0x00005FA0
		[Token(Token = "0x6001A0B")]
		[Address(RVA = "0x2CC92A0", Offset = "0x2CC82A0", VA = "0x182CC92A0")]
		public static Vector3 GetSteadyCamPos()
		{
			return default(Vector3);
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x2CCCC90", Offset = "0x2CCBC90", VA = "0x182CCCC90")]
		public static void SyncAnimationsToOtherPlayers(int layerIdx = -1)
		{
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A0D")]
		[Address(RVA = "0x2CCC110", Offset = "0x2CCB110", VA = "0x182CCC110")]
		public static void RequestPlayerMecanimSync()
		{
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A0E")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public LocalPlayer()
		{
		}

		// Token: 0x040018E5 RID: 6373
		[Token(Token = "0x40018E5")]
		[FieldOffset(Offset = "0x20")]
		[Header("Core")]
		public Transform _transform;

		// Token: 0x040018E6 RID: 6374
		[Token(Token = "0x40018E6")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody _rigidbody;

		// Token: 0x040018E7 RID: 6375
		[Token(Token = "0x40018E7")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _playerGO;

		// Token: 0x040018E8 RID: 6376
		[Token(Token = "0x40018E8")]
		[FieldOffset(Offset = "0x38")]
		public GameObject _playerBase;

		// Token: 0x040018E9 RID: 6377
		[Token(Token = "0x40018E9")]
		[FieldOffset(Offset = "0x40")]
		public Transform _headTr;

		// Token: 0x040018EA RID: 6378
		[Token(Token = "0x40018EA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PlayerInventory _inventory;

		// Token: 0x040018EB RID: 6379
		[Token(Token = "0x40018EB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PlayerRaceSystem _raceSystem;

		// Token: 0x040018EC RID: 6380
		[Token(Token = "0x40018EC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private PlayerClothingSystem _clothingSystem;

		// Token: 0x040018ED RID: 6381
		[Token(Token = "0x40018ED")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StructureCraftingSystem _structureCraftingSystem;

		// Token: 0x040018EE RID: 6382
		[Token(Token = "0x40018EE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vitals _vitals;

		// Token: 0x040018EF RID: 6383
		[Token(Token = "0x40018EF")]
		[FieldOffset(Offset = "0x70")]
		[FormerlySerializedAs("_receipeBook")]
		public Grabber _grabber;

		// Token: 0x040018F0 RID: 6384
		[Token(Token = "0x40018F0")]
		[FieldOffset(Offset = "0x78")]
		public PlayerSfx _sfx;

		// Token: 0x040018F1 RID: 6385
		[Token(Token = "0x40018F1")]
		[FieldOffset(Offset = "0x80")]
		public PlayerStats _stats;

		// Token: 0x040018F2 RID: 6386
		[Token(Token = "0x40018F2")]
		[FieldOffset(Offset = "0x88")]
		public GameObject _specialActions;

		// Token: 0x040018F3 RID: 6387
		[Token(Token = "0x40018F3")]
		[FieldOffset(Offset = "0x90")]
		public GameObject _specialItems;

		// Token: 0x040018F4 RID: 6388
		[Token(Token = "0x40018F4")]
		[FieldOffset(Offset = "0x98")]
		public GameObject _buildingModeAction;

		// Token: 0x040018F5 RID: 6389
		[Token(Token = "0x40018F5")]
		[FieldOffset(Offset = "0xA0")]
		public LocalPlayer.SavedDataFields _savedData;

		// Token: 0x040018F6 RID: 6390
		[Token(Token = "0x40018F6")]
		[FieldOffset(Offset = "0xA8")]
		private IGrabBagInteractionReceiver _grabBagInteractionReceiver;

		// Token: 0x040018F7 RID: 6391
		[Token(Token = "0x40018F7")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GiveItemsController _giveItemsController;

		// Token: 0x040018F8 RID: 6392
		[Token(Token = "0x40018F8")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ReceiveItemsInteractionTrigger _receiveItemsInteractionTrigger;

		// Token: 0x040018F9 RID: 6393
		[Token(Token = "0x40018F9")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CarryBody _carryBody;

		// Token: 0x040018FA RID: 6394
		[Token(Token = "0x40018FA")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private PlayerRobbyInteraction _robbyInteraction;

		// Token: 0x040018FB RID: 6395
		[Token(Token = "0x40018FB")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private PlayerExpressions _playerExpressions;

		// Token: 0x040018FC RID: 6396
		[Token(Token = "0x40018FC")]
		[FieldOffset(Offset = "0xD8")]
		public PlayerStimuli _playerStimuli;

		// Token: 0x040018FD RID: 6397
		[Token(Token = "0x40018FD")]
		[FieldOffset(Offset = "0xE0")]
		[Header("Cameras / Visuals / VR")]
		public Transform _mainCamTr;

		// Token: 0x040018FE RID: 6398
		[Token(Token = "0x40018FE")]
		[FieldOffset(Offset = "0xE8")]
		public Transform _mainCamTrVR;

		// Token: 0x040018FF RID: 6399
		[Token(Token = "0x40018FF")]
		[FieldOffset(Offset = "0xF0")]
		public Camera _mainCam;

		// Token: 0x04001900 RID: 6400
		[Token(Token = "0x4001900")]
		[FieldOffset(Offset = "0xF8")]
		public Camera _mainCamVR;

		// Token: 0x04001901 RID: 6401
		[Token(Token = "0x4001901")]
		[FieldOffset(Offset = "0x100")]
		public Camera _inventoryCam;

		// Token: 0x04001902 RID: 6402
		[Token(Token = "0x4001902")]
		[FieldOffset(Offset = "0x108")]
		public Camera _inventoryCamVR;

		// Token: 0x04001903 RID: 6403
		[Token(Token = "0x4001903")]
		[FieldOffset(Offset = "0x110")]
		public ImageEffectOptimizer _imageEffectOptimizer;

		// Token: 0x04001904 RID: 6404
		[Token(Token = "0x4001904")]
		[FieldOffset(Offset = "0x118")]
		public camFollowHead _camFollowHead;

		// Token: 0x04001905 RID: 6405
		[Token(Token = "0x4001905")]
		[FieldOffset(Offset = "0x120")]
		public SimpleMouseRotator _camRotator;

		// Token: 0x04001906 RID: 6406
		[Token(Token = "0x4001906")]
		[FieldOffset(Offset = "0x128")]
		public GameObject _PlayerDeadCam;

		// Token: 0x04001907 RID: 6407
		[Token(Token = "0x4001907")]
		[FieldOffset(Offset = "0x130")]
		public Transform _watchTrVR;

		// Token: 0x04001908 RID: 6408
		[Token(Token = "0x4001908")]
		[FieldOffset(Offset = "0x138")]
		[FormerlySerializedAs("_inventoryPositionVR")]
		public Transform _worldInventoryPosition;

		// Token: 0x04001909 RID: 6409
		[Token(Token = "0x4001909")]
		[FieldOffset(Offset = "0x140")]
		public VRPlayerAdapter _vrAdapter;

		// Token: 0x0400190A RID: 6410
		[Token(Token = "0x400190A")]
		[FieldOffset(Offset = "0x148")]
		public VRPlayerControl _vrPlayerControl;

		// Token: 0x0400190B RID: 6411
		[Token(Token = "0x400190B")]
		[FieldOffset(Offset = "0x150")]
		public CameraMouseEvents _inventoryMouseEventsVR;

		// Token: 0x0400190C RID: 6412
		[Token(Token = "0x400190C")]
		[FieldOffset(Offset = "0x158")]
		[Header("Animation")]
		public Animator _animator;

		// Token: 0x0400190D RID: 6413
		[Token(Token = "0x400190D")]
		[FieldOffset(Offset = "0x160")]
		public PlayerAnimatorControl _animControl;

		// Token: 0x0400190E RID: 6414
		[Token(Token = "0x400190E")]
		[FieldOffset(Offset = "0x168")]
		public FirstPersonCharacter _fpc;

		// Token: 0x0400190F RID: 6415
		[Token(Token = "0x400190F")]
		[FieldOffset(Offset = "0x170")]
		public playerScriptSetup _scriptSetup;

		// Token: 0x04001910 RID: 6416
		[Token(Token = "0x4001910")]
		[FieldOffset(Offset = "0x178")]
		public playerHitReactions _hitReactions;

		// Token: 0x04001911 RID: 6417
		[Token(Token = "0x4001911")]
		[FieldOffset(Offset = "0x180")]
		public SimpleMouseRotator _mainRotator;

		// Token: 0x04001912 RID: 6418
		[Token(Token = "0x4001912")]
		[FieldOffset(Offset = "0x188")]
		public SkinnedMeshRenderer _animatedBook;

		// Token: 0x04001913 RID: 6419
		[Token(Token = "0x4001913")]
		[FieldOffset(Offset = "0x190")]
		public IkTargetsController _ikTargetsController;

		// Token: 0x04001914 RID: 6420
		[Token(Token = "0x4001914")]
		[FieldOffset(Offset = "0x198")]
		[Header("Unsorted")]
		public WaterLevelSensor _waterLevelSensor;

		// Token: 0x04001915 RID: 6421
		[Token(Token = "0x4001915")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject _greebleRoot;

		// Token: 0x04001916 RID: 6422
		[Token(Token = "0x4001916")]
		[FieldOffset(Offset = "0x1A8")]
		public UnderfootSurfaceDetector _surfaceDetector;

		// Token: 0x04001917 RID: 6423
		[Token(Token = "0x4001917")]
		[FieldOffset(Offset = "0x0")]
		private static LocalPlayer _instance;

		// Token: 0x020003C6 RID: 966
		[Token(Token = "0x20003C6")]
		[Serializable]
		public class SavedDataFields
		{
			// Token: 0x06001A0F RID: 6671 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001A0F")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public SavedDataFields()
			{
			}

			// Token: 0x0400194B RID: 6475
			[Token(Token = "0x400194B")]
			[FieldOffset(Offset = "0x10")]
			public BoolData ReachedLowSanityThreshold;

			// Token: 0x0400194C RID: 6476
			[Token(Token = "0x400194C")]
			[FieldOffset(Offset = "0x18")]
			public BoolData ExitedEndgame;
		}
	}
}
