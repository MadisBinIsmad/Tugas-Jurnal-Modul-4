using System;
using System.Collections.Generic;
using System.Text;

namespace Modul_4_103082400038
{
    class PosisiKarakterGame
    {
        public enum State
        {
            Berdiri,
            Jongkok,
            Tengkurap,
            Terbang
        }

        public enum Trigger
        {
            TombolW,
            TombolS,
            TombolX
        }

        class Transition
        {
            public State prevState;
            public State nextState;
            public Trigger trigger;

            public Transition(State prev, State next, Trigger trigger)
            {
                this.prevState = prev;
                this.nextState = next;
                this.trigger = trigger;
            }
        }

        Transition[] transitions =
        {
            new Transition(State.Berdiri, State.Jongkok, Trigger.TombolS),
            new Transition(State.Jongkok, State.Berdiri, Trigger.TombolW),

            new Transition(State.Jongkok, State.Tengkurap, Trigger.TombolS),
            new Transition(State.Tengkurap, State.Jongkok, Trigger.TombolW),

            new Transition(State.Berdiri, State.Terbang, Trigger.TombolW),
            new Transition(State.Terbang, State.Berdiri, Trigger.TombolS),

            new Transition(State.Terbang, State.Jongkok, Trigger.TombolX)
        };

        public State currentState = State.Berdiri;

        public State GetNextState(State state, Trigger trigger)
        {
            foreach (Transition transition in transitions)
            {
                if (transition.prevState == state && transition.trigger == trigger)
                {
                    return transition.nextState;
                }
            }
            return state;
        }

        public void ActivateTrigger(Trigger trigger)
        {
            State nextState = GetNextState(currentState, trigger);

            // tambahan sesuai NIM % 3 == 2
            if (currentState == State.Berdiri && nextState == State.Terbang)
            {
                Console.WriteLine("posisi take off");
            }

            if (currentState == State.Terbang && nextState == State.Jongkok)
            {
                Console.WriteLine("posisi landing");
            }

            Console.WriteLine("State berubah dari " + currentState + " ke " + nextState);

            currentState = nextState;
        }
    }
}
