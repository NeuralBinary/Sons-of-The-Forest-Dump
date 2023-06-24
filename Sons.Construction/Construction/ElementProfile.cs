using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace Construction
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	[CreateAssetMenu(menuName = "Sons/Construction/ElementProfile")]
	public class ElementProfile : ScriptableObject
	{
		// Token: 0x0600021A RID: 538 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2D75A50", Offset = "0x2D74050", VA = "0x182D75A50")]
		public static void InitSettings(RuntimeStructureDatabase runtimeDb)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2D75AF0", Offset = "0x2D740F0", VA = "0x182D75AF0")]
		public static void CleanUpSettings()
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2D75B90", Offset = "0x2D74190", VA = "0x182D75B90")]
		public static void FreeFormUseLOD(bool onOff)
		{
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00002D14 File Offset: 0x00000F14
		[Token(Token = "0x17000098")]
		public ushort Id
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0xF46FD0", Offset = "0xF455D0", VA = "0x180F46FD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00002D2C File Offset: 0x00000F2C
		[Token(Token = "0x17000099")]
		public bool IsGrabsTrigger
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x26000F0", Offset = "0x25FE6F0", VA = "0x1826000F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00002D44 File Offset: 0x00000F44
		[Token(Token = "0x1700009A")]
		public bool IgnoreInElementsCount
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x2D75C80", Offset = "0x2D74280", VA = "0x182D75C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x1700009B")]
		public bool IsSolidGround
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x150B770", Offset = "0x1509D70", VA = "0x18150B770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x1700009C")]
		public bool IsWindow
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x2B22510", Offset = "0x2B20B10", VA = "0x182B22510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x1700009D")]
		public bool PreventVerticalStacking
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x2D75C90", Offset = "0x2D74290", VA = "0x182D75C90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x1700009E")]
		public bool CanBeClimbed
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x2D75CA0", Offset = "0x2D742A0", VA = "0x182D75CA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x1700009F")]
		public bool SpawnPickupsWhenDestroyed
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x2197B80", Offset = "0x2196180", VA = "0x182197B80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[Token(Token = "0x170000A0")]
		public uint ExtraPickupYieldWhenDestroyed
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x6FF7C0", Offset = "0x6FDDC0", VA = "0x1806FF7C0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x170000A1")]
		public bool BlockInWater
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x9938E0", Offset = "0x991EE0", VA = "0x1809938E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x170000A2")]
		public bool SimpleClothDeformation
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x993970", Offset = "0x991F70", VA = "0x180993970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00002E1C File Offset: 0x0000101C
		[Token(Token = "0x170000A3")]
		public bool IsRockStructure
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x2A99E50", Offset = "0x2A98450", VA = "0x182A99E50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x170000A4")]
		public ClipTypes DismantleAnim
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020")]
			get
			{
				return ClipTypes.Wobble;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00002E4C File Offset: 0x0000104C
		[Token(Token = "0x170000A5")]
		public bool DisassemblesToPrevElement
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x170000A6")]
		public float ExtremityToSnapPositionOffset
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x170000A7")]
		public uint VisualVariant
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x170000A8")]
		public bool AllowsDisassembling
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x2084CB0", Offset = "0x20832B0", VA = "0x182084CB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x170000A9")]
		public uint DisassembleBy
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x170000AA")]
		public uint DisassembleItemYield
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x5FDAB0", Offset = "0x5FC0B0", VA = "0x1805FDAB0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x170000AB")]
		public Notches Notches
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x27E7B40", Offset = "0x27E6140", VA = "0x1827E7B40")]
			get
			{
				return Notches.None;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000AC")]
		public ItemData Item
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000AD")]
		public ElementProfile LengthSplitProfile
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x751010", Offset = "0x74F610", VA = "0x180751010")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000AE")]
		public ElementProfile UncutProfile
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x2D75CB0", Offset = "0x2D742B0", VA = "0x182D75CB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000AF")]
		public ElementProfile NotchedProfile
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0xA03D90", Offset = "0xA02390", VA = "0x180A03D90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000B0")]
		public ElementProfile MiddleHoleProfile
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000B1")]
		public ElementProfile SpikeProfile
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000B2")]
		public ElementProfile EvolveToProfile
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x7849C0", Offset = "0x782FC0", VA = "0x1807849C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000B3")]
		public ElementProfile InvertedProfile
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x784A30", Offset = "0x783030", VA = "0x180784A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000B4")]
		public ElementProfile DisassemblesTo
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000B5")]
		public ElementProfile GhostProfile
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000B6")]
		public ElementProfile NonGhostProfile
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000B7")]
		public ElementProfile DeviceOffProfile
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0xA3F220", Offset = "0xA3D820", VA = "0x180A3F220")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000B8")]
		public ElementProfile DeviceOnProfile
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x8DF480", Offset = "0x8DDA80", VA = "0x1808DF480")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000B9")]
		public Transform SpikeCuttings
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x784AA0", Offset = "0x7830A0", VA = "0x180784AA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000BA")]
		public Transform NotchCuttings
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000BB")]
		public StructureElement Prefab
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x2D75D00", Offset = "0x2D74300", VA = "0x182D75D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000BC")]
		public GameObject ClothCollisionPrefab
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x691530", Offset = "0x68FB30", VA = "0x180691530")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000BD")]
		public GameObject ShatteredPrefab
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0xA3F1B0", Offset = "0xA3D7B0", VA = "0x180A3F1B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000BE")]
		public PresetElementsTemplate PresetElementsTemplate
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x8DF4F0", Offset = "0x8DDAF0", VA = "0x1808DF4F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000BF")]
		public PresetElementsTemplate PresetElementsExtensionTemplate
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x8DF560", Offset = "0x8DDB60", VA = "0x1808DF560")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000C0")]
		public PresetElementsTemplate ReinforcementElementsTemplate
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x6913C0", Offset = "0x68F9C0", VA = "0x1806913C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000C1")]
		public PresetElementsTemplate FuelElementsTemplate
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x1359C20", Offset = "0x1358220", VA = "0x181359C20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000C2")]
		public NotchingDataGrid NotchingGrid
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x61C550", Offset = "0x61AB50", VA = "0x18061C550")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00002EF4 File Offset: 0x000010F4
		[Token(Token = "0x170000C3")]
		public bool IsReinforced
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x992180", Offset = "0x990780", VA = "0x180992180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00002F0C File Offset: 0x0000110C
		[Token(Token = "0x170000C4")]
		public bool RequiresCompletedStructureMessage
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00002F24 File Offset: 0x00001124
		[Token(Token = "0x170000C5")]
		public float DistortionRatio
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x23BB670", Offset = "0x23B9C70", VA = "0x1823BB670")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00002F3C File Offset: 0x0000113C
		[Token(Token = "0x170000C6")]
		public bool VerticalDistortMode
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x213CBA0", Offset = "0x213B1A0", VA = "0x18213CBA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00002F54 File Offset: 0x00001154
		[Token(Token = "0x170000C7")]
		public bool AllowsPartialCollapse
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x213CBB0", Offset = "0x213B1B0", VA = "0x18213CBB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00002F6C File Offset: 0x0000116C
		[Token(Token = "0x170000C8")]
		public bool UseElementPositionInsteadOfRenderer
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x213CCB0", Offset = "0x213B2B0", VA = "0x18213CCB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00002F84 File Offset: 0x00001184
		[Token(Token = "0x170000C9")]
		public bool IgnoreScalingForSpawnedPickups
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x2D75E10", Offset = "0x2D74410", VA = "0x182D75E10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00002F9C File Offset: 0x0000119C
		[Token(Token = "0x170000CA")]
		public bool UseElementMeshOnPickupWhenCollapsed
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x2A88DC0", Offset = "0x2A873C0", VA = "0x182A88DC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00002FB4 File Offset: 0x000011B4
		[Token(Token = "0x170000CB")]
		public bool DelayedCollapsedPerElement
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x2A88DE0", Offset = "0x2A873E0", VA = "0x182A88DE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00002FCC File Offset: 0x000011CC
		[Token(Token = "0x170000CC")]
		public bool InvertXZScaleForSpawnedPickups
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x2A88E10", Offset = "0x2A87410", VA = "0x182A88E10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00002FE4 File Offset: 0x000011E4
		[Token(Token = "0x170000CD")]
		public float AdditionalHp
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0xA53160", Offset = "0xA51760", VA = "0x180A53160")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00002FFC File Offset: 0x000011FC
		[Token(Token = "0x170000CE")]
		public bool IsClosed
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x237F390", Offset = "0x237D990", VA = "0x18237F390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00003014 File Offset: 0x00001214
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2D75E20", Offset = "0x2D74420", VA = "0x182D75E20")]
		public int GetQuarterNum()
		{
			return 0;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2D75F60", Offset = "0x2D74560", VA = "0x182D75F60")]
		public ElementProfile GetQuarterCutProfile(int quarters)
		{
			return null;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2D75FB0", Offset = "0x2D745B0", VA = "0x182D75FB0")]
		public ElementProfile GetQuarterCutProfile(float quarters, out int quarterCount)
		{
			return null;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2D761E0", Offset = "0x2D747E0", VA = "0x182D761E0")]
		public ElementProfile GetLineProfile(int lineNum)
		{
			return null;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2D76230", Offset = "0x2D74830", VA = "0x182D76230")]
		public ElementProfile GetLeaningProfile(int quarters)
		{
			return null;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x8DF4F0", Offset = "0x8DDAF0", VA = "0x1808DF4F0", Slot = "4")]
		public virtual PresetElementsTemplate GetElementTemplate(IStructure structure)
		{
			return null;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x8DF4F0", Offset = "0x8DDAF0", VA = "0x1808DF4F0", Slot = "5")]
		public virtual PresetElementsTemplate GetElementTemplate(TargetInfo targetInfo, StructureElement prefab)
		{
			return null;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2D76280", Offset = "0x2D74880", VA = "0x182D76280")]
		private ElementProfile GetUncutProfile()
		{
			return null;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2D762D0", Offset = "0x2D748D0", VA = "0x182D762D0")]
		public ElementProfile()
		{
		}

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ushort _id;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x1A")]
		[Header("Options")]
		[SerializeField]
		private bool _isGrabsTrigger;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x1B")]
		[SerializeField]
		private bool _ignoreInElementsCount;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool _isSolidGround;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x1D")]
		[SerializeField]
		private bool _isWindow;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x1E")]
		[SerializeField]
		private bool _preventVerticalStacking;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x1F")]
		[SerializeField]
		private bool _canBeClimbed;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _requiresCompletedStructureMessage;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _blockInWater;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool _simpleClothDeformation;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x23")]
		[SerializeField]
		private bool _isRockStructure;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _extremityToSnapPositionOffset;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private uint _visualVariant;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ClipTypes _dismantleAnim;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ElementProfile.ProfileFlags _profileFlags;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Header("Disassemble")]
		private bool _allowsDisassembling;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private uint _disassembleBy;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private uint _disassembleItemYield;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ItemData _item;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ElementProfile _disassemblesTo;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _disassemblesToPrevElement;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		[Header("Destruction")]
		private bool _spawnPickupsWhenDestroyed;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private uint _extraPickupYieldWhenDestroyed;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _isReinforced;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _distortionRatio;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _verticalDistortMode;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool _allowsPartialCollapse;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x62")]
		[SerializeField]
		private bool _useElementPositionInsteadOfRenderer;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x63")]
		[SerializeField]
		private bool _ignoreScalingForSpawnedPickups;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private bool _useElementMeshOnPickupWhenCollapsed;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x65")]
		[SerializeField]
		private bool _delayedCollapsedPerElement;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x66")]
		[SerializeField]
		private bool _invertXZScaleForSpawnedPickups;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _additionalHp;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Header("References")]
		private StructureElement _prefab;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private StructureElement _prefabLOD;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ElementProfile _ghostProfile;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ElementProfile _nonGhostProfile;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x90")]
		[Header("Transformations")]
		[SerializeField]
		private ElementProfile[] _quarterCutProfiles;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ElementProfile[] _lineProfiles;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ElementProfile[] _leaningProfiles;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ElementProfile _lengthSplitProfile;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ElementProfile _notchedProfile;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ElementProfile _middleHoleProfile;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private ElementProfile _spikeProfile;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ElementProfile _evolveToProfile;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ElementProfile _invertedProfile;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Transform _spikeCuttings;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Transform _notchCuttings;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _clothCollisionPrefab;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _shatteredPrefab;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0xF8")]
		[Header("Electricity")]
		[SerializeField]
		private ElementProfile _deviceOffProfile;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private ElementProfile _deviceOnProfile;

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x108")]
		[Header("Templates")]
		[SerializeField]
		[FormerlySerializedAs("_presetElements")]
		private PresetElementsTemplate _presetElementsTemplate;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private PresetElementsTemplate _presetElementsExtensionTemplate;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private PresetElementsTemplate _reinforcementElementsTemplate;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private PresetElementsTemplate _fuelElementsTemplate;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private NotchingDataGrid _notchingGrid;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Notches _notches;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x0")]
		private static bool UseLODs;

		// Token: 0x0200005E RID: 94
		[Token(Token = "0x200005E")]
		[Flags]
		public enum ProfileFlags
		{
			// Token: 0x0400026F RID: 623
			[Token(Token = "0x400026F")]
			IsClosed = 2
		}
	}
}
