using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Items.Core
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[CreateAssetMenu(fileName = "NewItem", menuName = "Sons/ItemData")]
	public class ItemData : ScriptableObject
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x17000016")]
		public static int DefaultConsumeAnimationTypeValue
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x634E60", Offset = "0x633460", VA = "0x180634E60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x30AE8B0", Offset = "0x30ACEB0", VA = "0x1830AE8B0")]
		public void UpdateInspector()
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x30AE920", Offset = "0x30ACF20", VA = "0x1830AE920")]
		private Color GetBlue()
		{
			return default(Color);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x30AE940", Offset = "0x30ACF40", VA = "0x1830AE940")]
		private Color GetOrange()
		{
			return default(Color);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x30AE960", Offset = "0x30ACF60", VA = "0x1830AE960")]
		public void SetGuiType(ItemData.GuiType type)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x30AE970", Offset = "0x30ACF70", VA = "0x1830AE970")]
		private void TypeChanged()
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x30AEA20", Offset = "0x30AD020", VA = "0x1830AEA20")]
		private bool InstantaneousOrShoot()
		{
			return default(bool);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x30AEA40", Offset = "0x30AD040", VA = "0x1830AEA40")]
		private bool InstantaneousOrShootOrCharged()
		{
			return default(bool);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x30AEA50", Offset = "0x30AD050", VA = "0x1830AEA50")]
		private bool ThrownOrProjectile()
		{
			return default(bool);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x22C0610", Offset = "0x22BEC10", VA = "0x1822C0610")]
		private bool IsThrownWeapon()
		{
			return default(bool);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x30AEA70", Offset = "0x30AD070", VA = "0x1830AEA70")]
		private bool Charged()
		{
			return default(bool);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
		public void SetAmmoProperties(AmmoProperties ammoProperties)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x30AEA80", Offset = "0x30AD080", VA = "0x1830AEA80")]
		public void SetWeaponType(ItemData.WeaponType type)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x30AEAD0", Offset = "0x30AD0D0", VA = "0x1830AEAD0")]
		private void WeaponTypeChanged()
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x7C3300", Offset = "0x7C1900", VA = "0x1807C3300")]
		public void SetRangedStyle(RangedStyle style)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
		public void SetCompatibleAmmo(List<ItemData.CompatibleAmmoIdsForList> ammoList)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x30AEB20", Offset = "0x30AD120", VA = "0x1830AEB20")]
		private bool IsMeleeWeaponType()
		{
			return default(bool);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void Update()
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x30AEB40", Offset = "0x30AD140", VA = "0x1830AEB40")]
		public void Init(int id, string name)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x17000017")]
		public int Id
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
		public void SetId(int id)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x17000018")]
		public Types Type
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			get
			{
				return (Types)0;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x65D100", Offset = "0x65B700", VA = "0x18065D100")]
		public void SetType(Types type)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000019")]
		public string Name
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetName(string name)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x30AEBA0", Offset = "0x30AD1A0", VA = "0x1830AEBA0")]
		public bool HasType(Types type)
		{
			return default(bool);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x30AEBB0", Offset = "0x30AD1B0", VA = "0x1830AEBB0")]
		public bool MatchType(Types type)
		{
			return default(bool);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		public AnimatorVariables[] EquippedAnimVars
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x1D4F140", Offset = "0x1D4D740", VA = "0x181D4F140")]
			set
			{
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1D4F140", Offset = "0x1D4D740", VA = "0x181D4F140")]
		public void SetAnimatorVariables(AnimatorVariables[] animatorVariables)
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		public Transform PickupPrefab
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x728460", Offset = "0x726A60", VA = "0x180728460")]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		public Transform HeldPrefab
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x8ECC90", Offset = "0x8EB290", VA = "0x1808ECC90")]
			set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		public Transform PropPrefab
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x7849C0", Offset = "0x782FC0", VA = "0x1807849C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x7849D0", Offset = "0x782FD0", VA = "0x1807849D0")]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700001E")]
		public RuntimeAnimatorController CraftingIngredientController
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x784A30", Offset = "0x783030", VA = "0x180784A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000023A0 File Offset: 0x000005A0
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public int MaxAmount
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x67E8C0", Offset = "0x67CEC0", VA = "0x18067E8C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x67E8D0", Offset = "0x67CED0", VA = "0x18067E8D0")]
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000023B8 File Offset: 0x000005B8
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		public Vector3 DropOffset
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x2A23FF0", Offset = "0x2A225F0", VA = "0x182A23FF0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x30AEBC0", Offset = "0x30AD1C0", VA = "0x1830AEBC0")]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x17000021")]
		public bool EachInstanceIsUnique
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x27394A0", Offset = "0x2737AA0", VA = "0x1827394A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x17000022")]
		public bool PreventEquipFromInventoryView
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x30AEBE0", Offset = "0x30AD1E0", VA = "0x1830AEBE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x17000023")]
		public bool AllowPickupWhenInventoryIsFull
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x2739510", Offset = "0x2737B10", VA = "0x182739510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x17000024")]
		public bool HasFirstLook
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x30AEBF0", Offset = "0x30AD1F0", VA = "0x1830AEBF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x17000025")]
		public bool AllowFirstLookWhenEquippedFromInventory
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x30AEC00", Offset = "0x30AD200", VA = "0x1830AEC00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x17000026")]
		public bool PlayFirstLookAtBeforeEveryEquip
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x30AEC20", Offset = "0x30AD220", VA = "0x1830AEC20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x17000027")]
		public bool FirstLookRequiresBothHands
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x30AEC40", Offset = "0x30AD240", VA = "0x1830AEC40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x17000028")]
		public bool DropsOnDeath
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x30AEC60", Offset = "0x30AD260", VA = "0x1830AEC60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x17000029")]
		public bool AlwaysDropOnUnequip
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x30AEC70", Offset = "0x30AD270", VA = "0x1830AEC70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x1700002A")]
		public bool ApplyRandomForceOnDrop
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x30AEC80", Offset = "0x30AD280", VA = "0x1830AEC80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x1700002B")]
		public bool BlocksWaterInteractions
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x30AEC90", Offset = "0x30AD290", VA = "0x1830AEC90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x1700002C")]
		public int MaxVirtualPickups
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x7283D0", Offset = "0x7269D0", VA = "0x1807283D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x1700002D")]
		public int MaxWorldPickups
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0xAFF380", Offset = "0xAFD980", VA = "0x180AFF380")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700002E")]
		public StatEffect[] UsedStatEffect
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x1700002F")]
		public bool RequiresTwoHandsToEat
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x2586740", Offset = "0x2584D40", VA = "0x182586740")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x17000030")]
		public bool IsPerishable
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x252E5D0", Offset = "0x252CBD0", VA = "0x18252E5D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000031")]
		public PerishableItemData PerishableData
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x17000032")]
		public bool IsVolumeContainer
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x30AECA0", Offset = "0x30AD2A0", VA = "0x1830AECA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000033")]
		public VolumeContainerItemData VolumeContainerData
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x8DF560", Offset = "0x8DDB60", VA = "0x1808DF560")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x17000034")]
		public bool IsDismemberedLimb
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x30AECB0", Offset = "0x30AD2B0", VA = "0x1830AECB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x17000035")]
		public bool HasBloodReveal
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x30AECC0", Offset = "0x30AD2C0", VA = "0x1830AECC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x17000036")]
		public bool HasVisualVariant
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x30AECD0", Offset = "0x30AD2D0", VA = "0x1830AECD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x17000037")]
		public bool IsGPSLocator
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x30AECE0", Offset = "0x30AD2E0", VA = "0x1830AECE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x17000038")]
		public bool IsStructureElement
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x30AECF0", Offset = "0x30AD2F0", VA = "0x1830AECF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000025C8 File Offset: 0x000007C8
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000039")]
		public bool AllowQuickSelect
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x2A32B50", Offset = "0x2A31150", VA = "0x182A32B50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x30AED00", Offset = "0x30AD300", VA = "0x1830AED00")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x1700003A")]
		public ItemData.QuickSelectSlotTypes QuickSelectSlot
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0xAFF500", Offset = "0xAFDB00", VA = "0x180AFF500")]
			get
			{
				return ItemData.QuickSelectSlotTypes.Small;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x1700003B")]
		public bool CanBeHotKeyed
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0xA03DE0", Offset = "0xA023E0", VA = "0x180A03DE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x1700003C")]
		public bool ExcludeFromSpawnAll
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x30AED10", Offset = "0x30AD310", VA = "0x1830AED10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x1700003D")]
		public bool CanBeSpawned
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x257EA70", Offset = "0x257D070", VA = "0x18257EA70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700003E")]
		public StatEffect[] OwnedStatEffect
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x8DF480", Offset = "0x8DDA80", VA = "0x1808DF480")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700003F")]
		public StatEffect[] EquippedStatEffect
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x737420", Offset = "0x735A20", VA = "0x180737420")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000040")]
		public AmmoProperties Ammo
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000041")]
		public List<ItemData.CompatibleAmmoIdsForList> CompatibleAmmo
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000042")]
		public ItemUiData UiData
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x751010", Offset = "0x74F610", VA = "0x180751010")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x17000043")]
		public bool IsLegacyItem
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x2D75C80", Offset = "0x2D74280", VA = "0x182D75C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x17000044")]
		public bool AlwaysLoadStashedFromSaves
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x30AED30", Offset = "0x30AD330", VA = "0x1830AED30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x30AED40", Offset = "0x30AD340", VA = "0x1830AED40")]
		public void SetLegacy(bool value)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x30AED50", Offset = "0x30AD350", VA = "0x1830AED50")]
		public bool MatchRangedStyle(RangedStyle style)
		{
			return default(bool);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x30AED60", Offset = "0x30AD360", VA = "0x1830AED60")]
		public bool MatchesName(string searchName)
		{
			return default(bool);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x30AEE50", Offset = "0x30AD450", VA = "0x1830AEE50")]
		private bool MatchesAlias(string searchName)
		{
			return default(bool);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
		public IEnumerable<string> GetTags()
		{
			return null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x30AF050", Offset = "0x30AD650", VA = "0x1830AF050")]
		public bool HasTags()
		{
			return default(bool);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x30AF100", Offset = "0x30AD700", VA = "0x1830AF100")]
		public bool HasTag(string tag)
		{
			return default(bool);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x6000096")]
		[Address(RVA = "0xAFDBB0", Offset = "0xAFC1B0", VA = "0x180AFDBB0")]
		public int GetConsumeAnimationTypeValue()
		{
			return 0;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x30AF300", Offset = "0x30AD900", VA = "0x1830AF300")]
		public bool IsUnknownStatEffect()
		{
			return default(bool);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x30AF320", Offset = "0x30AD920", VA = "0x1830AF320")]
		public bool IsHotkeyable()
		{
			return default(bool);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x30AF340", Offset = "0x30AD940", VA = "0x1830AF340")]
		public ItemData()
		{
		}

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x18")]
		private bool _isInitialized;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x19")]
		private bool _showWeapon;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x1A")]
		private bool _showAmmo;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x1B")]
		[SerializeField]
		private bool _isLegacyItem;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		private const int CategoryWidth = 350;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		private const float LabelWidth = 130f;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Name is based off the asset file name.")]
		private string _name;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Unique ID automatically assigned to the Item. Can not be modified.")]
		private int _id;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ItemData.GuiType _guiType;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Types _type;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("_aliases")]
		[SerializeField]
		private List<string> _tags;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<string> _aliases;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AmmoProperties _ammoProperties;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ItemData.WeaponType _weaponType;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private RangedStyle _rangedStyle;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<ItemData.CompatibleAmmoIdsForList> _compatibleAmmo;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x60")]
		public bool AimedAtStimuli;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float AmmoDamageMult;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x68")]
		public MeleeWeaponData MeleeWeaponData;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x70")]
		public float WeaponRange;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private ItemData.ConsumeAnimationType _consumeAnimationType;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private StatEffect[] _usedStatEffect;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _unknownUsedStatEffect;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x81")]
		[SerializeField]
		private bool _requiresTwoHandsToEat;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x82")]
		[SerializeField]
		private bool _isPerishable;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private PerishableItemData _perishableData;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		public EquipmentSlot _equipmentSlot;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		public bool _requiresBothHands;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AnimatorVariables[] _equippedAnimVars;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private StatEffect[] _equippedStatEffect;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ItemUiData _uiData;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0xB0")]
		[FormerlySerializedAs("_maxVirtualInstances")]
		[SerializeField]
		private int _maxVirtualPickups;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private int _maxWorldPickups;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform _pickupPrefab;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Transform _heldPrefab;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Transform _propPrefab;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private RuntimeAnimatorController _craftingIngredientController;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private int _maxAmount;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private Vector3 _dropOffset;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private bool _eachInstanceIsUnique;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0xE9")]
		[SerializeField]
		private bool _allowQuickSelect;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private ItemData.QuickSelectSlotTypes _quickSelectSlot;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool _canBeHotKeyed;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0xF1")]
		[SerializeField]
		private bool _canBeSpawned;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0xF2")]
		[SerializeField]
		private bool _excludeFromSpawnAll;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0xF3")]
		[SerializeField]
		private bool _preventEquipFromInventoryView;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0xF4")]
		[Tooltip("Allows the item to be picked up and held, even if the player can not store anymore of this item in their inventory.")]
		[SerializeField]
		private bool _allowPickupWhenInventoryIsFull;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0xF5")]
		[SerializeField]
		private bool _hasFirstLook;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0xF6")]
		[SerializeField]
		private bool _allowFirstLookWhenEquippedFromInventory;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0xF7")]
		[SerializeField]
		private bool _playFirstLookAtBeforeEveryEquip;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool _firstLookRequiresBothHands;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0xF9")]
		[SerializeField]
		private bool _dropsOnDeath;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xFA")]
		[SerializeField]
		private bool _alwaysDropOnUnequip;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0xFB")]
		[SerializeField]
		private bool _applyRandomForceOnDrop;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private bool _alwaysLoadStashedFromSaves;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x100")]
		[HideInInspector]
		[SerializeField]
		private StatEffect[] _ownedStatEffect;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Tooltip("If true, this item blocks drinking from a water source or refilling containers.")]
		private bool _blocksWaterInteractions;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x109")]
		[SerializeField]
		[Tooltip("This item acts as a container which can hold a certain amount of volume. Examples of containers would be a water flask or air canisters.")]
		private bool _isVolumeContainer;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private VolumeContainerItemData _volumeContainerData;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private bool _isDismemberedLimb;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x119")]
		[SerializeField]
		private bool _isGPSLocator;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x11A")]
		[SerializeField]
		private bool _hasBloodReveal;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x11B")]
		[SerializeField]
		private bool _hasVisualVariant;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private bool _isStructureElement;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x120")]
		[HideInInspector]
		public string _editorName;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BaseColorMap;

		// Token: 0x0200001C RID: 28
		[Token(Token = "0x200001C")]
		private enum ConsumeAnimationType
		{
			// Token: 0x040000CA RID: 202
			[Token(Token = "0x40000CA")]
			None = -1,
			// Token: 0x040000CB RID: 203
			[Token(Token = "0x40000CB")]
			Meat,
			// Token: 0x040000CC RID: 204
			[Token(Token = "0x40000CC")]
			Soda,
			// Token: 0x040000CD RID: 205
			[Token(Token = "0x40000CD")]
			Berry,
			// Token: 0x040000CE RID: 206
			[Token(Token = "0x40000CE")]
			Mushroom,
			// Token: 0x040000CF RID: 207
			[Token(Token = "0x40000CF")]
			EnergyBar,
			// Token: 0x040000D0 RID: 208
			[Token(Token = "0x40000D0")]
			SpoonPacket,
			// Token: 0x040000D1 RID: 209
			[Token(Token = "0x40000D1")]
			Pills,
			// Token: 0x040000D2 RID: 210
			[Token(Token = "0x40000D2")]
			Herbs,
			// Token: 0x040000D3 RID: 211
			[Token(Token = "0x40000D3")]
			Cereal,
			// Token: 0x040000D4 RID: 212
			[Token(Token = "0x40000D4")]
			Ramen,
			// Token: 0x040000D5 RID: 213
			[Token(Token = "0x40000D5")]
			Oyster,
			// Token: 0x040000D6 RID: 214
			[Token(Token = "0x40000D6")]
			Fish,
			// Token: 0x040000D7 RID: 215
			[Token(Token = "0x40000D7")]
			Flask,
			// Token: 0x040000D8 RID: 216
			[Token(Token = "0x40000D8")]
			Arm,
			// Token: 0x040000D9 RID: 217
			[Token(Token = "0x40000D9")]
			Leg,
			// Token: 0x040000DA RID: 218
			[Token(Token = "0x40000DA")]
			Pot
		}

		// Token: 0x0200001D RID: 29
		[Token(Token = "0x200001D")]
		[Serializable]
		public class CompatibleAmmoIdsForList
		{
			// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CompatibleAmmoIdsForList()
			{
			}

			// Token: 0x040000DB RID: 219
			[Token(Token = "0x40000DB")]
			[FieldOffset(Offset = "0x10")]
			[ItemIdPicker(Types.Ammo, false)]
			public int _itemId;
		}

		// Token: 0x0200001E RID: 30
		[Token(Token = "0x200001E")]
		public enum GuiType
		{
			// Token: 0x040000DD RID: 221
			[Token(Token = "0x40000DD")]
			Default,
			// Token: 0x040000DE RID: 222
			[Token(Token = "0x40000DE")]
			Weapon,
			// Token: 0x040000DF RID: 223
			[Token(Token = "0x40000DF")]
			Armor,
			// Token: 0x040000E0 RID: 224
			[Token(Token = "0x40000E0")]
			Ammo,
			// Token: 0x040000E1 RID: 225
			[Token(Token = "0x40000E1")]
			WeaponMod,
			// Token: 0x040000E2 RID: 226
			[Token(Token = "0x40000E2")]
			ThrownWeapon
		}

		// Token: 0x0200001F RID: 31
		[Token(Token = "0x200001F")]
		public enum QuickSelectSlotTypes
		{
			// Token: 0x040000E4 RID: 228
			[Token(Token = "0x40000E4")]
			Small,
			// Token: 0x040000E5 RID: 229
			[Token(Token = "0x40000E5")]
			Medium,
			// Token: 0x040000E6 RID: 230
			[Token(Token = "0x40000E6")]
			Large,
			// Token: 0x040000E7 RID: 231
			[Token(Token = "0x40000E7")]
			GuideBook
		}

		// Token: 0x02000020 RID: 32
		[Token(Token = "0x2000020")]
		public enum WeaponType
		{
			// Token: 0x040000E9 RID: 233
			[Token(Token = "0x40000E9")]
			Melee,
			// Token: 0x040000EA RID: 234
			[Token(Token = "0x40000EA")]
			Thrown,
			// Token: 0x040000EB RID: 235
			[Token(Token = "0x40000EB")]
			AmmoBased,
			// Token: 0x040000EC RID: 236
			[Token(Token = "0x40000EC")]
			MeleeAndThrown
		}
	}
}
