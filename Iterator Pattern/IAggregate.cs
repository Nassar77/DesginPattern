﻿interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}
