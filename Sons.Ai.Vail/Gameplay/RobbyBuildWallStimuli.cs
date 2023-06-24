using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public class RobbyBuildWallStimuli : BuildActionStimuli
	{
		// Token: 0x06000082 RID: 130 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2AEE8F0", Offset = "0x2AECEF0", VA = "0x182AEE8F0")]
		public new static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2AEE920", Offset = "0x2AECF20", VA = "0x182AEE920")]
		public new static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2AEE9A0", Offset = "0x2AECFA0", VA = "0x182AEE9A0")]
		private void Start()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2AEEAA0", Offset = "0x2AED0A0", VA = "0x182AEEAA0")]
		private void OnValidate()
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2AEEAE0", Offset = "0x2AED0E0", VA = "0x182AEEAE0")]
		private int GetLogCount()
		{
			return 0;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2AEEB10", Offset = "0x2AED110", VA = "0x182AEEB10")]
		private void CalculateLogPlacements()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2AEEF70", Offset = "0x2AED570", VA = "0x182AEEF70")]
		private void BuildPerimeter()
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2AEF0E0", Offset = "0x2AED6E0", VA = "0x182AEF0E0", Slot = "15")]
		public override void OnInteractAnimEvent(VailActor actor, string param)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2AEF290", Offset = "0x2AED890", VA = "0x182AEF290", Slot = "28")]
		public override int NeedsItem(int itemId)
		{
			return 0;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2AEF2A0", Offset = "0x2AED8A0", VA = "0x182AEF2A0")]
		private Vector3 GetLogPosition(int idx)
		{
			return default(Vector3);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2AEF400", Offset = "0x2AEDA00", VA = "0x182AEF400")]
		public void BuildPillar(Vector3 logPos)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2AEF890", Offset = "0x2AEDE90", VA = "0x182AEF890", Slot = "24")]
		protected override void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2AEFA30", Offset = "0x2AEE030", VA = "0x182AEFA30")]
		public RobbyBuildWallStimuli()
		{
		}

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Transform _buildPoint;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private float _wallRadius;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float _logRadius;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int _doorLogCount;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0xE4")]
		private int _logCount;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0xE8")]
		private List<Vector3> _logPositions;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0xF0")]
		private int _builtElements;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private bool _testBuildOnStart;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0xF8")]
		private GameObject _wall;
	}
}
