using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001D5 RID: 469
	[Token(Token = "0x20001D5")]
	[AddComponentMenu("Sons/Stimuli/ItemHolderStimuli")]
	public class ItemHolderStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000DD3 RID: 3539 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x2BA7850", Offset = "0x2BA5E50", VA = "0x182BA7850")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x2BA7880", Offset = "0x2BA5E80", VA = "0x182BA7880")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00007DA0 File Offset: 0x00005FA0
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x00007DB8 File Offset: 0x00005FB8
		[Token(Token = "0x170000CA")]
		public virtual bool IsLogSled
		{
			[Token(Token = "0x6000DD6")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x2BA7900", Offset = "0x2BA5F00", VA = "0x182BA7900")]
		private void OnValidate()
		{
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x751010", Offset = "0x74F610", VA = "0x180751010")]
		public MonoBehaviour GetDropTarget()
		{
			return null;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00007DD0 File Offset: 0x00005FD0
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x2BA7A80", Offset = "0x2BA6080", VA = "0x182BA7A80", Slot = "12")]
		public override bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00007DE8 File Offset: 0x00005FE8
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x2BA7B10", Offset = "0x2BA6110", VA = "0x182BA7B10")]
		public bool IsItemType(string vailItemType)
		{
			return default(bool);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public ItemHolderStimuli()
		{
		}

		// Token: 0x040008D4 RID: 2260
		[Token(Token = "0x40008D4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private MonoBehaviour _holderDropTarget;
	}
}
