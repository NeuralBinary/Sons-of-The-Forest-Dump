using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Animation;
using Sons.Areas;
using Sons.Crafting.Structures;
using Sons.Gameplay;
using Sons.Gameplay.CarryBody;
using Sons.Gameplay.Cooking;
using Sons.Gameplay.GrabBag;
using Sons.Gameplay.Grabber;
using Sons.Physics;
using Sons.Weapon;
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
	// Token: 0x020003B7 RID: 951
	[Token(Token = "0x20003B7")]
	public class LocalPlayer : MonoBehaviour, ILocalPlayer
	{
		// Token: 0x1700037B RID: 891
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019BD RID: 6589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037B")]
		public static Transform Transform
		{
			[Token(Token = "0x60019BC")]
			[Address(RVA = "0x3297A00", Offset = "0x3296000", VA = "0x183297A00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019BD")]
			[Address(RVA = "0x3297A40", Offset = "0x3296040", VA = "0x183297A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037C")]
		public static Rigidbody Rigidbody
		{
			[Token(Token = "0x60019BE")]
			[Address(RVA = "0x3297AE0", Offset = "0x32960E0", VA = "0x183297AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019BF")]
			[Address(RVA = "0x3297B20", Offset = "0x3296120", VA = "0x183297B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037D")]
		public static GameObject GameObject
		{
			[Token(Token = "0x60019C0")]
			[Address(RVA = "0x3297BC0", Offset = "0x32961C0", VA = "0x183297BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019C1")]
			[Address(RVA = "0x3297C00", Offset = "0x3296200", VA = "0x183297C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037E")]
		public static GameObject PlayerBase
		{
			[Token(Token = "0x60019C2")]
			[Address(RVA = "0x3297CA0", Offset = "0x32962A0", VA = "0x183297CA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019C3")]
			[Address(RVA = "0x3297CE0", Offset = "0x32962E0", VA = "0x183297CE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037F")]
		private static Transform HeadTr
		{
			[Token(Token = "0x60019C4")]
			[Address(RVA = "0x3297D80", Offset = "0x3296380", VA = "0x183297D80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019C5")]
			[Address(RVA = "0x3297DC0", Offset = "0x32963C0", VA = "0x183297DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000380")]
		public static PlayerInventory Inventory
		{
			[Token(Token = "0x60019C6")]
			[Address(RVA = "0x3297E60", Offset = "0x3296460", VA = "0x183297E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019C7")]
			[Address(RVA = "0x3297EA0", Offset = "0x32964A0", VA = "0x183297EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000381")]
		public static PlayerRaceSystem RaceSystem
		{
			[Token(Token = "0x60019C8")]
			[Address(RVA = "0x3297F40", Offset = "0x3296540", VA = "0x183297F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019C9")]
			[Address(RVA = "0x3297F80", Offset = "0x3296580", VA = "0x183297F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000382")]
		public static PlayerClothingSystem ClothingSystem
		{
			[Token(Token = "0x60019CA")]
			[Address(RVA = "0x3298020", Offset = "0x3296620", VA = "0x183298020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019CB")]
			[Address(RVA = "0x3298060", Offset = "0x3296660", VA = "0x183298060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000383")]
		public static StructureCraftingSystem StructureCraftingSystem
		{
			[Token(Token = "0x60019CC")]
			[Address(RVA = "0x3298100", Offset = "0x3296700", VA = "0x183298100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019CD")]
			[Address(RVA = "0x3298140", Offset = "0x3296740", VA = "0x183298140")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000384")]
		public static CookingPot CookingSystem
		{
			[Token(Token = "0x60019CE")]
			[Address(RVA = "0x32981E0", Offset = "0x32967E0", VA = "0x1832981E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019CF")]
			[Address(RVA = "0x3298220", Offset = "0x3296820", VA = "0x183298220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000385")]
		public static Vitals Vitals
		{
			[Token(Token = "0x60019D0")]
			[Address(RVA = "0x32982C0", Offset = "0x32968C0", VA = "0x1832982C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019D1")]
			[Address(RVA = "0x3298300", Offset = "0x3296900", VA = "0x183298300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000386")]
		public static GameObject SpecialActions
		{
			[Token(Token = "0x60019D2")]
			[Address(RVA = "0x32983A0", Offset = "0x32969A0", VA = "0x1832983A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019D3")]
			[Address(RVA = "0x32983E0", Offset = "0x32969E0", VA = "0x1832983E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019D5 RID: 6613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000387")]
		public static GameObject SpecialItems
		{
			[Token(Token = "0x60019D4")]
			[Address(RVA = "0x3298480", Offset = "0x3296A80", VA = "0x183298480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019D5")]
			[Address(RVA = "0x32984C0", Offset = "0x3296AC0", VA = "0x1832984C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019D7 RID: 6615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000388")]
		public static Transform MainCamTr
		{
			[Token(Token = "0x60019D6")]
			[Address(RVA = "0x3298560", Offset = "0x3296B60", VA = "0x183298560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019D7")]
			[Address(RVA = "0x32985A0", Offset = "0x3296BA0", VA = "0x1832985A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019D9 RID: 6617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000389")]
		public static Camera MainCam
		{
			[Token(Token = "0x60019D8")]
			[Address(RVA = "0x3298640", Offset = "0x3296C40", VA = "0x183298640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019D9")]
			[Address(RVA = "0x3298680", Offset = "0x3296C80", VA = "0x183298680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038A")]
		public static Camera InventoryCam
		{
			[Token(Token = "0x60019DA")]
			[Address(RVA = "0x3298720", Offset = "0x3296D20", VA = "0x183298720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019DB")]
			[Address(RVA = "0x3298760", Offset = "0x3296D60", VA = "0x183298760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038B")]
		public static camFollowHead CamFollowHead
		{
			[Token(Token = "0x60019DC")]
			[Address(RVA = "0x3298800", Offset = "0x3296E00", VA = "0x183298800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019DD")]
			[Address(RVA = "0x3298840", Offset = "0x3296E40", VA = "0x183298840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038C")]
		public static Animator Animator
		{
			[Token(Token = "0x60019DE")]
			[Address(RVA = "0x32988E0", Offset = "0x3296EE0", VA = "0x1832988E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019DF")]
			[Address(RVA = "0x3298920", Offset = "0x3296F20", VA = "0x183298920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038D")]
		public static PlayerAnimatorControl AnimControl
		{
			[Token(Token = "0x60019E0")]
			[Address(RVA = "0x32989C0", Offset = "0x3296FC0", VA = "0x1832989C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019E1")]
			[Address(RVA = "0x3298A00", Offset = "0x3297000", VA = "0x183298A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038E")]
		public static Grabber Grabber
		{
			[Token(Token = "0x60019E2")]
			[Address(RVA = "0x3298AA0", Offset = "0x32970A0", VA = "0x183298AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019E3")]
			[Address(RVA = "0x3298AE0", Offset = "0x32970E0", VA = "0x183298AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019E5 RID: 6629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038F")]
		public static PlayerSfx Sfx
		{
			[Token(Token = "0x60019E4")]
			[Address(RVA = "0x3298B80", Offset = "0x3297180", VA = "0x183298B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019E5")]
			[Address(RVA = "0x3298BC0", Offset = "0x32971C0", VA = "0x183298BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019E7 RID: 6631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000390")]
		public static PlayerStats Stats
		{
			[Token(Token = "0x60019E6")]
			[Address(RVA = "0x3298C60", Offset = "0x3297260", VA = "0x183298C60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019E7")]
			[Address(RVA = "0x3298CA0", Offset = "0x32972A0", VA = "0x183298CA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019E9 RID: 6633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000391")]
		public static FirstPersonCharacter FpCharacter
		{
			[Token(Token = "0x60019E8")]
			[Address(RVA = "0x3298D40", Offset = "0x3297340", VA = "0x183298D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019E9")]
			[Address(RVA = "0x3298D80", Offset = "0x3297380", VA = "0x183298D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019EB RID: 6635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000392")]
		public static SimpleMouseRotator CamRotator
		{
			[Token(Token = "0x60019EA")]
			[Address(RVA = "0x3298E20", Offset = "0x3297420", VA = "0x183298E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019EB")]
			[Address(RVA = "0x3298E60", Offset = "0x3297460", VA = "0x183298E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019ED RID: 6637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000393")]
		public static SimpleMouseRotator MainRotator
		{
			[Token(Token = "0x60019EC")]
			[Address(RVA = "0x3298F00", Offset = "0x3297500", VA = "0x183298F00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019ED")]
			[Address(RVA = "0x3298F40", Offset = "0x3297540", VA = "0x183298F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019EF RID: 6639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000394")]
		public static playerScriptSetup ScriptSetup
		{
			[Token(Token = "0x60019EE")]
			[Address(RVA = "0x3298FE0", Offset = "0x32975E0", VA = "0x183298FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019EF")]
			[Address(RVA = "0x3299020", Offset = "0x3297620", VA = "0x183299020")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019F1 RID: 6641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000395")]
		public static playerHitReactions HitReactions
		{
			[Token(Token = "0x60019F0")]
			[Address(RVA = "0x32990C0", Offset = "0x32976C0", VA = "0x1832990C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019F1")]
			[Address(RVA = "0x3299100", Offset = "0x3297700", VA = "0x183299100")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000396")]
		public static WaterLevelSensor WaterLevelSensor
		{
			[Token(Token = "0x60019F2")]
			[Address(RVA = "0x32991A0", Offset = "0x32977A0", VA = "0x1832991A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019F3")]
			[Address(RVA = "0x32991E0", Offset = "0x32977E0", VA = "0x1832991E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019F5 RID: 6645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000397")]
		public static BoltEntity Entity
		{
			[Token(Token = "0x60019F4")]
			[Address(RVA = "0x3299280", Offset = "0x3297880", VA = "0x183299280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019F5")]
			[Address(RVA = "0x32992C0", Offset = "0x32978C0", VA = "0x1832992C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019F7 RID: 6647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000398")]
		public static IPlayerState State
		{
			[Token(Token = "0x60019F6")]
			[Address(RVA = "0x3299360", Offset = "0x3297960", VA = "0x183299360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019F7")]
			[Address(RVA = "0x32993A0", Offset = "0x32979A0", VA = "0x1832993A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x00007EF0 File Offset: 0x000060F0
		[Token(Token = "0x17000399")]
		public static bool InWater
		{
			[Token(Token = "0x60019F8")]
			[Address(RVA = "0x3299440", Offset = "0x3297A40", VA = "0x183299440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019FA RID: 6650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039A")]
		public static SkinnedMeshRenderer AnimatedBook
		{
			[Token(Token = "0x60019F9")]
			[Address(RVA = "0x3299570", Offset = "0x3297B70", VA = "0x183299570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019FA")]
			[Address(RVA = "0x32995B0", Offset = "0x3297BB0", VA = "0x1832995B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019FC RID: 6652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039B")]
		public static GameObject GreebleRoot
		{
			[Token(Token = "0x60019FB")]
			[Address(RVA = "0x3299650", Offset = "0x3297C50", VA = "0x183299650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019FC")]
			[Address(RVA = "0x3299690", Offset = "0x3297C90", VA = "0x183299690")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019FE RID: 6654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039C")]
		public static GameObject PlayerDeadCam
		{
			[Token(Token = "0x60019FD")]
			[Address(RVA = "0x3299730", Offset = "0x3297D30", VA = "0x183299730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019FE")]
			[Address(RVA = "0x3299770", Offset = "0x3297D70", VA = "0x183299770")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A00 RID: 6656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039D")]
		public static Transform WatchTrVR
		{
			[Token(Token = "0x60019FF")]
			[Address(RVA = "0x3299810", Offset = "0x3297E10", VA = "0x183299810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A00")]
			[Address(RVA = "0x3299850", Offset = "0x3297E50", VA = "0x183299850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A02 RID: 6658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039E")]
		public static Transform WorldInventoryPosition
		{
			[Token(Token = "0x6001A01")]
			[Address(RVA = "0x32998F0", Offset = "0x3297EF0", VA = "0x1832998F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A02")]
			[Address(RVA = "0x3299930", Offset = "0x3297F30", VA = "0x183299930")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A04 RID: 6660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039F")]
		public static IkTargetsController IkTargetsController
		{
			[Token(Token = "0x6001A03")]
			[Address(RVA = "0x32999D0", Offset = "0x3297FD0", VA = "0x1832999D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A04")]
			[Address(RVA = "0x3299A10", Offset = "0x3298010", VA = "0x183299A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A06 RID: 6662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A0")]
		public static UnderfootSurfaceDetector SurfaceDetector
		{
			[Token(Token = "0x6001A05")]
			[Address(RVA = "0x3299AB0", Offset = "0x32980B0", VA = "0x183299AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A06")]
			[Address(RVA = "0x3299AF0", Offset = "0x32980F0", VA = "0x183299AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A08 RID: 6664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A1")]
		public static VRPlayerAdapter vrAdapter
		{
			[Token(Token = "0x6001A07")]
			[Address(RVA = "0x3299B90", Offset = "0x3298190", VA = "0x183299B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A08")]
			[Address(RVA = "0x3299BD0", Offset = "0x32981D0", VA = "0x183299BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A0A RID: 6666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A2")]
		public static VRPlayerControl vrPlayerControl
		{
			[Token(Token = "0x6001A09")]
			[Address(RVA = "0x3299C70", Offset = "0x3298270", VA = "0x183299C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A0A")]
			[Address(RVA = "0x3299CB0", Offset = "0x32982B0", VA = "0x183299CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A0C RID: 6668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A3")]
		public static CameraMouseEvents InventoryMouseEventsVR
		{
			[Token(Token = "0x6001A0B")]
			[Address(RVA = "0x3299D50", Offset = "0x3298350", VA = "0x183299D50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A0C")]
			[Address(RVA = "0x3299D90", Offset = "0x3298390", VA = "0x183299D90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001A0D RID: 6669 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A0E RID: 6670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A4")]
		public static LocalPlayer.SavedDataFields SavedData
		{
			[Token(Token = "0x6001A0D")]
			[Address(RVA = "0x3299E30", Offset = "0x3298430", VA = "0x183299E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A0E")]
			[Address(RVA = "0x3299E70", Offset = "0x3298470", VA = "0x183299E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A5")]
		public static PlayerStimuli PlayerStimuli
		{
			[Token(Token = "0x6001A0F")]
			[Address(RVA = "0x3299F10", Offset = "0x3298510", VA = "0x183299F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A10")]
			[Address(RVA = "0x3299F50", Offset = "0x3298550", VA = "0x183299F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A12 RID: 6674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A6")]
		public static IGrabBagInteractionReceiver GrabBagInteractionReceiver
		{
			[Token(Token = "0x6001A11")]
			[Address(RVA = "0x3299FF0", Offset = "0x32985F0", VA = "0x183299FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A12")]
			[Address(RVA = "0x329A030", Offset = "0x3298630", VA = "0x18329A030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A14 RID: 6676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A7")]
		public static GiveItemsController GiveItemsController
		{
			[Token(Token = "0x6001A13")]
			[Address(RVA = "0x329A0D0", Offset = "0x32986D0", VA = "0x18329A0D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A14")]
			[Address(RVA = "0x329A110", Offset = "0x3298710", VA = "0x18329A110")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A16 RID: 6678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A8")]
		public static ReceiveItemsInteractionTrigger ReceiveItemsInteractionTrigger
		{
			[Token(Token = "0x6001A15")]
			[Address(RVA = "0x329A1B0", Offset = "0x32987B0", VA = "0x18329A1B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A16")]
			[Address(RVA = "0x329A1F0", Offset = "0x32987F0", VA = "0x18329A1F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A18 RID: 6680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A9")]
		public static PlayerRobbyInteraction RobbyInteraction
		{
			[Token(Token = "0x6001A17")]
			[Address(RVA = "0x329A290", Offset = "0x3298890", VA = "0x18329A290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A18")]
			[Address(RVA = "0x329A2D0", Offset = "0x32988D0", VA = "0x18329A2D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A1A RID: 6682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AA")]
		public static PlayerExpressions PlayerExpressions
		{
			[Token(Token = "0x6001A19")]
			[Address(RVA = "0x329A370", Offset = "0x3298970", VA = "0x18329A370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A1A")]
			[Address(RVA = "0x329A3B0", Offset = "0x32989B0", VA = "0x18329A3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A1C RID: 6684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AB")]
		public static CarryBody CarryBody
		{
			[Token(Token = "0x6001A1B")]
			[Address(RVA = "0x329A450", Offset = "0x3298A50", VA = "0x18329A450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A1C")]
			[Address(RVA = "0x329A490", Offset = "0x3298A90", VA = "0x18329A490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x00007F08 File Offset: 0x00006108
		// (set) Token: 0x06001A1E RID: 6686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AC")]
		public static bool IsConstructing
		{
			[Token(Token = "0x6001A1D")]
			[Address(RVA = "0x329A530", Offset = "0x3298B30", VA = "0x18329A530")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001A1E")]
			[Address(RVA = "0x329A570", Offset = "0x3298B70", VA = "0x18329A570")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x00007F20 File Offset: 0x00006120
		[Token(Token = "0x170003AD")]
		public static bool IsInCaves
		{
			[Token(Token = "0x6001A1F")]
			[Address(RVA = "0x2E1DD40", Offset = "0x2E1C340", VA = "0x182E1DD40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x00007F38 File Offset: 0x00006138
		[Token(Token = "0x170003AE")]
		public static bool IsInEndgame
		{
			[Token(Token = "0x6001A20")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x00007F50 File Offset: 0x00006150
		[Token(Token = "0x170003AF")]
		public static bool IsInOutsideWorld
		{
			[Token(Token = "0x6001A21")]
			[Address(RVA = "0x329A5B0", Offset = "0x3298BB0", VA = "0x18329A5B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x00007F68 File Offset: 0x00006168
		[Token(Token = "0x170003B0")]
		public static bool IsInWorld
		{
			[Token(Token = "0x6001A22")]
			[Address(RVA = "0x329A5F0", Offset = "0x3298BF0", VA = "0x18329A5F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x00007F80 File Offset: 0x00006180
		[Token(Token = "0x170003B1")]
		public static bool IsInInventory
		{
			[Token(Token = "0x6001A23")]
			[Address(RVA = "0x3150D00", Offset = "0x314F300", VA = "0x183150D00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001A24 RID: 6692 RVA: 0x00007F98 File Offset: 0x00006198
		[Token(Token = "0x170003B2")]
		public static bool IsInMidAction
		{
			[Token(Token = "0x6001A24")]
			[Address(RVA = "0x329A610", Offset = "0x3298C10", VA = "0x18329A610")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x00007FB0 File Offset: 0x000061B0
		[Token(Token = "0x170003B3")]
		public static bool BlockFullBodyInteraction
		{
			[Token(Token = "0x6001A25")]
			[Address(RVA = "0x329AA50", Offset = "0x3299050", VA = "0x18329AA50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001A26 RID: 6694 RVA: 0x00007FC8 File Offset: 0x000061C8
		// (set) Token: 0x06001A27 RID: 6695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B4")]
		public static bool AllowConstructions
		{
			[Token(Token = "0x6001A26")]
			[Address(RVA = "0x329AB80", Offset = "0x3299180", VA = "0x18329AB80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001A27")]
			[Address(RVA = "0x329ABC0", Offset = "0x32991C0", VA = "0x18329ABC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x00007FE0 File Offset: 0x000061E0
		[Token(Token = "0x170003B5")]
		public static PlayerInventory.PlayerViews CurrentView
		{
			[Token(Token = "0x6001A28")]
			[Address(RVA = "0x329AC00", Offset = "0x3299200", VA = "0x18329AC00")]
			get
			{
				return PlayerInventory.PlayerViews.Loading;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x00007FF8 File Offset: 0x000061F8
		[Token(Token = "0x170003B6")]
		public static bool IsUnderwater
		{
			[Token(Token = "0x6001A29")]
			[Address(RVA = "0x329AD20", Offset = "0x3299320", VA = "0x18329AD20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06001A2A RID: 6698 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001A2B RID: 6699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000011")]
		public static event Action OnEnableCallback
		{
			[Token(Token = "0x6001A2A")]
			[Address(RVA = "0x329AD70", Offset = "0x3299370", VA = "0x18329AD70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001A2B")]
			[Address(RVA = "0x329AE80", Offset = "0x3299480", VA = "0x18329AE80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06001A2C RID: 6700 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001A2D RID: 6701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000012")]
		public static event Action OnDisableEvent
		{
			[Token(Token = "0x6001A2C")]
			[Address(RVA = "0x329AF90", Offset = "0x3299590", VA = "0x18329AF90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001A2D")]
			[Address(RVA = "0x329B0A0", Offset = "0x32996A0", VA = "0x18329B0A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A2E")]
		[Address(RVA = "0x329B1B0", Offset = "0x32997B0", VA = "0x18329B1B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A2F")]
		[Address(RVA = "0x329B200", Offset = "0x3299800", VA = "0x18329B200")]
		private void OnDisable()
		{
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A30")]
		[Address(RVA = "0x329B250", Offset = "0x3299850", VA = "0x18329B250")]
		private void Awake()
		{
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A31")]
		[Address(RVA = "0x329B2E0", Offset = "0x32998E0", VA = "0x18329B2E0")]
		public void Initialize()
		{
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A32")]
		[Address(RVA = "0x329B890", Offset = "0x3299E90", VA = "0x18329B890")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A33")]
		[Address(RVA = "0x329BBB0", Offset = "0x329A1B0", VA = "0x18329BBB0")]
		public static GameObject GetActiveBowObject()
		{
			return null;
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A34")]
		[Address(RVA = "0x329BF40", Offset = "0x329A540", VA = "0x18329BF40")]
		private void InitModding()
		{
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A35")]
		[Address(RVA = "0x329BFD0", Offset = "0x329A5D0", VA = "0x18329BFD0")]
		private void ResetModding()
		{
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00008010 File Offset: 0x00006210
		[Token(Token = "0x6001A36")]
		[Address(RVA = "0x329C060", Offset = "0x329A660", VA = "0x18329C060", Slot = "4")]
		public bool AddItem(int itemId, int amount = 1000, bool preventAutoEquip = true)
		{
			return default(bool);
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A37")]
		[Address(RVA = "0x329C0E0", Offset = "0x329A6E0", VA = "0x18329C0E0", Slot = "5")]
		public void AddItemsByType(ItemTypes typeMask, int amount = 1000, bool preventAutoEquip = true)
		{
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A38")]
		[Address(RVA = "0x329C2E0", Offset = "0x329A8E0", VA = "0x18329C2E0", Slot = "6")]
		public void Goto(Transform target)
		{
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A39")]
		[Address(RVA = "0x329CFA0", Offset = "0x329B5A0", VA = "0x18329CFA0", Slot = "7")]
		public void Goto(Vector3 position)
		{
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A3A")]
		[Address(RVA = "0x329D220", Offset = "0x329B820", VA = "0x18329D220")]
		private void GotoCave(bool inCave)
		{
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A3B")]
		[Address(RVA = "0x329D3E0", Offset = "0x329B9E0", VA = "0x18329D3E0")]
		public static void CheckCaveForcedEnter(Vector3 targetPos)
		{
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A3C")]
		[Address(RVA = "0x329D610", Offset = "0x329BC10", VA = "0x18329D610")]
		public static void CheckCaveForcedEnter(AreaMask areaMask)
		{
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A3D")]
		[Address(RVA = "0x329D7A0", Offset = "0x329BDA0", VA = "0x18329D7A0")]
		public static void SetPositionAndRotation(Vector3 position, Quaternion rotation, bool teleported = false)
		{
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A3E")]
		[Address(RVA = "0x329D900", Offset = "0x329BF00", VA = "0x18329D900")]
		public static void SetPosition(Vector3 position)
		{
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A3F")]
		[Address(RVA = "0x329D9B0", Offset = "0x329BFB0", VA = "0x18329D9B0")]
		public static void SetRotation(Quaternion rotation)
		{
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A40")]
		[Address(RVA = "0x329DA50", Offset = "0x329C050", VA = "0x18329DA50")]
		public static void SetMenuLock(bool enable, bool pauseGame = true)
		{
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A41")]
		[Address(RVA = "0x329DC40", Offset = "0x329C240", VA = "0x18329DC40")]
		public static void SetLookRotation(Quaternion rotation)
		{
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A42")]
		[Address(RVA = "0x329DC70", Offset = "0x329C270", VA = "0x18329DC70")]
		public static void SetLookRotation(Vector3 rotationValue)
		{
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A43")]
		[Address(RVA = "0x329DC90", Offset = "0x329C290", VA = "0x18329DC90")]
		public static void SetLookRotation(Vector2 rotationValue)
		{
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A44")]
		[Address(RVA = "0x329DE20", Offset = "0x329C420", VA = "0x18329DE20")]
		public static void SetOverrideMovement(Vector2 vector2, bool runningOverride)
		{
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A45")]
		[Address(RVA = "0x329DF60", Offset = "0x329C560", VA = "0x18329DF60")]
		public static void TeleportTo(Vector3 position)
		{
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A46")]
		[Address(RVA = "0x329E190", Offset = "0x329C790", VA = "0x18329E190")]
		public static void TeleportTo(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A47")]
		[Address(RVA = "0x329E1F0", Offset = "0x329C7F0", VA = "0x18329E1F0")]
		public static void EnablePhysicsProxies()
		{
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A48")]
		[Address(RVA = "0x329E200", Offset = "0x329C800", VA = "0x18329E200")]
		public static void DisablePhysicsProxies()
		{
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A49")]
		[Address(RVA = "0x329E210", Offset = "0x329C810", VA = "0x18329E210")]
		private static void SetPhysicsProxiesBlock(bool value)
		{
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A4A")]
		[Address(RVA = "0x329E960", Offset = "0x329CF60", VA = "0x18329E960")]
		public static void SetCurrentView(PlayerInventory.PlayerViews value)
		{
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00008028 File Offset: 0x00006228
		[Token(Token = "0x6001A4B")]
		[Address(RVA = "0x329EA90", Offset = "0x329D090", VA = "0x18329EA90")]
		public static Vector3 GetSteadyCamPos()
		{
			return default(Vector3);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A4C")]
		[Address(RVA = "0x329ECD0", Offset = "0x329D2D0", VA = "0x18329ECD0")]
		public static void SyncAnimationsToOtherPlayers(int layerIdx = -1)
		{
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A4D")]
		[Address(RVA = "0x329EEE0", Offset = "0x329D4E0", VA = "0x18329EEE0")]
		public static void RequestPlayerMecanimSync()
		{
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A4E")]
		[Address(RVA = "0x329F0C0", Offset = "0x329D6C0", VA = "0x18329F0C0")]
		public static void CameraShakeRadius(Vector3 position, float radius, float max = 1f)
		{
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A4F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LocalPlayer()
		{
		}

		// Token: 0x04001904 RID: 6404
		[Token(Token = "0x4001904")]
		[FieldOffset(Offset = "0x20")]
		[Header("Core")]
		public Transform _transform;

		// Token: 0x04001905 RID: 6405
		[Token(Token = "0x4001905")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody _rigidbody;

		// Token: 0x04001906 RID: 6406
		[Token(Token = "0x4001906")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _playerGO;

		// Token: 0x04001907 RID: 6407
		[Token(Token = "0x4001907")]
		[FieldOffset(Offset = "0x38")]
		public GameObject _playerBase;

		// Token: 0x04001908 RID: 6408
		[Token(Token = "0x4001908")]
		[FieldOffset(Offset = "0x40")]
		public Transform _headTr;

		// Token: 0x04001909 RID: 6409
		[Token(Token = "0x4001909")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PlayerInventory _inventory;

		// Token: 0x0400190A RID: 6410
		[Token(Token = "0x400190A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PlayerRaceSystem _raceSystem;

		// Token: 0x0400190B RID: 6411
		[Token(Token = "0x400190B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private PlayerClothingSystem _clothingSystem;

		// Token: 0x0400190C RID: 6412
		[Token(Token = "0x400190C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StructureCraftingSystem _structureCraftingSystem;

		// Token: 0x0400190D RID: 6413
		[Token(Token = "0x400190D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vitals _vitals;

		// Token: 0x0400190E RID: 6414
		[Token(Token = "0x400190E")]
		[FieldOffset(Offset = "0x70")]
		[FormerlySerializedAs("_receipeBook")]
		public Grabber _grabber;

		// Token: 0x0400190F RID: 6415
		[Token(Token = "0x400190F")]
		[FieldOffset(Offset = "0x78")]
		public PlayerSfx _sfx;

		// Token: 0x04001910 RID: 6416
		[Token(Token = "0x4001910")]
		[FieldOffset(Offset = "0x80")]
		public PlayerStats _stats;

		// Token: 0x04001911 RID: 6417
		[Token(Token = "0x4001911")]
		[FieldOffset(Offset = "0x88")]
		public GameObject _specialActions;

		// Token: 0x04001912 RID: 6418
		[Token(Token = "0x4001912")]
		[FieldOffset(Offset = "0x90")]
		public GameObject _specialItems;

		// Token: 0x04001913 RID: 6419
		[Token(Token = "0x4001913")]
		[FieldOffset(Offset = "0x98")]
		public GameObject _buildingModeAction;

		// Token: 0x04001914 RID: 6420
		[Token(Token = "0x4001914")]
		[FieldOffset(Offset = "0xA0")]
		public LocalPlayer.SavedDataFields _savedData;

		// Token: 0x04001915 RID: 6421
		[Token(Token = "0x4001915")]
		[FieldOffset(Offset = "0xA8")]
		private IGrabBagInteractionReceiver _grabBagInteractionReceiver;

		// Token: 0x04001916 RID: 6422
		[Token(Token = "0x4001916")]
		[FieldOffset(Offset = "0xB0")]
		private CookingPot _cookingSystem;

		// Token: 0x04001917 RID: 6423
		[Token(Token = "0x4001917")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GiveItemsController _giveItemsController;

		// Token: 0x04001918 RID: 6424
		[Token(Token = "0x4001918")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private ReceiveItemsInteractionTrigger _receiveItemsInteractionTrigger;

		// Token: 0x04001919 RID: 6425
		[Token(Token = "0x4001919")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private CarryBody _carryBody;

		// Token: 0x0400191A RID: 6426
		[Token(Token = "0x400191A")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private PlayerRobbyInteraction _robbyInteraction;

		// Token: 0x0400191B RID: 6427
		[Token(Token = "0x400191B")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private PlayerExpressions _playerExpressions;

		// Token: 0x0400191C RID: 6428
		[Token(Token = "0x400191C")]
		[FieldOffset(Offset = "0xE0")]
		public PlayerStimuli _playerStimuli;

		// Token: 0x0400191D RID: 6429
		[Token(Token = "0x400191D")]
		[FieldOffset(Offset = "0xE8")]
		[Header("Cameras / Visuals / VR")]
		public Transform _mainCamTr;

		// Token: 0x0400191E RID: 6430
		[Token(Token = "0x400191E")]
		[FieldOffset(Offset = "0xF0")]
		public Transform _mainCamTrVR;

		// Token: 0x0400191F RID: 6431
		[Token(Token = "0x400191F")]
		[FieldOffset(Offset = "0xF8")]
		public Camera _mainCam;

		// Token: 0x04001920 RID: 6432
		[Token(Token = "0x4001920")]
		[FieldOffset(Offset = "0x100")]
		public Camera _mainCamVR;

		// Token: 0x04001921 RID: 6433
		[Token(Token = "0x4001921")]
		[FieldOffset(Offset = "0x108")]
		public Camera _inventoryCam;

		// Token: 0x04001922 RID: 6434
		[Token(Token = "0x4001922")]
		[FieldOffset(Offset = "0x110")]
		public Camera _inventoryCamVR;

		// Token: 0x04001923 RID: 6435
		[Token(Token = "0x4001923")]
		[FieldOffset(Offset = "0x118")]
		public ImageEffectOptimizer _imageEffectOptimizer;

		// Token: 0x04001924 RID: 6436
		[Token(Token = "0x4001924")]
		[FieldOffset(Offset = "0x120")]
		public camFollowHead _camFollowHead;

		// Token: 0x04001925 RID: 6437
		[Token(Token = "0x4001925")]
		[FieldOffset(Offset = "0x128")]
		public SimpleMouseRotator _camRotator;

		// Token: 0x04001926 RID: 6438
		[Token(Token = "0x4001926")]
		[FieldOffset(Offset = "0x130")]
		public GameObject _PlayerDeadCam;

		// Token: 0x04001927 RID: 6439
		[Token(Token = "0x4001927")]
		[FieldOffset(Offset = "0x138")]
		public Transform _watchTrVR;

		// Token: 0x04001928 RID: 6440
		[Token(Token = "0x4001928")]
		[FieldOffset(Offset = "0x140")]
		[FormerlySerializedAs("_inventoryPositionVR")]
		public Transform _worldInventoryPosition;

		// Token: 0x04001929 RID: 6441
		[Token(Token = "0x4001929")]
		[FieldOffset(Offset = "0x148")]
		public VRPlayerAdapter _vrAdapter;

		// Token: 0x0400192A RID: 6442
		[Token(Token = "0x400192A")]
		[FieldOffset(Offset = "0x150")]
		public VRPlayerControl _vrPlayerControl;

		// Token: 0x0400192B RID: 6443
		[Token(Token = "0x400192B")]
		[FieldOffset(Offset = "0x158")]
		public CameraMouseEvents _inventoryMouseEventsVR;

		// Token: 0x0400192C RID: 6444
		[Token(Token = "0x400192C")]
		[FieldOffset(Offset = "0x160")]
		[Header("Animation")]
		public Animator _animator;

		// Token: 0x0400192D RID: 6445
		[Token(Token = "0x400192D")]
		[FieldOffset(Offset = "0x168")]
		public PlayerAnimatorControl _animControl;

		// Token: 0x0400192E RID: 6446
		[Token(Token = "0x400192E")]
		[FieldOffset(Offset = "0x170")]
		public FirstPersonCharacter _fpc;

		// Token: 0x0400192F RID: 6447
		[Token(Token = "0x400192F")]
		[FieldOffset(Offset = "0x178")]
		public playerScriptSetup _scriptSetup;

		// Token: 0x04001930 RID: 6448
		[Token(Token = "0x4001930")]
		[FieldOffset(Offset = "0x180")]
		public playerHitReactions _hitReactions;

		// Token: 0x04001931 RID: 6449
		[Token(Token = "0x4001931")]
		[FieldOffset(Offset = "0x188")]
		public SimpleMouseRotator _mainRotator;

		// Token: 0x04001932 RID: 6450
		[Token(Token = "0x4001932")]
		[FieldOffset(Offset = "0x190")]
		public SkinnedMeshRenderer _animatedBook;

		// Token: 0x04001933 RID: 6451
		[Token(Token = "0x4001933")]
		[FieldOffset(Offset = "0x198")]
		public IkTargetsController _ikTargetsController;

		// Token: 0x04001934 RID: 6452
		[Token(Token = "0x4001934")]
		[FieldOffset(Offset = "0x1A0")]
		[Header("Unsorted")]
		public WaterLevelSensor _waterLevelSensor;

		// Token: 0x04001935 RID: 6453
		[Token(Token = "0x4001935")]
		[FieldOffset(Offset = "0x1A8")]
		public GameObject _greebleRoot;

		// Token: 0x04001936 RID: 6454
		[Token(Token = "0x4001936")]
		[FieldOffset(Offset = "0x1B0")]
		public UnderfootSurfaceDetector _surfaceDetector;

		// Token: 0x04001937 RID: 6455
		[Token(Token = "0x4001937")]
		[FieldOffset(Offset = "0x0")]
		private static LocalPlayer _instance;

		// Token: 0x04001969 RID: 6505
		[Token(Token = "0x4001969")]
		[FieldOffset(Offset = "0x18C")]
		private static int _cachedItemId;

		// Token: 0x0400196A RID: 6506
		[Token(Token = "0x400196A")]
		[FieldOffset(Offset = "0x190")]
		private static HeldControllerBase _cachedItemController;

		// Token: 0x0400196B RID: 6507
		[Token(Token = "0x400196B")]
		[FieldOffset(Offset = "0x198")]
		public static bool IsRelocatingStructure;

		// Token: 0x020003B8 RID: 952
		[Token(Token = "0x20003B8")]
		[Serializable]
		public class SavedDataFields
		{
			// Token: 0x06001A50 RID: 6736 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001A50")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SavedDataFields()
			{
			}

			// Token: 0x0400196F RID: 6511
			[Token(Token = "0x400196F")]
			[FieldOffset(Offset = "0x10")]
			public BoolData ReachedLowSanityThreshold;

			// Token: 0x04001970 RID: 6512
			[Token(Token = "0x4001970")]
			[FieldOffset(Offset = "0x18")]
			public BoolData ExitedEndgame;
		}
	}
}
