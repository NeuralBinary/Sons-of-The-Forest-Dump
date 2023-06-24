using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Ai.Vail
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[AddComponentMenu("Sons/Weapon/Dismemberment Controller")]
	public class DismembermentController : MonoBehaviour
	{
		// Token: 0x0600044F RID: 1103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x2B12350", Offset = "0x2B10950", VA = "0x182B12350")]
		private void Awake()
		{
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x2B12560", Offset = "0x2B10B60", VA = "0x182B12560")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x2B126A0", Offset = "0x2B10CA0", VA = "0x182B126A0")]
		public void SetDead(bool value)
		{
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x2B12720", Offset = "0x2B10D20", VA = "0x182B12720")]
		public void AddCallback(Action<DismembermentController.DismemberPartId, bool> onDismembered)
		{
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x2B129F0", Offset = "0x2B10FF0", VA = "0x182B129F0")]
		public void EmulateImpactAll(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x2B12B60", Offset = "0x2B11160", VA = "0x182B12B60")]
		public void ClearDismember()
		{
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x2B12CB0", Offset = "0x2B112B0", VA = "0x182B12CB0")]
		public int GetDismemberMask()
		{
			return 0;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x2B12E20", Offset = "0x2B11420", VA = "0x182B12E20")]
		public void ApplyDismemberMask(int mask, bool spawnBlood)
		{
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x2B12FB0", Offset = "0x2B115B0", VA = "0x182B12FB0")]
		public static bool InMask(int mask, DismembermentController.DismemberPartId partId)
		{
			return default(bool);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x2B12FD0", Offset = "0x2B115D0", VA = "0x182B12FD0")]
		public void ApplyRandomDismember()
		{
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x2B130B0", Offset = "0x2B116B0", VA = "0x182B130B0")]
		public void SendImpactEventToServer(DismembermentController.DismemberPartId partId, float dismemberDamage)
		{
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x2B13320", Offset = "0x2B11920", VA = "0x182B13320")]
		public void ReceivedImpactEventFromClient(DismemberHitEvent ev)
		{
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x2B134F0", Offset = "0x2B11AF0", VA = "0x182B134F0")]
		private bool AllowDamage(IImpactData impactData, DamageNode damageNode, bool isValid)
		{
			return default(bool);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x2B13670", Offset = "0x2B11C70", VA = "0x182B13670")]
		public DismembermentController()
		{
		}

		// Token: 0x04000382 RID: 898
		[Token(Token = "0x4000382")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Turn off dismemberment. (Eg. on child prefab or for testing.)")]
		[SerializeField]
		private bool _disableDismemberment;

		// Token: 0x04000383 RID: 899
		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<DismembermentController.DismembermentDefinition> _definitions;

		// Token: 0x04000384 RID: 900
		[Token(Token = "0x4000384")]
		[FieldOffset(Offset = "0x30")]
		private VailActorTypeId _actorTypeId;

		// Token: 0x04000385 RID: 901
		[Token(Token = "0x4000385")]
		[FieldOffset(Offset = "0x34")]
		private bool _isDead;

		// Token: 0x04000386 RID: 902
		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x38")]
		private float _deathTime;

		// Token: 0x04000387 RID: 903
		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x3C")]
		private int _lastImpactId;

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x200005C")]
		public enum DismemberPartId
		{
			// Token: 0x04000389 RID: 905
			[Token(Token = "0x4000389")]
			Head,
			// Token: 0x0400038A RID: 906
			[Token(Token = "0x400038A")]
			RightArm,
			// Token: 0x0400038B RID: 907
			[Token(Token = "0x400038B")]
			LeftArm,
			// Token: 0x0400038C RID: 908
			[Token(Token = "0x400038C")]
			RightLeg,
			// Token: 0x0400038D RID: 909
			[Token(Token = "0x400038D")]
			LeftLeg,
			// Token: 0x0400038E RID: 910
			[Token(Token = "0x400038E")]
			None
		}

		// Token: 0x0200005D RID: 93
		[Token(Token = "0x200005D")]
		[Serializable]
		public class DismembermentDefinition
		{
			// Token: 0x0600045D RID: 1117 RVA: 0x00003D50 File Offset: 0x00001F50
			[Token(Token = "0x600045D")]
			[Address(RVA = "0xA50BE0", Offset = "0xA4F1E0", VA = "0x180A50BE0")]
			public bool HasDismembered()
			{
				return default(bool);
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x0600045E RID: 1118 RVA: 0x00003D68 File Offset: 0x00001F68
			[Token(Token = "0x1700004E")]
			public DismembermentController.DismemberPartId PartId
			{
				[Token(Token = "0x600045E")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
				get
				{
					return DismembermentController.DismemberPartId.Head;
				}
			}

			// Token: 0x14000003 RID: 3
			// (add) Token: 0x0600045F RID: 1119 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06000460 RID: 1120 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x14000003")]
			private event Action<DismembermentController.DismemberPartId, bool> DoDismemberCallback
			{
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x2B136C0", Offset = "0x2B11CC0", VA = "0x182B136C0")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6000460")]
				[Address(RVA = "0x2B13830", Offset = "0x2B11E30", VA = "0x182B13830")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x2B139A0", Offset = "0x2B11FA0", VA = "0x182B139A0")]
			public void DoDismember(IImpactData impactData, bool spawnParts = true, bool spawnBlood = true)
			{
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x2B13A10", Offset = "0x2B12010", VA = "0x182B13A10")]
			private void ActivateTargets(bool isDismembered)
			{
			}

			// Token: 0x06000463 RID: 1123 RVA: 0x00003D80 File Offset: 0x00001F80
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x2B13DC0", Offset = "0x2B123C0", VA = "0x182B13DC0")]
			private int GetMaskPropertyId()
			{
				return 0;
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x2B13EB0", Offset = "0x2B124B0", VA = "0x182B13EB0")]
			private void UpdateShader()
			{
			}

			// Token: 0x06000465 RID: 1125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x2B143D0", Offset = "0x2B129D0", VA = "0x182B143D0")]
			private void HideSection(int section)
			{
			}

			// Token: 0x06000466 RID: 1126 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x2B147C0", Offset = "0x2B12DC0", VA = "0x182B147C0")]
			private void TestDismember()
			{
			}

			// Token: 0x06000467 RID: 1127 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x2B14810", Offset = "0x2B12E10", VA = "0x182B14810")]
			private void ClearDismemberButton()
			{
			}

			// Token: 0x06000468 RID: 1128 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x2B14840", Offset = "0x2B12E40", VA = "0x182B14840")]
			public void ClearDismember()
			{
			}

			// Token: 0x06000469 RID: 1129 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x2B14860", Offset = "0x2B12E60", VA = "0x182B14860")]
			private void SpawnInstances(IImpactData impactData, bool spawnParts, bool spawnBlood)
			{
			}

			// Token: 0x0600046A RID: 1130 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x2B15950", Offset = "0x2B13F50", VA = "0x182B15950")]
			private void DestroyInstance(UnityEngine.Object instance)
			{
			}

			// Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x2B159C0", Offset = "0x2B13FC0", VA = "0x182B159C0")]
			private void ClearInstanceObjects()
			{
			}

			// Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x2B15BA0", Offset = "0x2B141A0", VA = "0x182B15BA0")]
			public void Awake(DismembermentController controller, bool disabled)
			{
			}

			// Token: 0x0600046D RID: 1133 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x2B15E30", Offset = "0x2B14430", VA = "0x182B15E30")]
			private void CleanupMaterialInstance(Material matInstance, int section, bool existingInstance, Material oldMaterial)
			{
			}

			// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x2B160A0", Offset = "0x2B146A0", VA = "0x182B160A0")]
			public void DestroyInstances()
			{
			}

			// Token: 0x0600046F RID: 1135 RVA: 0x00003D98 File Offset: 0x00001F98
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x2B16110", Offset = "0x2B14710", VA = "0x182B16110")]
			private float GetMultiplier(IImpactData impactData)
			{
				return 0f;
			}

			// Token: 0x06000470 RID: 1136 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x2B161B0", Offset = "0x2B147B0", VA = "0x182B161B0")]
			public void OnImpact(IImpactSender sender, IImpactData impactData, bool isValid)
			{
			}

			// Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x2B16950", Offset = "0x2B14F50", VA = "0x182B16950")]
			public void ApplyDismemberDamage(float damage, IImpactData impactData)
			{
			}

			// Token: 0x06000472 RID: 1138 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x2B136C0", Offset = "0x2B11CC0", VA = "0x182B136C0")]
			public void AddCallback(Action<DismembermentController.DismemberPartId, bool> onDismemberCallback)
			{
			}

			// Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x5FD570", Offset = "0x5FBB70", VA = "0x1805FD570")]
			public void SetOverrideDismember(bool value)
			{
			}

			// Token: 0x06000474 RID: 1140 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x2B16A10", Offset = "0x2B15010", VA = "0x182B16A10")]
			public DismembermentDefinition()
			{
			}

			// Token: 0x0400038F RID: 911
			[Token(Token = "0x400038F")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private DismembermentController.DismemberPartId _partId;

			// Token: 0x04000390 RID: 912
			[Token(Token = "0x4000390")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			[Tooltip("Will force dismember on any damage")]
			private bool _overrideDismember;

			// Token: 0x04000391 RID: 913
			[Token(Token = "0x4000391")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[FormerlySerializedAs("_dismemberAmount")]
			private float _damageToDismember;

			// Token: 0x04000392 RID: 914
			[Token(Token = "0x4000392")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private float _defaultMultiplier;

			// Token: 0x04000393 RID: 915
			[Token(Token = "0x4000393")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private bool _instantDeath;

			// Token: 0x04000394 RID: 916
			[Token(Token = "0x4000394")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private List<GameObject> _activateTargets;

			// Token: 0x04000395 RID: 917
			[Token(Token = "0x4000395")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private List<GameObject> _deactivateTargets;

			// Token: 0x04000396 RID: 918
			[Token(Token = "0x4000396")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private List<DismembermentController.DismembermentDefinition.InstanceData> _instances;

			// Token: 0x04000397 RID: 919
			[Token(Token = "0x4000397")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			[FormerlySerializedAs("_damageSource")]
			private List<DamageNode> _damageNodes;

			// Token: 0x04000398 RID: 920
			[Token(Token = "0x4000398")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private Renderer _damageRenderer;

			// Token: 0x04000399 RID: 921
			[Token(Token = "0x4000399")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private int _damageSection;

			// Token: 0x0400039A RID: 922
			[Token(Token = "0x400039A")]
			[FieldOffset(Offset = "0x54")]
			[SerializeField]
			private int _hideSection;

			// Token: 0x0400039B RID: 923
			[Token(Token = "0x400039B")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			private DismembermentController.DismembermentDefinition.MaskChannels _maskChannel;

			// Token: 0x0400039C RID: 924
			[Token(Token = "0x400039C")]
			[FieldOffset(Offset = "0x0")]
			private static readonly int DamageBoolPropertyId;

			// Token: 0x0400039D RID: 925
			[Token(Token = "0x400039D")]
			[FieldOffset(Offset = "0x4")]
			private static readonly int DismemberRedId;

			// Token: 0x0400039E RID: 926
			[Token(Token = "0x400039E")]
			[FieldOffset(Offset = "0x8")]
			private static readonly int DismemberGreenId;

			// Token: 0x0400039F RID: 927
			[Token(Token = "0x400039F")]
			[FieldOffset(Offset = "0xC")]
			private static readonly int DismemberBlueId;

			// Token: 0x040003A0 RID: 928
			[Token(Token = "0x40003A0")]
			[FieldOffset(Offset = "0x10")]
			private static readonly int DismemberAlphaId;

			// Token: 0x040003A1 RID: 929
			[Token(Token = "0x40003A1")]
			[FieldOffset(Offset = "0x14")]
			private static readonly int BaseColorId;

			// Token: 0x040003A2 RID: 930
			[Token(Token = "0x40003A2")]
			[FieldOffset(Offset = "0x60")]
			private Material _materialInstance;

			// Token: 0x040003A3 RID: 931
			[Token(Token = "0x40003A3")]
			[FieldOffset(Offset = "0x68")]
			private Material _oldMaterial;

			// Token: 0x040003A4 RID: 932
			[Token(Token = "0x40003A4")]
			[FieldOffset(Offset = "0x70")]
			private bool _existingMaterialInstance;

			// Token: 0x040003A5 RID: 933
			[Token(Token = "0x40003A5")]
			[FieldOffset(Offset = "0x78")]
			private Material _hideMaterialInstance;

			// Token: 0x040003A6 RID: 934
			[Token(Token = "0x40003A6")]
			[FieldOffset(Offset = "0x80")]
			private Material _hideOldMaterial;

			// Token: 0x040003A7 RID: 935
			[Token(Token = "0x40003A7")]
			[FieldOffset(Offset = "0x88")]
			private bool _hideExistingMaterialInstance;

			// Token: 0x040003A9 RID: 937
			[Token(Token = "0x40003A9")]
			[FieldOffset(Offset = "0x98")]
			private List<GameObject> _spawnedInstances;

			// Token: 0x040003AA RID: 938
			[Token(Token = "0x40003AA")]
			[FieldOffset(Offset = "0xA0")]
			private float _appliedDamage;

			// Token: 0x040003AB RID: 939
			[Token(Token = "0x40003AB")]
			[FieldOffset(Offset = "0xA4")]
			private bool _dismembered;

			// Token: 0x040003AC RID: 940
			[Token(Token = "0x40003AC")]
			[FieldOffset(Offset = "0xA8")]
			private DismembermentController _dismembermentController;

			// Token: 0x0200005E RID: 94
			[Token(Token = "0x200005E")]
			[Serializable]
			public class InstanceData
			{
				// Token: 0x06000476 RID: 1142 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000476")]
				[Address(RVA = "0x2B16D70", Offset = "0x2B15370", VA = "0x182B16D70")]
				public InstanceData()
				{
				}

				// Token: 0x040003AD RID: 941
				[Token(Token = "0x40003AD")]
				[FieldOffset(Offset = "0x10")]
				public GameObject _source;

				// Token: 0x040003AE RID: 942
				[Token(Token = "0x40003AE")]
				[FieldOffset(Offset = "0x18")]
				public Transform _locator;

				// Token: 0x040003AF RID: 943
				[Token(Token = "0x40003AF")]
				[FieldOffset(Offset = "0x20")]
				public bool _attach;

				// Token: 0x040003B0 RID: 944
				[Token(Token = "0x40003B0")]
				[FieldOffset(Offset = "0x21")]
				public bool _sameJointParent;

				// Token: 0x040003B1 RID: 945
				[Token(Token = "0x40003B1")]
				[FieldOffset(Offset = "0x24")]
				public float _scale;
			}

			// Token: 0x0200005F RID: 95
			[Token(Token = "0x200005F")]
			public enum MaskChannels
			{
				// Token: 0x040003B3 RID: 947
				[Token(Token = "0x40003B3")]
				Red,
				// Token: 0x040003B4 RID: 948
				[Token(Token = "0x40003B4")]
				Green,
				// Token: 0x040003B5 RID: 949
				[Token(Token = "0x40003B5")]
				Blue,
				// Token: 0x040003B6 RID: 950
				[Token(Token = "0x40003B6")]
				Alpha
			}
		}
	}
}
