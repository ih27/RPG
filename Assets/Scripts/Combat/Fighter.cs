using UnityEngine;
using RPG.Movement;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        [SerializeField] float weaponRange = 2f;
        Transform target;

        private void Update()
        {
            if (target == null) return;

            if (!GetIsInRange())
            {
                GetComponent<Mover>().MoveTo(target.position);
            }
            else
            {
                GetComponent<Mover>().Stop();
            }
        }

        private bool GetIsInRange() => Vector3.Distance(target.position, transform.position) < weaponRange;

        public void Attack(CombatTarget combatTarget) => target = combatTarget.transform;

        public void Cancel() => target = null;
    }
}