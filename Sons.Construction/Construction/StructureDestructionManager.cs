using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sons.Save;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	public class StructureDestructionManager : SingletonBehaviour<StructureDestructionManager>, ISaveGameSerializer<StructureDestructionManager.DestructionSaveData>
	{
		// Token: 0x06000370 RID: 880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x2DC3BA0", Offset = "0x2DC21A0", VA = "0x182DC3BA0", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x2DC42A0", Offset = "0x2DC28A0", VA = "0x182DC42A0")]
		private void Start()
		{
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x2DC4300", Offset = "0x2DC2900", VA = "0x182DC4300", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x2DC45C0", Offset = "0x2DC2BC0", VA = "0x182DC45C0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x2DC47D0", Offset = "0x2DC2DD0", VA = "0x182DC47D0")]
		public static void Damage(Structure structure, Transform attackSourceTr, IImpactData impactData)
		{
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000037C4 File Offset: 0x000019C4
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x2DC4860", Offset = "0x2DC2E60", VA = "0x182DC4860")]
		public static bool IsTargetUsingDistortedStructures(TargetInfo targetInfo)
		{
			return default(bool);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x2DC49C0", Offset = "0x2DC2FC0", VA = "0x182DC49C0")]
		public void RegisterImpactValidator(IStructureImpactValidator validator)
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000037DC File Offset: 0x000019DC
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x2DC4A90", Offset = "0x2DC3090", VA = "0x182DC4A90")]
		private bool TryPassAllValidators(Structure structure, Transform attackSourceTr, IImpactData impactData)
		{
			return default(bool);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x2DC4CB0", Offset = "0x2DC32B0", VA = "0x182DC4CB0")]
		public void RegisterImpactProcessor(IStructureImpactProcessor processor)
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x2DC4D80", Offset = "0x2DC3380", VA = "0x182DC4D80")]
		private void TryPassAllProcessors(StructureImpactProcessingData processingData)
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x2DC4F60", Offset = "0x2DC3560", VA = "0x182DC4F60")]
		private void DamageInternal(Structure structure, Transform attackSourceTr, IImpactData impactData)
		{
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x2DC54F0", Offset = "0x2DC3AF0", VA = "0x182DC54F0")]
		private StructureInfo GetStructureInfo(Structure structure)
		{
			return null;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x2DC5710", Offset = "0x2DC3D10", VA = "0x182DC5710")]
		private void OnDestroyingStructure(Structure structure)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000037F4 File Offset: 0x000019F4
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x2DC5770", Offset = "0x2DC3D70", VA = "0x182DC5770")]
		private bool DestroyStructureDebug(string structureName)
		{
			return default(bool);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000380C File Offset: 0x00001A0C
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x2DC57D0", Offset = "0x2DC3DD0", VA = "0x182DC57D0")]
		private bool DamageStructureDebug(string structureNameAndDamageAmount)
		{
			return default(bool);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00003824 File Offset: 0x00001A24
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x2DC5D10", Offset = "0x2DC4310", VA = "0x182DC5D10")]
		public static bool TryRepair(Structure structure, out bool completedRepair)
		{
			return default(bool);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000383C File Offset: 0x00001A3C
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x2DC60A0", Offset = "0x2DC46A0", VA = "0x182DC60A0")]
		public static bool TryGetStructureHealth(Structure structure, out float health, out float maxHealth)
		{
			return default(bool);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x2DC6210", Offset = "0x2DC4810", VA = "0x182DC6210")]
		public static void SyncDistortedStructure(Structure s, bool isDamaged)
		{
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x2DC6490", Offset = "0x2DC4A90", VA = "0x182DC6490")]
		public static void SetDistortedStatus(Structure structure, bool isDamaged)
		{
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x2DC65F0", Offset = "0x2DC4BF0", VA = "0x182DC65F0")]
		public static List<RuntimeStructureDatabase.LinkedStructureData> ListDistortedStructures()
		{
			return null;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x2DC68F0", Offset = "0x2DC4EF0", VA = "0x182DC68F0")]
		public static void InitDistortedStructures(List<RuntimeStructureDatabase.LinkedStructureData> list)
		{
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000150")]
		private string SerializedName
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x2DC6BA0", Offset = "0x2DC51A0", VA = "0x182DC6BA0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00003854 File Offset: 0x00001A54
		[Token(Token = "0x17000151")]
		private bool UniqueFile
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0000386C File Offset: 0x00001A6C
		[Token(Token = "0x17000152")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00003884 File Offset: 0x00001A84
		[Token(Token = "0x17000153")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x2DC6BD0", Offset = "0x2DC51D0", VA = "0x182DC6BD0", Slot = "11")]
		private StructureDestructionManager.DestructionSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x2DC7100", Offset = "0x2DC5700", VA = "0x182DC7100", Slot = "12")]
		private void OnDeserialize(StructureDestructionManager.DestructionSaveData payload)
		{
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x2DC7730", Offset = "0x2DC5D30", VA = "0x182DC7730")]
		public StructureDestructionManager()
		{
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000389C File Offset: 0x00001A9C
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x2DC7B00", Offset = "0x2DC6100", VA = "0x182DC7B00")]
		[CompilerGenerated]
		internal static bool <IsTargetUsingDistortedStructures>g__IsDamaged|19_0(Structure s, ref StructureDestructionManager.<>c__DisplayClass19_0 A_1)
		{
			return default(bool);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000038B4 File Offset: 0x00001AB4
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x2DC7BF0", Offset = "0x2DC61F0", VA = "0x182DC7BF0")]
		[CompilerGenerated]
		internal static bool <TryRepair>g__HasSupportThatNeedsRepairFirst|29_0(Structure structureRec, out bool canRepairSupport, ref StructureDestructionManager.<>c__DisplayClass29_0 A_2)
		{
			return default(bool);
		}

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ConstructionManager _constructionManager;

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _siegeDamageRatio;

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _explosionDamageRatio;

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _projectileDamageRatio;

		// Token: 0x04000372 RID: 882
		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _collapseDelayPerElement;

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _explosionForce;

		// Token: 0x04000374 RID: 884
		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0x48")]
		[Header("SFX")]
		[SerializeField]
		private AudioClipProfile _defaultDamageSfx;

		// Token: 0x04000375 RID: 885
		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x50")]
		[Header("Debug")]
		[SerializeField]
		private bool _verbose;

		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x58")]
		private readonly List<IStructureImpactValidator> _validators;

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x60")]
		private readonly List<IStructureImpactProcessor> _processors;

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x68")]
		private readonly List<IUpdateReceiver> _updateReceivers;

		// Token: 0x04000379 RID: 889
		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x70")]
		private readonly Dictionary<Structure, StructureInfo> _structureHealth;

		// Token: 0x0400037A RID: 890
		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x78")]
		private readonly List<Structure> _structureRepairedThisFrame;

		// Token: 0x0400037B RID: 891
		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x80")]
		private readonly HashSet<Structure> _distortedStructures;

		// Token: 0x02000085 RID: 133
		[Token(Token = "0x2000085")]
		[Serializable]
		internal class DestructionSaveData
		{
			// Token: 0x0600038E RID: 910 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x2DC8180", Offset = "0x2DC6780", VA = "0x182DC8180")]
			public DestructionSaveData()
			{
			}

			// Token: 0x0400037C RID: 892
			[Token(Token = "0x400037C")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public string Version;

			// Token: 0x0400037D RID: 893
			[Token(Token = "0x400037D")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty]
			public StructureDestructionManager.SerializableStructureInfo[] Data;
		}

		// Token: 0x02000086 RID: 134
		[Token(Token = "0x2000086")]
		[Serializable]
		internal class SerializableStructureInfo
		{
			// Token: 0x0600038F RID: 911 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SerializableStructureInfo()
			{
			}

			// Token: 0x0400037E RID: 894
			[Token(Token = "0x400037E")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public ushort TypeID;

			// Token: 0x0400037F RID: 895
			[Token(Token = "0x400037F")]
			[FieldOffset(Offset = "0x14")]
			[JsonProperty]
			public uint InstanceID;

			// Token: 0x04000380 RID: 896
			[Token(Token = "0x4000380")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty]
			public StructureInfo Info;
		}

		// Token: 0x02000087 RID: 135
		[Token(Token = "0x2000087")]
		internal static class Utils
		{
			// Token: 0x06000390 RID: 912 RVA: 0x000038CC File Offset: 0x00001ACC
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x2DC8200", Offset = "0x2DC6800", VA = "0x182DC8200")]
			public static float RandSign()
			{
				return 0f;
			}

			// Token: 0x06000391 RID: 913 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x2DC8280", Offset = "0x2DC6880", VA = "0x182DC8280")]
			public static void DestroyElementFromHit(StructureElement element, Vector3 hitPosition, float explosionForce, bool ignoreSpawnPickupsWhenDestroyed, StructureDestructionManager.Utils.DestructionMode destructionMode = StructureDestructionManager.Utils.DestructionMode.ElementDestroyAPI)
			{
			}

			// Token: 0x06000392 RID: 914 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x2DC8DC0", Offset = "0x2DC73C0", VA = "0x182DC8DC0")]
			private static void PostProcessPickup(Transform pickupTr, MeshFilter elementMeshFilter, ElementProfile elementProfile, Vector3 hitPosition, Vector3 rigidbodyForce, float maxDepenetrationVelocity = -1f)
			{
			}

			// Token: 0x06000393 RID: 915 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x2DC9B50", Offset = "0x2DC8150", VA = "0x182DC9B50")]
			private static void TrySetupVisualVariant(StructureElement element, Transform instance)
			{
			}

			// Token: 0x06000394 RID: 916 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x2DC9C60", Offset = "0x2DC8260", VA = "0x182DC9C60")]
			public static Transform DestroyElementFromCollapsedSupport(StructureElement element)
			{
				return null;
			}

			// Token: 0x06000395 RID: 917 RVA: 0x000038E4 File Offset: 0x00001AE4
			[Token(Token = "0x6000395")]
			[Address(RVA = "0xF9B4B0", Offset = "0xF99AB0", VA = "0x180F9B4B0")]
			public static Vector3 CalcHitPosition(Vector3 attackSourcePos)
			{
				return default(Vector3);
			}

			// Token: 0x06000396 RID: 918 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x2DC9FE0", Offset = "0x2DC85E0", VA = "0x182DC9FE0")]
			[CompilerGenerated]
			internal static void <DestroyElementFromHit>g__PerformDestroy|1_0(ref StructureDestructionManager.Utils.<>c__DisplayClass1_0 A_0)
			{
			}

			// Token: 0x02000088 RID: 136
			[Token(Token = "0x2000088")]
			public enum DestructionMode
			{
				// Token: 0x04000382 RID: 898
				[Token(Token = "0x4000382")]
				ElementDestroyAPI,
				// Token: 0x04000383 RID: 899
				[Token(Token = "0x4000383")]
				GameObjectDestroy
			}
		}
	}
}
