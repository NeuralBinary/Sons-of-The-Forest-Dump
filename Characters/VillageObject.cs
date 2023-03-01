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
	// Token: 0x02000825 RID: 2085
	[Token(Token = "0x2000825")]
	[AddComponentMenu("Sons/Characters/Village Object")]
	public class VillageObject : MonoBehaviour
	{
		// Token: 0x0600377B RID: 14203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377B")]
		[Address(RVA = "0x2EC3BD0", Offset = "0x2EC2BD0", VA = "0x182EC3BD0")]
		public void Init(CannibalVillage villageParent, int objectIdx)
		{
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377C")]
		[Address(RVA = "0x2EC45F0", Offset = "0x2EC35F0", VA = "0x182EC45F0")]
		public void SetFamilyId(int familyId)
		{
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377D")]
		[Address(RVA = "0x2EC4A10", Offset = "0x2EC3A10", VA = "0x182EC4A10")]
		private void TickServer(int day, float timeInHours, int population)
		{
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377E")]
		[Address(RVA = "0x2EC4BC0", Offset = "0x2EC3BC0", VA = "0x182EC4BC0")]
		public void Tick(bool server, bool withinActiveDistance, int day, float timeInHours, int population)
		{
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377F")]
		[Address(RVA = "0x2EC4890", Offset = "0x2EC3890", VA = "0x182EC4890", Slot = "4")]
		public virtual void ShowObject(bool value, bool networkRep)
		{
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x000103F8 File Offset: 0x0000E5F8
		[Token(Token = "0x6003780")]
		[Address(RVA = "0x2EC3AC0", Offset = "0x2EC2AC0", VA = "0x182EC3AC0")]
		protected bool HasFlags(VillageManager.ObjectFlags flags)
		{
			return default(bool);
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003781")]
		[Address(RVA = "0x2EC44D0", Offset = "0x2EC34D0", VA = "0x182EC44D0")]
		public void SetCreepy(bool creepyActive)
		{
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003782")]
		[Address(RVA = "0x2EC3D00", Offset = "0x2EC2D00", VA = "0x182EC3D00")]
		private void OnBurningChanged(bool burning)
		{
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003783")]
		[Address(RVA = "0x2EC44B0", Offset = "0x2EC34B0", VA = "0x182EC44B0")]
		[UsedImplicitly]
		public void SendBreakEvent()
		{
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003784")]
		[Address(RVA = "0x2EC44C0", Offset = "0x2EC34C0", VA = "0x182EC44C0")]
		[UsedImplicitly]
		public void SendSpittleBreakEvent()
		{
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003785")]
		[Address(RVA = "0x2EC4880", Offset = "0x2EC3880", VA = "0x182EC4880")]
		[UsedImplicitly]
		public void SetVineBreakEvent()
		{
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003786")]
		[Address(RVA = "0x2EC4340", Offset = "0x2EC3340", VA = "0x182EC4340")]
		protected void SendBreakEventFlags(VillageManager.ObjectFlags breakFlag)
		{
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003787")]
		[Address(RVA = "0x2EC3E10", Offset = "0x2EC2E10", VA = "0x182EC3E10")]
		public void OnDeserialized(VillageManager.ObjectFlags flags)
		{
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003788")]
		[Address(RVA = "0x2EC4140", Offset = "0x2EC3140", VA = "0x182EC4140", Slot = "5")]
		public virtual void OnStateFlagsSet(VillageManager.ObjectFlags flags, bool isLoad)
		{
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003789")]
		[Address(RVA = "0x2EC40A0", Offset = "0x2EC30A0", VA = "0x182EC40A0", Slot = "6")]
		public virtual void OnStateFlagsRemoved(VillageManager.ObjectFlags flags)
		{
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378A")]
		[Address(RVA = "0x2EC3C20", Offset = "0x2EC2C20", VA = "0x182EC3C20")]
		public void OnBreakFlagSet(VillageManager.ObjectFlags flag, bool isLoad)
		{
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378B")]
		[Address(RVA = "0x2EC4F80", Offset = "0x2EC3F80", VA = "0x182EC4F80")]
		private void ToggleCreepy()
		{
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378C")]
		[Address(RVA = "0x2EC4760", Offset = "0x2EC3760", VA = "0x182EC4760")]
		public void SetSeason(SeasonsManager.Season season)
		{
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378D")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void SnapToTerrain()
		{
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378E")]
		[Address(RVA = "0x2EC3850", Offset = "0x2EC2850", VA = "0x182EC3850", Slot = "7")]
		public virtual void EditorValidate(StringBuilder sb)
		{
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378F")]
		[Address(RVA = "0x2EC35D0", Offset = "0x2EC25D0", VA = "0x182EC35D0")]
		private void CollectRenderers()
		{
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003790")]
		[Address(RVA = "0x2EC3EC0", Offset = "0x2EC2EC0", VA = "0x182EC3EC0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003791")]
		[Address(RVA = "0x2EC1270", Offset = "0x2EC0270", VA = "0x182EC1270")]
		public VillageObject()
		{
		}

		// Token: 0x04002F77 RID: 12151
		[Token(Token = "0x4002F77")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _startDay;

		// Token: 0x04002F78 RID: 12152
		[Token(Token = "0x4002F78")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _minPopulation;

		// Token: 0x04002F79 RID: 12153
		[Token(Token = "0x4002F79")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Range(0f, 100f)]
		private float _randomChance;

		// Token: 0x04002F7A RID: 12154
		[Token(Token = "0x4002F7A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _lifetimeDays;

		// Token: 0x04002F7B RID: 12155
		[Token(Token = "0x4002F7B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _respawnCooldownDays;

		// Token: 0x04002F7C RID: 12156
		[Token(Token = "0x4002F7C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _creepyObjects;

		// Token: 0x04002F7D RID: 12157
		[Token(Token = "0x4002F7D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GameObject> _winterObjects;

		// Token: 0x04002F7E RID: 12158
		[Token(Token = "0x4002F7E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<GameObject> _deactivateByDistance;

		// Token: 0x04002F7F RID: 12159
		[Token(Token = "0x4002F7F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<Renderer> _renderers;

		// Token: 0x04002F80 RID: 12160
		[Token(Token = "0x4002F80")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<GameObject> _renderGos;

		// Token: 0x04002F81 RID: 12161
		[Token(Token = "0x4002F81")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private MonoBehaviourStimuli _stimuli;

		// Token: 0x04002F82 RID: 12162
		[Token(Token = "0x4002F82")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BreakableObject _breakableObject;

		// Token: 0x04002F83 RID: 12163
		[Token(Token = "0x4002F83")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BreakableObject _spittleBreakable;

		// Token: 0x04002F84 RID: 12164
		[Token(Token = "0x4002F84")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BreakableObject _vinesBreakable;

		// Token: 0x04002F85 RID: 12165
		[Token(Token = "0x4002F85")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 _snapOffset;

		// Token: 0x04002F86 RID: 12166
		[Token(Token = "0x4002F86")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private bool _snapRotation;

		// Token: 0x04002F87 RID: 12167
		[Token(Token = "0x4002F87")]
		[FieldOffset(Offset = "0x8D")]
		private bool _firstUpdate;

		// Token: 0x04002F88 RID: 12168
		[Token(Token = "0x4002F88")]
		[FieldOffset(Offset = "0x8E")]
		private bool _lastWithinActiveDistance;

		// Token: 0x04002F89 RID: 12169
		[Token(Token = "0x4002F89")]
		[FieldOffset(Offset = "0x90")]
		private int _lastDayTested;

		// Token: 0x04002F8A RID: 12170
		[Token(Token = "0x4002F8A")]
		[FieldOffset(Offset = "0x94")]
		private float _lastActiveUpdateTimeHours;

		// Token: 0x04002F8B RID: 12171
		[Token(Token = "0x4002F8B")]
		[FieldOffset(Offset = "0x98")]
		protected CannibalVillage _village;

		// Token: 0x04002F8C RID: 12172
		[Token(Token = "0x4002F8C")]
		[FieldOffset(Offset = "0xA0")]
		protected int _villageObjectIdx;
	}
}
