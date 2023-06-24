using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Sons.Ai.Vail;
using Sons.Atmosphere;
using Sons.Gameplay;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000738 RID: 1848
	[Token(Token = "0x2000738")]
	[AddComponentMenu("Sons/Characters/Village Object")]
	public class VillageObject : MonoBehaviour
	{
		// Token: 0x0600315E RID: 12638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600315E")]
		[Address(RVA = "0x3488B60", Offset = "0x3487160", VA = "0x183488B60")]
		public void Init(CannibalVillage villageParent, int objectIdx)
		{
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600315F")]
		[Address(RVA = "0x3488BE0", Offset = "0x34871E0", VA = "0x183488BE0")]
		public void SetFamilyId(int familyId)
		{
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003160")]
		[Address(RVA = "0x3488F90", Offset = "0x3487590", VA = "0x183488F90")]
		public void TickServer(int day, float timeInHours, int population)
		{
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003161")]
		[Address(RVA = "0x3489230", Offset = "0x3487830", VA = "0x183489230")]
		public void UpdateVisibility(bool withinActiveDistance)
		{
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003162")]
		[Address(RVA = "0x34897F0", Offset = "0x3487DF0", VA = "0x1834897F0", Slot = "4")]
		public virtual void ShowObject(bool value, bool networkRep)
		{
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x0000F030 File Offset: 0x0000D230
		[Token(Token = "0x6003163")]
		[Address(RVA = "0x3489AE0", Offset = "0x34880E0", VA = "0x183489AE0")]
		protected bool HasFlags(VillageManager.ObjectFlags flags)
		{
			return default(bool);
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003164")]
		[Address(RVA = "0x3489BD0", Offset = "0x34881D0", VA = "0x183489BD0")]
		public void SetCreepy(bool creepyActive)
		{
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003165")]
		[Address(RVA = "0x3489D50", Offset = "0x3488350", VA = "0x183489D50")]
		private void OnBurningChanged(bool burning)
		{
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003166")]
		[Address(RVA = "0x3489E60", Offset = "0x3488460", VA = "0x183489E60")]
		[UsedImplicitly]
		public void SendBreakEvent()
		{
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003167")]
		[Address(RVA = "0x3489E70", Offset = "0x3488470", VA = "0x183489E70")]
		[UsedImplicitly]
		public void SendSpittleBreakEvent()
		{
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003168")]
		[Address(RVA = "0x3489E80", Offset = "0x3488480", VA = "0x183489E80")]
		[UsedImplicitly]
		public void SetVineBreakEvent()
		{
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003169")]
		[Address(RVA = "0x3489E90", Offset = "0x3488490", VA = "0x183489E90")]
		protected void SendBreakEventFlags(VillageManager.ObjectFlags breakFlag)
		{
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316A")]
		[Address(RVA = "0x348A060", Offset = "0x3488660", VA = "0x18348A060")]
		public void OnDeserialized(VillageManager.ObjectFlags flags)
		{
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316B")]
		[Address(RVA = "0x348A180", Offset = "0x3488780", VA = "0x18348A180", Slot = "5")]
		public virtual void OnStateFlagsSet(VillageManager.ObjectFlags flags, bool isLoad)
		{
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316C")]
		[Address(RVA = "0x348A280", Offset = "0x3488880", VA = "0x18348A280", Slot = "6")]
		public virtual void OnStateFlagsRemoved(VillageManager.ObjectFlags flags)
		{
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316D")]
		[Address(RVA = "0x348A320", Offset = "0x3488920", VA = "0x18348A320")]
		public void OnBreakFlagSet(VillageManager.ObjectFlags flag, bool isLoad)
		{
		}

		// Token: 0x0600316E RID: 12654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316E")]
		[Address(RVA = "0x348A480", Offset = "0x3488A80", VA = "0x18348A480")]
		private void ToggleCreepy()
		{
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316F")]
		[Address(RVA = "0x348A550", Offset = "0x3488B50", VA = "0x18348A550")]
		public void SetSeason(SeasonsManager.Season season)
		{
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003170")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void SnapToTerrain()
		{
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003171")]
		[Address(RVA = "0x348A6F0", Offset = "0x3488CF0", VA = "0x18348A6F0", Slot = "7")]
		public virtual void EditorValidate(StringBuilder sb)
		{
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003172")]
		[Address(RVA = "0x348AA50", Offset = "0x3489050", VA = "0x18348AA50")]
		private void CollectRenderers()
		{
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003173")]
		[Address(RVA = "0x348AD10", Offset = "0x3489310", VA = "0x18348AD10")]
		private void AddToNearestVillage()
		{
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003174")]
		[Address(RVA = "0x348B0B0", Offset = "0x34896B0", VA = "0x18348B0B0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003175")]
		[Address(RVA = "0x3486350", Offset = "0x3484950", VA = "0x183486350")]
		public VillageObject()
		{
		}

		// Token: 0x04002A93 RID: 10899
		[Token(Token = "0x4002A93")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _startDay;

		// Token: 0x04002A94 RID: 10900
		[Token(Token = "0x4002A94")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _minPopulation;

		// Token: 0x04002A95 RID: 10901
		[Token(Token = "0x4002A95")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Range(0f, 100f)]
		private float _randomChance;

		// Token: 0x04002A96 RID: 10902
		[Token(Token = "0x4002A96")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _lifetimeDays;

		// Token: 0x04002A97 RID: 10903
		[Token(Token = "0x4002A97")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _respawnCooldownDays;

		// Token: 0x04002A98 RID: 10904
		[Token(Token = "0x4002A98")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _creepyObjects;

		// Token: 0x04002A99 RID: 10905
		[Token(Token = "0x4002A99")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GameObject> _winterObjects;

		// Token: 0x04002A9A RID: 10906
		[Token(Token = "0x4002A9A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<GameObject> _deactivateByDistance;

		// Token: 0x04002A9B RID: 10907
		[Token(Token = "0x4002A9B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<Renderer> _renderers;

		// Token: 0x04002A9C RID: 10908
		[Token(Token = "0x4002A9C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<GameObject> _renderGos;

		// Token: 0x04002A9D RID: 10909
		[Token(Token = "0x4002A9D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private MonoBehaviourStimuli _stimuli;

		// Token: 0x04002A9E RID: 10910
		[Token(Token = "0x4002A9E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BreakableObject _breakableObject;

		// Token: 0x04002A9F RID: 10911
		[Token(Token = "0x4002A9F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BreakableObject _spittleBreakable;

		// Token: 0x04002AA0 RID: 10912
		[Token(Token = "0x4002AA0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BreakableObject _vinesBreakable;

		// Token: 0x04002AA1 RID: 10913
		[Token(Token = "0x4002AA1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 _snapOffset;

		// Token: 0x04002AA2 RID: 10914
		[Token(Token = "0x4002AA2")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private bool _snapRotation;

		// Token: 0x04002AA3 RID: 10915
		[Token(Token = "0x4002AA3")]
		[FieldOffset(Offset = "0x8D")]
		private bool _firstUpdate;

		// Token: 0x04002AA4 RID: 10916
		[Token(Token = "0x4002AA4")]
		[FieldOffset(Offset = "0x8E")]
		private bool _lastWithinActiveDistance;

		// Token: 0x04002AA5 RID: 10917
		[Token(Token = "0x4002AA5")]
		[FieldOffset(Offset = "0x90")]
		private int _lastDayTested;

		// Token: 0x04002AA6 RID: 10918
		[Token(Token = "0x4002AA6")]
		[FieldOffset(Offset = "0x94")]
		private float _lastActiveUpdateTimeHours;

		// Token: 0x04002AA7 RID: 10919
		[Token(Token = "0x4002AA7")]
		[FieldOffset(Offset = "0x98")]
		protected CannibalVillage _village;

		// Token: 0x04002AA8 RID: 10920
		[Token(Token = "0x4002AA8")]
		[FieldOffset(Offset = "0xA0")]
		protected int _villageObjectIdx;
	}
}
